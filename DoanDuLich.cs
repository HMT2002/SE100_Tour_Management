using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class DoanDuLich : Form
    {
        string id;
        string id_tour;
        string randomcode;
        int thoi_han;
        NhiemVuTrongDoan nhiemVu;

        public DoanDuLich()
        {
            InitializeComponent();
            dgvDoan.AutoGenerateColumns = false;

        }

        private void DoanDuLich_Load(object sender, EventArgs e)
        {
            RdbtnAll.Checked = true;
            showAll();
            Clear();
        }

        private void showAll()
        {
            if (RdbtnAll.Checked)
            {
                dgvDoan.DataSource = GroupDisplayTypeList.Instance.AllType();

            }
            else if (RdbtnPlanning.Checked)
            {
                dgvDoan.DataSource = GroupDisplayTypeList.Instance.PlanningType();

            }
            else if (RdbtnOngoing.Checked)
            {
                dgvDoan.DataSource = GroupDisplayTypeList.Instance.OngoingType();


            }
            else if (RdbtnEnded.Checked)
            {
                dgvDoan.DataSource = GroupDisplayTypeList.Instance.EndedType();

            }
            cbbxTour.DataSource = DataProvider.Ins.DB.TOURs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
            cbbxTour.DisplayMember = "TEN";
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Clear();
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = dgvDoan.Rows[index].Cells["data_ID"].Value.ToString();
                id_tour = dgvDoan.Rows[index].Cells["idtour"].Value.ToString();

                txtbxIDDoan.Text = id;

                datetimeNgayKhoiHanh.Value = (DateTime)dgvDoan.Rows[index].Cells["NGAYKHOIHANH"].Value;
                datetimeNgayKetThuc.Value = (DateTime)dgvDoan.Rows[index].Cells["NGAYKETTHUC"].Value;
                thoi_han = Convert.ToInt32((datetimeNgayKetThuc.Value - datetimeNgayKhoiHanh.Value).TotalDays) + 1;

                txtbxTenDoan.Text = dgvDoan.Rows[index].Cells["TEN"].Value.ToString();

                decimal tong_gia_tour = Convert.ToDecimal(DataProvider.Ins.DB.TOURs.Where(x => x.ID == id_tour).FirstOrDefault().GIA);
                //decimal tong_gia_khach_san = Convert.ToDecimal(DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.IDDOAN == id && x.IsDeleted == false).Select(x => x.KHACHSAN.GIA).Sum() * thoi_han);
                //decimal tong_gia_phuong_tien = Convert.ToDecimal(DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x => x.IDDOAN == id && x.IsDeleted == false).Select(x => x.PHUONGTIEN.GIA).Sum() * thoi_han);
                txtbxChiPhi.Text = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault().GIA.ToString();

                cbbxTour.Text = dgvDoan.Rows[index].Cells["TENTOUR"].Value.ToString();
                dgvKhachHang.DataSource =IDAndNameTypeList.Instance.ListKhachHang(id);

                dgvKhachSan.DataSource = IDAndNameTypeList.Instance.ListKhachSan(id);

                dgvPhuongTien.DataSource = IDAndNameTypeList.Instance.ListPhuongTien(id);
            }

        }

        private void rdIDSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void rdNameSearch_Enter(object sender, EventArgs e)
        {
            tb_search.Text = "";

        }

        private void tb_search_TextChanged(object sender, EventArgs e)
        {
            string value = tb_search.Text.Trim();
            if (!string.IsNullOrEmpty(value))
            {
                try
                {
                    if (cbbxSearchType.SelectedItem.ToString() == "ID")
                    {
                        if (RdbtnAll.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.AllType(value, "");

                        }
                        else if (RdbtnPlanning.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.PlanningType(value, "");

                        }
                        else if (RdbtnOngoing.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.OngoingType(value, "");


                        }
                        else if (RdbtnEnded.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.EndedType(value, "");
                        }

                    }
                    else if (cbbxSearchType.SelectedItem.ToString() == "NAME")
                    {
                        if (RdbtnAll.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.AllType("", value);

                        }
                        else if (RdbtnPlanning.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.PlanningType("", value);

                        }
                        else if (RdbtnOngoing.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.OngoingType("", value);


                        }
                        else if (RdbtnEnded.Checked)
                        {
                            dgvDoan.DataSource = GroupDisplayTypeList.Instance.EndedType("", value);
                        }

                    }
                }
                catch
                {

                }
            }
            else { showAll(); }
        }
        public bool CheckData()
        {

            bool flag = true;
            if (DateTime.Compare(datetimeNgayKhoiHanh.Value, datetimeNgayKetThuc.Value) > 0)
            {
                Notify.NotificationSelectDateTime(datetimeNgayKhoiHanh);
                Notify.NotificationSelectDateTime(datetimeNgayKetThuc);

                flag = false;
            }
            if (DateTime.Compare(DateTime.Now.Date, datetimeNgayKhoiHanh.Value) > 0)
            {
                Notify.NotificationSelectDateTime(datetimeNgayKhoiHanh);

                flag = false;
            }


            if (cbbxTour.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationSelect(cbbxTour);
                flag = false;
            }

            if (txtbxTenDoan.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(txtbxTenDoan);
                flag = false;
            }

            //if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() != null)
            //{
            //    Notify.NotificationField(txtbxIDDoan);
            //    flag = false;
            //}

            return flag;
        }

        public bool CheckUpdateData()
        {

            bool flag = true;


            if (DateTime.Compare(datetimeNgayKhoiHanh.Value, datetimeNgayKetThuc.Value) > 0)
            {
                Notify.NotificationSelectDateTime(datetimeNgayKhoiHanh);
                Notify.NotificationSelectDateTime(datetimeNgayKetThuc);

                flag = false;
            }


            if (cbbxTour.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationSelect(cbbxTour);
                flag = false;
            }

            if (txtbxTenDoan.Text.Trim().CompareTo(string.Empty) == 0)
            {
                Notify.NotificationField(txtbxTenDoan);
                flag = false;
            }

            //if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() != null)
            //{
            //    Notify.NotificationField(txtbxIDDoan);
            //    flag = false;
            //}

            return flag;
        }



        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() != null)
            {
                return;
            }
            if (CheckData())
            {

                try
                {
                    //randomcode = Converter.Instance.RandomString2(5);
                    if (DataProvider.Ins.DB.CHIPHIs.Where(x => x.ID == "0").FirstOrDefault() == null)
                    {
                        DataProvider.Ins.DB.CHIPHIs.Add(new CHIPHI() { ID = "0", PHICHOI = 0, PHIKHAC = 0, PHIAN = 0, TONG = 0, IsDeleted = false });
                        DataProvider.Ins.DB.SaveChanges();
                    }
                    var doan = new DOAN()
                    {
                        ID = txtbxIDDoan.Text.Trim(),
                        TEN = txtbxTenDoan.Text,
                        NGAYKHOIHANH = datetimeNgayKhoiHanh.Value,
                        NGAYKETTHUC = datetimeNgayKetThuc.Value,
                        IDTOUR = ((TOUR)(cbbxTour.SelectedItem)).ID,
                        IsDeleted = false,
                        GIA = DataProvider.Ins.DB.TOURs.Where(x => x.ID == ((TOUR)(cbbxTour.SelectedItem)).ID).FirstOrDefault().GIA
                    };
                    //doan.GIA = DataProvider.Ins.DB.TOURs.Where(x => x.ID == ((TOUR)(cbbxTour.SelectedItem)).ID).FirstOrDefault().GIA;
                    DataProvider.Ins.DB.DOANs.Add(doan);
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
            if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() == null)
            {
                return;
            }
            try
            {
                foreach (var ve in DataProvider.Ins.DB.VEs.Where(x => x.IDDOAN == id))
                {
                    ve.IsDeleted = true;
                }
                DOAN doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault();
                DataProvider.Ins.DB.tb_KHACHSAN.RemoveRange(DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.IDDOAN == doan.ID));
                DataProvider.Ins.DB.tb_NHIEMVU.RemoveRange(DataProvider.Ins.DB.tb_NHIEMVU.Where(x => x.IDDOAN == doan.ID));
                DataProvider.Ins.DB.tb_PHUTRACH.RemoveRange(DataProvider.Ins.DB.tb_PHUTRACH.Where(x => x.IDDOAN == doan.ID));
                DataProvider.Ins.DB.tb_PHUONGTIEN.RemoveRange(DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x => x.IDDOAN == doan.ID));
                DataProvider.Ins.DB.VEs.RemoveRange(DataProvider.Ins.DB.VEs.Where(x => x.IDDOAN == doan.ID));

                DataProvider.Ins.DB.DOANs.Remove(doan);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text.Trim()).FirstOrDefault() == null)
            {
                return;
            }
            if (CheckUpdateData() == true)
            {

                try
                {
                    var doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id && x.IsDeleted == false).FirstOrDefault();
                    doan.TEN = txtbxTenDoan.Text;
                    doan.NGAYKHOIHANH = datetimeNgayKhoiHanh.Value;
                    doan.NGAYKETTHUC = datetimeNgayKetThuc.Value;
                    doan.IDTOUR = ((TOUR)(cbbxTour.SelectedItem)).ID;
                    DataProvider.Ins.DB.SaveChanges();
                    showAll();

                }
                catch
                {

                }
                Clear();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();

        }

        private void Clear()
        {
            cbbxTour.SelectedIndex = -1;
            cbbxTour.SelectedItem = null;
            txtbxTenDoan.Text = "";
            txtbxChiPhi.Text = "";
            cbbxTour.SelectedText = "";
            cbbxTour.Text = "";

            datetimeNgayKhoiHanh.Value = datetimeNgayKetThuc.Value = DateTime.Now;

            int id_num = 1;
            id = "GR" + id_num;

            while (DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault() != null)
            {
                id_num++;
                id = "GR" + id_num.ToString();
            }


            txtbxIDDoan.Text = id;
            dgvKhachHang.DataSource = null;
            dgvKhachSan.DataSource = null;
            dgvPhuongTien.DataSource = null;
            UnnotifyAllFields();

        }
        public void UnnotifyAllFields()
        {
            Notify.UnnotificationField(txtbxTenDoan);
            Notify.UnnotificationSelect(cbbxTour);
            Notify.UnnotificationSelectDateTime(datetimeNgayKhoiHanh);
            Notify.UnnotificationSelectDateTime(datetimeNgayKetThuc);



        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
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

        private void btnAddHotelForGroup_Click(object sender, EventArgs e)
        {
            if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() == null)
            {
                return;
            }

            AddHotelForGroup h = new AddHotelForGroup(id);
            this.Hide();
            h.ShowDialog();
            Clear();

            this.Show();

        }

        private void btnAddVehicalForGroup_Click(object sender, EventArgs e)
        {
            if (DataProvider.Ins.DB.DOANs.Where(x => x.ID == txtbxIDDoan.Text).FirstOrDefault() == null)
            {
                return;
            }

            AddVehicleForGroup h = new AddVehicleForGroup(id);
            this.Hide();
            h.ShowDialog();
            Clear();

            this.Show();


        }

        private void dgvDoan_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            //int index;
            //index = e.RowIndex;
            //string doanid = dgvDoan.Rows[index].Cells[0].Value.ToString().Trim();
            //NhiemVuTrongDoan nv = new NhiemVuTrongDoan();
            //this.Hide();
            //nv.setTextBox(doanid, false);
            //nv.ShowDialog();
            ////ngưng thực hiện lệnh bên dưới cho tới khi form đóng lại
            ////Show() tiếp tục thực hiện các lệnh bên dưới
            //this.Show();

        }

        private void btnNhiemVu_Click(object sender, EventArgs e)
        {
            if (DataProvider.Ins.DB.DOANs.Where(x=>x.ID==id).FirstOrDefault()!=null)
            {
                using (NhiemVuTrongDoan nv = new NhiemVuTrongDoan(id))
                {
                    this.Hide();
                    nv.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Please choose a group to giving tasks");
            }

        }

        private void txtbxTenDoan_KeyPress(object sender, KeyPressEventArgs e)
        {
            Notify.UnnotificationField(sender);
        }

        private void cbbxTour_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelect(sender);

        }

        private void datetimeNgayKhoiHanh_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelectDateTime(sender);

        }

        private void datetimeNgayKetThuc_Enter(object sender, EventArgs e)
        {
            Notify.UnnotificationSelectDateTime(sender);

        }

        private void RdbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            showAll();
        }

        private void RdbtnPlanning_CheckedChanged(object sender, EventArgs e)
        {
            showAll();

        }

        private void RdbtnOngoing_CheckedChanged(object sender, EventArgs e)
        {
            showAll();
            
        }

        private void RdbtnEnded_CheckedChanged(object sender, EventArgs e)
        {
            showAll();

        }
    }
}
