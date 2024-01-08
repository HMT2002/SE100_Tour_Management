using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.CollectionLists;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class PhuongTien : Form
    {
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

        Image img;
        Byte[] img_data;
        string randomcode;
        string id;

            DALVehicalCollection vehicalCollection = new DALVehicalCollection();


        public PhuongTien()
        {
            InitializeComponent();
            cbbxKind.DataSource = new List<string> { "Tàu", "Xe hai bánh", "Xe bốn bánh", "Xe buýt", "Máy bay" };
            cbboxProvince.DataSource = ListProvince;

        }

        public void showAll()
        {
            cbbxVehical.DataSource = vehicalCollection.AllVehicalList();
            cbbxVehical.DisplayMember = "TEN";
        }
        private void Clear()
        {
            txtbxName.Text = "";
            rchtxtbxDetail.Text = "";
            cbbxVehical.Text = "";
            cbbxKind.Text = "";
            txtbxGia.Text = "";
            cbbxKind.SelectedIndex = -1;
            cbbxVehical.SelectedIndex = -1;
            cbboxProvince.SelectedIndex = -1;
            pcbxVehical.Image = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void btnPickPicture_Click(object sender, EventArgs e)
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
        public bool CheckData(string name, byte[] img_data, string so_tinh, string loai,string gia)
        {
            if (name.Trim().CompareTo(string.Empty) == 0 || img_data == null || Convert.ToInt32(so_tinh) == 0 || loai.Trim().CompareTo(string.Empty) == 0|| Convert.ToDecimal(gia)==0)
            {
                return false;
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData(txtbxName.Text,img_data, cbboxProvince.SelectedIndex.ToString(),cbbxKind.Text, txtbxGia.Text) == true)
            {
                try
                {
                    randomcode = Converter.Instance.RandomString2(5);
                    if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                    {
                        var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text ,IsDeleted=false};
                        DataProvider.Ins.DB.TINHs.Add(tinh);
                        DataProvider.Ins.DB.SaveChanges();
                    }

                    var vehical = new PHUONGTIEN() { ID = randomcode, TEN = txtbxName.Text, IDTINH = cbboxProvince.SelectedIndex.ToString(), PICBI = img_data,LOAI=cbbxKind.Text,IsDeleted=false ,GIA=Convert.ToDecimal( txtbxGia.Text)};

                    vehicalCollection.AllVehicalList().Add(vehical);
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


        public PHUONGTIEN addNewVehical(string name, byte[] img_data, string so_tinh, string ten_tinh,string loai, string gia)
        {
            try
            {
                randomcode = Converter.Instance.RandomString2(5);
                if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == so_tinh).FirstOrDefault() == null)
                {
                    var tinh = new TINH() { ID = so_tinh, TEN = ten_tinh, IsDeleted = false };
                    DataProvider.Ins.DB.TINHs.Add(tinh);
                    DataProvider.Ins.DB.SaveChanges();
                }

                var vehical = new PHUONGTIEN() { ID = randomcode, TEN =name, IDTINH = so_tinh, PICBI = img_data, LOAI = loai, IsDeleted = false, GIA = Convert.ToDecimal(gia) };

                vehicalCollection.AllVehicalList().Add(vehical);
                DataProvider.Ins.DB.SaveChanges();
                return vehical;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public bool deleteVehical(string id)
        {
            try
            {
                var phuongtien = vehicalCollection.AllVehicalList().Where(x => x.ID == id).FirstOrDefault();
                phuongtien.IsDeleted = true;
                DataProvider.Ins.DB.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
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

                    var phuongtien = vehicalCollection.AllVehicalList().Where(x => x.ID == id).FirstOrDefault();
                    phuongtien.IsDeleted = true;
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
            if (CheckData(txtbxName.Text, img_data, cbboxProvince.SelectedIndex.ToString(), cbbxKind.Text, txtbxGia.Text) == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                    {
                        var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text };
                        DataProvider.Ins.DB.TINHs.Add(tinh);
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    var phuongtien = vehicalCollection.AllVehicalList().Where(x => x.ID == id).FirstOrDefault();
                    phuongtien.TEN = txtbxName.Text;
                    phuongtien.IDTINH = cbboxProvince.SelectedIndex.ToString();
                    phuongtien.LOAI = cbbxKind.Text;
                    phuongtien.PICBI = img_data;
                    phuongtien.GIA =Convert.ToDecimal( txtbxGia.Text);
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void cbbxVehical_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbbxVehical.SelectedIndex;
            if (index >= 0)
            {
                PHUONGTIEN selected_item = (PHUONGTIEN)cbbxVehical.SelectedItem;
                id = selected_item.ID;

                PHUONGTIEN temp = vehicalCollection.AllVehicalList().Where(x => x.ID == selected_item.ID).FirstOrDefault();
                pcbxVehical.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);
                txtbxName.Text = temp.TEN;
                cbbxKind.Text = temp.LOAI;
                cbboxProvince.Text = DataProvider.Ins.DB.TINHs.Where(x => x.ID == temp.IDTINH).FirstOrDefault().TEN;
                img_data = temp.PICBI;
                txtbxGia.Text = temp.GIA.ToString();
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

        private void PhuongTien_Load(object sender, EventArgs e)
        {
            showAll();
            Clear();
        }
    }
}
