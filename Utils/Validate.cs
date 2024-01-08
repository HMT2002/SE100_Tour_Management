using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour.Utils
{
    public class Validate
    {

        private static Validate instance;

        public static Validate Instance
        {
            get { if (instance == null) instance = new Validate(); return Validate.instance; }
            private set { Validate.instance = value; }
        }
        private Validate()
        {

        }

        public static bool CapitalFlag = false;


        public static void CapitaLetter(object sender, KeyPressEventArgs e)
        {
            try
            {
                System.Windows.Forms.TextBox txtbx = (System.Windows.Forms.TextBox)sender;

                if (txtbx != null)
                {
                    if (CapitalFlag == true || txtbx.Text.Length == 0 || txtbx.Text[txtbx.Text.Length - 1] == (char)Keys.Space)
                    {
                        CapitalFlag = false;
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                    if (e.KeyChar == (char)Keys.Space)
                    {
                        CapitalFlag = true;
                    }

                }
            }
            catch
            {

            }
        }
        public static void EnterCurrencyVnd(object sender)
        {

            try
            {
                System.Windows.Forms.TextBox txtbx =(System.Windows.Forms.TextBox ) sender;

                if (txtbx.Text.Length == 6)
                {
                    txtbx.Text = "";
                }

                decimal price = Convert.ToDecimal(txtbx.Text);

                //MessageBox.Show(price.ToString());
                //return;

                if (price != 0)
                {
                    txtbx.Text = String.Format(CultureInfo.CreateSpecificCulture("vi"), "{0:C3}", price);

                    if (txtbx.Text.Length == 7)
                    {
                        txtbx.SelectionStart = 1;
                        txtbx.SelectionLength = 0;
                    }

                }
            }
            catch
            {

            }
        }
    }
}
