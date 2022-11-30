using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Tour.Utils
{
    class Converter
    {
        public Random random = new Random();
        public string RandomString(int length)
        {
            string chars = "ABCDABCDEFGHIJKLMNOPQRSTUVWXYZ01234567FGHIJKLMNOPQRSTUVGHIJKLMNOPQxXxTueDepTraiVipProxXxRSTUVBCDEFGHIJKLMNOPQRSTUVWXYZ01234567ABCDEFGHIJKLMNOPQRS8967LABCDELMNOPQRSTUVWXYZ0123456789MNOPQRSTUVWXYZ0123456789";
            random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        public string RandomString2(int size, bool lowerCase = false)
        {
            var builder = new StringBuilder(size);

            // Unicode/ASCII Letters are divided into two blocks
            // (Letters 65–90 / 97–122):
            // The first group containing the uppercase letters and
            // the second group containing the lowercase.  

            // char is a single Unicode character  
            char offset = lowerCase ? 'a' : 'A';
            const int lettersOffset = 26; // A...Z or a..z: length=26  

            for (var i = 0; i < size; i++)
            {
                var @char = (char)random.Next(offset, offset + lettersOffset);
                builder.Append(@char);
            }

            return lowerCase ? builder.ToString().ToLower() : builder.ToString();
        }

        public byte[] ImageToByte(Image img)
        {
            ImageConverter converter = new ImageConverter();
            return (byte[])converter.ConvertTo(img, typeof(byte[]));
        }

        public Image ByteArrayToImage(byte[] bytesArr)
        {
            if (bytesArr == null)
            {
                return null;
            }
            using (MemoryStream memstr = new MemoryStream(bytesArr))
            {
                Image img = Image.FromStream(memstr);
                return img;
            }
        }

        private static Converter instance;


        public static Converter Instance
        {
            get { if (instance == null) instance = new Converter(); return Converter.instance; }
            private set { Converter.instance = value; }
        }
        private Converter()
        {

        }

        public Byte[] ConvertImageToBytes(string imageFileName)
        {
            FileStream fs = new FileStream(imageFileName, FileMode.Open, FileAccess.Read);

            //Initialize a byte array with size of stream
            byte[] imgByteArr = new byte[fs.Length];

            //Read data from the file stream and put into the byte array
            fs.Read(imgByteArr, 0, Convert.ToInt32(fs.Length));

            //Close a file stream
            fs.Close();
            return imgByteArr;
        }
        public string Base64Encode(string plainText)
        {
            string res = "";
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            res = System.Convert.ToBase64String(plainTextBytes);
            return res;
        }
        public string Base64Decode(string base64Text)
        {
            string res = "";
            var data = Convert.FromBase64String(base64Text);
            res = Encoding.UTF8.GetString(data);
            return res;
        }
        string key { get; set; } = "eFh4VHVlRGVwVHJhxXxTueDepTraiVjpProxXxaVZqcFByb3hYeA==";

        public string MD5Encrypt(string text)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateEncryptor())
                    {
                        byte[] textBytes = UTF8Encoding.UTF8.GetBytes(text);
                        byte[] bytes = transform.TransformFinalBlock(textBytes, 0, textBytes.Length);
                        return Convert.ToBase64String(bytes, 0, bytes.Length);
                    }
                }
            }
        }

        public string EncryptPassword(string password)
        {
            string encrypt= MD5Encrypt(Base64Encode(password));

            return encrypt;
        }

        public string DecryptEncrypt(string encrypt)
        {
            return Base64Decode(MD5Decrypt(encrypt));
        }

        public string MD5Decrypt(string cipher)
        {
            using (var md5 = new MD5CryptoServiceProvider())
            {
                using (var tdes = new TripleDESCryptoServiceProvider())
                {
                    tdes.Key = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                    tdes.Mode = CipherMode.ECB;
                    tdes.Padding = PaddingMode.PKCS7;

                    using (var transform = tdes.CreateDecryptor())
                    {
                        byte[] cipherBytes = Convert.FromBase64String(cipher);
                        byte[] bytes = transform.TransformFinalBlock(cipherBytes, 0, cipherBytes.Length);
                        return UTF8Encoding.UTF8.GetString(bytes);
                    }
                }
            }
        }

        public decimal CurrencyStringToDecimal(string CurrencyStr)
        {
            decimal res = 0;


            // Regex to extract the number part from the string (supports thousands and decimal separators)
            // Simple replace of all non numeric and non ',' '.' characters with nothing might suffice as well
            // Depends on the input you receive
            var regex = new Regex("^[^\\d-]*(-?(?:\\d|(?<=\\d)\\.(?=\\d{3}))+(?:,\\d+)?|-?(?:\\d|(?<=\\d),(?=\\d{0}))+(?:\\.\\d+)?)[^\\d]*$");

            char decimalChar;
            char thousandsChar;

            // Get the numeric part from the string
            var numberPart = regex.Match(CurrencyStr).Groups[1].Value;

            // Try to guess which character is used for decimals and which is used for thousands
            if (numberPart.LastIndexOf(',') > numberPart.LastIndexOf('.'))
            {
                decimalChar = ',';
                thousandsChar = '.';
            }
            else
            {
                decimalChar = '.';
                thousandsChar = ',';
            }

            // Remove thousands separators as they are not needed for parsing
            numberPart = numberPart.Replace(thousandsChar.ToString(), string.Empty);

            // Replace decimal separator with the one from InvariantCulture
            // This makes sure the decimal parses successfully using InvariantCulture
            numberPart = numberPart.Replace(decimalChar.ToString(),
                CultureInfo.InvariantCulture.NumberFormat.CurrencyDecimalSeparator);

            // Voilá
            res = decimal.Parse(numberPart, NumberStyles.AllowDecimalPoint | NumberStyles.Number, CultureInfo.InvariantCulture);

            return res;
        }

        public decimal CurrencyStringToDecimalByReplaceCharacter(string CurrencyStr)
        {
            decimal res = 0;
            string temp=CurrencyStr.Trim().Replace(".",string.Empty).Replace(",",".").Replace("₫", string.Empty);
            res = decimal.Parse(temp);

            return res;
        }


        public string CurrencyDisplay(decimal dec)
        {
            return (dec).ToString("C0", CultureInfo.CreateSpecificCulture("vi"));
        }
    }

}
