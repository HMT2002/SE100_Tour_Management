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


        }

        DALLocationCollection locationCollection = new DALLocationCollection();
        public void showAll()
        {
            cbbxLocation.DataSource = locationCollection.AllLocationList();
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
        public bool CheckData(string name, byte[] img_data, string so_tinh, string chi_tiet, string gia)
        {

            if (name.Trim().CompareTo(string.Empty) == 0 || img_data == null || Convert.ToInt32(so_tinh) == 0 || Convert.ToDecimal(gia) == 0)
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

        public void Clear()
        {
            txtbxId.Text = "";
            txtbxName.Text = "";
            rchtxtbxDetail.Text = "";

            cbboxProvince.SelectedIndex = cbbxLocation.SelectedIndex = -1;
            txtbxGia.Text = "";
            pcbxLocation.Image = null;
            UnnotifyAllFields();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Proxy.Proxy proxy = new Proxy.Proxy(this);
            proxy.ProxyAddLoggerDiaDiem(txtbxName.Text, img_data, cbboxProvince.SelectedIndex.ToString(), cbboxProvince.Text, rchtxtbxDetail.Text, txtbxGia.Text);
        }


        public void UnnotifyAllFields()
        {
            Notify.Unnotification(txtbxGia);
            Notify.Unnotification(txtbxName);

        }
        public DIADIEM addNewLocation(string name, byte[] img_data, string so_tinh, string ten_tinh, string chi_tiet, string gia)
        {
            try
            {
                randomcode = Converter.Instance.RandomString(5);
                if (DataProvider.Ins.DB.TINHs.Where(x => x.ID == so_tinh).FirstOrDefault() == null)
                {
                    var tinh = new TINH() { ID = so_tinh, TEN = ten_tinh, IsDeleted = false };
                    DataProvider.Ins.DB.TINHs.Add(tinh);
                    DataProvider.Ins.DB.SaveChanges();
                }
                var location = new DIADIEM() { ID = randomcode, TEN = name, IDTINH = so_tinh, CHITIET = chi_tiet, PICBI = img_data, IsDeleted = false, GIA = Convert.ToDecimal(gia) };
                locationCollection.AllLocationList().Add(location);
                DataProvider.Ins.DB.SaveChanges();
                showAll();
                Clear();
                return location;
            }
            catch (Exception ex)
            {
                Utils.Notify.Notification(txtbxName);
                Utils.Notify.Notification(txtbxGia);
                Utils.Notify.Notification(cbboxProvince);
                return null;
            }
        }

        public bool deleteLocation(string id)
        {
            try
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return false;
                }

                DIADIEM diadiem = locationCollection.AllLocationList().Where(x => x.ID == id).FirstOrDefault();
                diadiem.IsDeleted = true;
                DataProvider.Ins.DB.SaveChanges();
                showAll();
                Clear();
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
                //if (id == null || id.CompareTo(string.Empty) == 0)
                //{
                //    return;
                //}
                //try
                //{
                //    DIADIEM diadiem = locationCollection.AllLocationList().Where(x => x.ID == id).FirstOrDefault();
                //    diadiem.IsDeleted = true;
                //    DataProvider.Ins.DB.SaveChanges();
                //    showAll();
                //    Clear();

                //}
                //catch (Exception ex)
                //{
                //    MessageBox.Show("Error " + ex.Message, "Alert", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //}
                Proxy.Proxy proxy = new Proxy.Proxy(this);
                proxy.ProxyDeleteLoggerDiaDiem(id);

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (CheckData(txtbxName.Text, img_data, cbboxProvince.SelectedIndex.ToString(), rchtxtbxDetail.Text, txtbxGia.Text) == true)
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
                    var diadiem = locationCollection.AllLocationList().Where(x => x.ID == id).FirstOrDefault();
                    diadiem.TEN = txtbxName.Text;
                    diadiem.IDTINH = cbboxProvince.SelectedIndex.ToString();
                    diadiem.CHITIET = rchtxtbxDetail.Text;
                    diadiem.PICBI = img_data;
                    diadiem.GIA = Convert.ToDecimal(txtbxGia.Text);
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();
                    Clear();
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
                DIADIEM temp = locationCollection.AllLocationList().Where(x => x.ID == selected_item.ID).FirstOrDefault();
                pcbxLocation.Image = Converter.Instance.ByteArrayToImage(temp.PICBI);
                id = temp.ID;
                txtbxId.Text = id;
                txtbxName.Text = temp.TEN;
                cbboxProvince.Text = DataProvider.Ins.DB.TINHs.Where(x => x.ID == temp.IDTINH).FirstOrDefault().TEN;
                img_data = temp.PICBI;
                rchtxtbxDetail.Text = temp.CHITIET;
                txtbxGia.Text = temp.GIA.ToString();

            }
        }

        private void txtbxGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.Unnotification(sender);
            //if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            //{
            //    e.Handled = true;
            //}
            //if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            //{
            //    e.Handled = true;
            //}

            Utils.Validate.EnterNumberOnly(sender, e);


        }

        private void Location_Load(object sender, EventArgs e)
        {
            showAll();
            cbbxLocation.SelectedIndex = -1;
            Clear();
        }

        private void txtbxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.Unnotification(sender);
        }

        private void cbboxProvince_SelectedIndexChanged(object sender, EventArgs e)
        {
            Utils.Notify.Unnotification(sender);
        }
    }
}
