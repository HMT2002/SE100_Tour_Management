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
    public partial class Location : Form
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

        public Location()
        {
            InitializeComponent();
            cbboxProvince.DataSource = ListProvince;

            showAll();
            cbbxLocation.SelectedIndex = -1;
            Clear();

        }
        public void showAll()
        {
            cbbxLocation.DataSource = DataProvider.Ins.DB.DIADIEMs.Select(t =>t).Where(t=>t.IsDeleted==false).ToList();
            cbbxLocation.DisplayMember = "TEN";
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

            if (txtbxName.Text.Trim().CompareTo(string.Empty) == 0 || img_data == null||cbboxProvince.SelectedIndex==-1)
            {
                return false;
            }
            return true;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {

            Clear();
        }

        private void Clear()
        {
            txtbxId.Text = "";
            txtbxName.Text = "";
            rchtxtbxDetail.Text = "";
            cbboxProvince.Text = "";
            cbbxLocation.SelectedIndex = -1;
            pcbxLocation.Image = null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData() == true)
            {
                try
                {
                    randomcode = Converter.Instance.RandomString(5);
                    if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                    {
                        var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text,IsDeleted=false };
                        DataProvider.Ins.DB.TINHs.Add(tinh);
                        DataProvider.Ins.DB.SaveChanges();
                    }

                    var location = new DIADIEM() { ID = randomcode, TEN = txtbxName.Text, IDTINH = cbboxProvince.SelectedIndex.ToString(), CHITIET = rchtxtbxDetail.Text, PICBI = img_data,IsDeleted=false };

                    DataProvider.Ins.DB.DIADIEMs.Add(location);
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();

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
                Clear();

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
                    DIADIEM diadiem = DataProvider.Ins.DB.DIADIEMs.Where(x => x.ID == id).FirstOrDefault();
                    diadiem.IsDeleted = true;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Clear();

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
                try
                {
                    if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == cbboxProvince.SelectedIndex.ToString()).FirstOrDefault() == null)
                    {
                        var tinh = new TINH() { ID = cbboxProvince.SelectedIndex.ToString(), TEN = cbboxProvince.Text };
                        DataProvider.Ins.DB.TINHs.Add(tinh);
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    var diadiem = DataProvider.Ins.DB.DIADIEMs.Where(x => x.ID == id).FirstOrDefault();
                    diadiem.TEN = txtbxName.Text;
                    diadiem.IDTINH = cbboxProvince.SelectedIndex.ToString();
                    diadiem.CHITIET = rchtxtbxDetail.Text;
                    diadiem.PICBI = img_data;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                Clear();

            }

        }
        private void cbbxLocation_SelectedValueChanged(object sender, EventArgs e)
        {
            int index = cbbxLocation.SelectedIndex;
            if (index >= 0)
            {
                DIADIEM selected_item = (DIADIEM)cbbxLocation.SelectedItem;
                DIADIEM temp = DataProvider.Ins.DB.DIADIEMs.Where(x => x.ID == selected_item.ID).FirstOrDefault();
                pcbxLocation.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);
                id = temp.ID;
                txtbxId.Text = id;
                txtbxName.Text = temp.TEN;
                cbboxProvince.Text = DataProvider.Ins.DB.TINHs.Where(x => x.ID == temp.IDTINH).FirstOrDefault().TEN;
                img_data = temp.PICBI;
                rchtxtbxDetail.Text = temp.CHITIET;
            }
        }
    }
}
