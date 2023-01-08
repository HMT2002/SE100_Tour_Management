using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class PhuongTien : Form
    {
        List<string> ListProvince = new List<string>() {
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

        Image img;
        Byte[] img_data;
        string randomcode;
        string id;

        List<string> ListTypePhuongTien = new List<string> { "Train", "Motorcycle", "Car", "Bus", "Plan", "Ship" };


        public PhuongTien()
        {
            InitializeComponent();
            cbbxKind.DataSource = ListTypePhuongTien;
            cbboxProvince.DataSource = ListProvince;
            showAll();
            Clear();

        }

        public void showAll()
        {
            cbbxVehical.DataSource = DataProvider.Ins.DB.PHUONGTIENs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
            cbbxVehical.DisplayMember = "TEN";
        }
        private void Clear()
        {
            int id_num = 1;
            id = "VE" + id_num;

            while (DataProvider.Ins.DB.PHUONGTIENs.Where(x => x.ID == id).FirstOrDefault() != null)
            {
                id_num++;
                id = "VE" + id_num.ToString();
            }

            txtbxName.Text = "";
            rchtxtbxDetail.Text = "";
            cbbxVehical.Text = "";
            cbbxKind.Text = "";
            txtbxGia.Text = "";
            cbbxVehical.SelectedIndex = -1;
            cbboxProvince.SelectedIndex = -1;

            cbbxKind.SelectedIndex = -1;

            pcbxVehical.Image = Properties.Resources.ic_image_empty_128;
            img_data = Converter.Instance.ImageToByte(Properties.Resources.ic_image_empty_128);

            UnnotifyAllFields();
        }

        public void UnnotifyAllFields()
        {
            Notify.UnnotificationField(txtbxName);
            Notify.UnnotificationSelect(cbboxProvince);
            Notify.UnnotificationSelect(cbbxKind);
            Notify.UnnotificationField(txtbxGia);



        }

        private bool CheckData()
        {
            bool flag = true;

            if (txtbxName.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(txtbxName);
                flag = false;
            }
            if (txtbxGia.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(txtbxGia);
                flag = false;
            }
            if (cbboxProvince.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationSelect(cbboxProvince);
                flag = false;
            }
            if (cbbxKind.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationSelect(cbbxKind);
                flag = false;
            }

            //if (DataProvider.Ins.DB.PHUONGTIENs.Where(x => x.ID == id).FirstOrDefault() != null)
            //{
            //    flag = false;
            //}

            return flag;
        }

        public void AddVehical()
        {
            try
            {
                if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                {
                    var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text, IsDeleted = false };
                    DataProvider.Ins.DB.TINHs.Add(tinh);
                    DataProvider.Ins.DB.SaveChanges();
                }

                var vehical = new PHUONGTIEN() { ID = id, TEN = txtbxName.Text, IDTINH = cbboxProvince.SelectedIndex.ToString(), PICBI = img_data, LOAI = cbbxKind.Text, IsDeleted = false, GIA = Converter.Instance.CurrencyStringToDecimalByReplaceCharacter(txtbxGia.Text) };

                DataProvider.Ins.DB.PHUONGTIENs.Add(vehical);
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

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (CheckData() == true)
            {
                AddVehical();
            }
        }


        public void DeleteVehical()
        {
            try
            {
                var phuongtien = DataProvider.Ins.DB.PHUONGTIENs.Where(x => x.ID == id).FirstOrDefault();
                DataProvider.Ins.DB.tb_PHUONGTIEN.RemoveRange(DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x=>x.IDPHUONGTIEN==phuongtien.ID));
                DataProvider.Ins.DB.PHUONGTIENs.Remove(phuongtien);
                DataProvider.Ins.DB.SaveChanges();
                showAll();
                Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                if (MessageBox.Show("Are you sure to delete this?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DeleteVehical();
                }
            }
        }

        public void UpdateVehical()
        {
            try
            {
                if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                {
                    var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text };
                    DataProvider.Ins.DB.TINHs.Add(tinh);
                    DataProvider.Ins.DB.SaveChanges();
                }
                var phuongtien = DataProvider.Ins.DB.PHUONGTIENs.Where(x => x.ID == id).FirstOrDefault();
                phuongtien.TEN = txtbxName.Text;
                phuongtien.IDTINH = cbboxProvince.SelectedIndex.ToString();
                phuongtien.LOAI = cbbxKind.Text;
                phuongtien.PICBI = img_data;
                phuongtien.GIA = Converter.Instance.CurrencyStringToDecimal(txtbxGia.Text);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                UpdateVehical();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtbxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
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
                pcbxVehical.Image = image;

            }
        }

        private void cbbxVehical_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbbxVehical.SelectedIndex;
            if (index >= 0)
            {
                PHUONGTIEN selected_item = (PHUONGTIEN)cbbxVehical.SelectedItem;
                id = selected_item.ID;

                PHUONGTIEN temp = DataProvider.Ins.DB.PHUONGTIENs.Where(x => x.ID == selected_item.ID).FirstOrDefault();
                pcbxVehical.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);
                txtbxName.Text = temp.TEN;
                cbbxKind.Text = temp.LOAI;
                cbboxProvince.Text = DataProvider.Ins.DB.TINHs.Where(x => x.ID == temp.IDTINH).FirstOrDefault().TEN;
                img_data = temp.PICBI;
                txtbxGia.Text = Converter.Instance.CurrencyDisplay((decimal)temp.GIA);
            }
        }

        private void cbbxKind_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelect(sender);

        }

        private void cbboxProvince_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelect(sender);

        }

        private void txtbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);

        }

        private void txtbxGia_TextChanged(object sender, EventArgs e)
        {
            Utils.Validate.EnterCurrencyVnd(sender);

        }
    }
}
