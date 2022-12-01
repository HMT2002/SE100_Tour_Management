using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class Hotel : Form
    {

        Image img;
        Byte[] img_data;
        string randomcode;
        string id;

        List<string> ListProvince = new List<string>() {
            "",
"An Giang",
"Bà rịa – Vũng tàu",
"Bắc Giang",
"Bắc Kạn",
"Bạc Liêu",
"Bắc Ninh",
"Bến Tre",
"Bình Định",
"Bình Dương",
"Bình Phước",
"Bình Thuận",
"Cà Mau",
"Cần Thơ",
"Cao Bằng",
"Đà Nẵng",
"Đắk Lắk",
"Đắk Nông",
"Điện Biên",
"Đồng Nai",
"Đồng Tháp",
"Gia Lai",
"Hà Giang",
"Hà Nam",
"Hà Nội",
"Hà Tĩnh",
"Hải Dương",
"Hải Phòng",
"Hậu Giang",
"Hòa Bình",
"Hưng Yên",
"Khánh Hòa",
"Kiên Giang",
"Kon Tum",
"Lai Châu",
"Lâm Đồng",
"Lạng Sơn",
"Lào Cai",
"Long An",
"Nam Định",
"Nghệ An",
"Ninh Bình",
"Ninh Thuận",
"Phú Thọ",
"Phú Yên",
"Quảng Bình",
"Quảng Nam",
"Quảng Ngãi",
"Quảng Ninh",
"Quảng Trị",
"Sóc Trăng",
"Sơn La",
"Tây Ninh",
"Thái Bình",
"Thái Nguyên",
"Thanh Hóa",
"Thừa Thiên Huế",
"Tiền Giang",
"Thành phố Hồ Chí Minh",
"Trà Vinh",
"Tuyên Quang",
"Vĩnh Long",
"Vĩnh Phúc",
"Yên Bái",
        };

        public Hotel()
        {
            InitializeComponent();
            cbboxProvince.DataSource = ListProvince;
            showAll();
            cbbxHotel.SelectedIndex = -1;
            Clear();
        }



        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPickPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxLocation.Image = image;

            }
        }
        public bool CheckData()
        {
            if (txtbxName.Text.Trim().CompareTo(string.Empty) == 0 || img_data == null||txtbxDiaChi.Text.Trim().CompareTo(string.Empty) == 0|| Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(txtbxGia.Text) == 0 || cbboxProvince.SelectedIndex == -1)
            {
                return false;
            }
            return true;
        }

        public void showAll()
        {
            cbbxHotel.DataSource = DataProvider.Ins.DB.KHACHSANs.Where(t=>t.IsDeleted==false).ToList();
            cbbxHotel.DisplayMember = "TEN";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                try
                {
                    if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                    {
                        var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text,IsDeleted=false };
                        DataProvider.Ins.DB.TINHs.Add(tinh);
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    randomcode = Converter.Instance.RandomString(5);
                    var location = new KHACHSAN() { ID = randomcode, DIACHI = txtbxDiaChi.Text, PICBI =Converter.Instance.ImageToByte(pcbxLocation.Image),CHITIET=rchtxtbxDetail.Text,GIA= Converter.Instance.CurrencyStringToDecimalByReplaceCharacter( txtbxGia.Text ),IDTINH=cbboxProvince.SelectedIndex.ToString(),SDT=txtbxSDT.Text,TEN=txtbxName.Text,IsDeleted=false};
                    DataProvider.Ins.DB.KHACHSANs.Add(location);
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                    Clear();


                }
                catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
                {
                    Exception raise = dbEx;
                    foreach (var validationErrors in dbEx.EntityValidationErrors)
                    {
                        foreach (var validationError in validationErrors.ValidationErrors)
                        {
                            string message = string.Format("{0}:{1}",
                                validationErrors.Entry.Entity.ToString(),
                                validationError.ErrorMessage);
                            // raise a new exception nesting
                            // the current instance as InnerException
                            raise = new InvalidOperationException(message, raise);
                        }
                    }
                    throw raise;
                }

            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    foreach(var tb_ks in DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.IDKHACHSAN == id))
                    {
                        tb_ks.IsDeleted = true;
                    }
                    KHACHSAN khachsan = DataProvider.Ins.DB.KHACHSANs.Where(x => x.ID == id).FirstOrDefault();
                    khachsan.IsDeleted = true;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                    Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (id == null || id.CompareTo(string.Empty) == 0||cbboxProvince.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return;
            }
            try
            {
                var khachsan = DataProvider.Ins.DB.KHACHSANs.Where(x => x.ID == id).FirstOrDefault();
                khachsan.TEN = txtbxName.Text;
                khachsan.DIACHI = txtbxDiaChi.Text;

                khachsan.IDTINH = cbboxProvince.SelectedIndex.ToString();
                khachsan.CHITIET = rchtxtbxDetail.Text;
                khachsan.PICBI =Converter.Instance.ImageToByte(pcbxLocation.Image);
                khachsan.GIA= Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(txtbxGia.Text);
                DataProvider.Ins.DB.SaveChanges();
                showAll();
                Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void Clear()
        {
            txtbxName.Text = rchtxtbxDetail.Text = txtbxDiaChi.Text = txtbxGia.Text =txtbxName.Text=txtbxSDT.Text= "";
            cbboxProvince.SelectedIndex= cbbxHotel.SelectedIndex = -1;
            pcbxLocation.Image = Properties.Resources.ic_image_empty_128;
            
        }

        private void cbbxHotel_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbbxHotel.SelectedIndex;
            if (index >= 0)
            {

                KHACHSAN selected_item = (KHACHSAN)cbbxHotel.SelectedItem;
                KHACHSAN temp = DataProvider.Ins.DB.KHACHSANs.Where(x => x.ID == selected_item.ID).FirstOrDefault();
                pcbxLocation.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);
                id = temp.ID;
                txtbxName.Text = temp.TEN;
                cbboxProvince.Text = DataProvider.Ins.DB.TINHs.Where(x => x.ID == temp.IDTINH).FirstOrDefault().TEN;
                img_data = temp.PICBI;
                rchtxtbxDetail.Text = temp.CHITIET;
                txtbxGia.Text = Converter.Instance.CurrencyDisplay((decimal) temp.GIA);
                txtbxDiaChi.Text = temp.DIACHI;
                txtbxSDT.Text = temp.SDT;
            }
        }

        private void txtbxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void cbbxHotel_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pcbxLocation_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Chon anh(*.jpg; *.png; *.gif) | *.jpg; *.png; *.gif";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(dialog.FileName);
                img = image;
                img_data = Converter.Instance.ImageToByte(image);
                pcbxLocation.Image = image;

            }
        }


        private void txtbxGia_TextChanged(object sender, EventArgs e)
        {
            Utils.Validate.EnterCurrencyVnd(sender);

        }

        private void txtbxSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
    (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as Guna2TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
