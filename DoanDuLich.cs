using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.SqlServer;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tour.Model;
using Tour.Utils;

namespace Tour
{
    public partial class DoanDuLich : Form
    {
        string id;
        string id_tour;
        string randomcode;
        NhiemVuTrongDoan nhiemVu;

        public DoanDuLich()
        {
            InitializeComponent();
            dgvDoan.AutoGenerateColumns = false;

        }

        private void DoanDuLich_Load(object sender, EventArgs e)
        {
            showAll();
            Clear();
        }

        private void showAll()
        {

            dgvDoan.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                  join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                  where doan.IsDeleted == false && tour.IsDeleted == false &&doan.NGAYKETTHUC>=DateTime.Now

                                  select new {
                                      ID = doan.ID,
                                      TEN = doan.TEN,
                                      NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                      NGAYKETTHUC = doan.NGAYKETTHUC,
                                      CHITIETCHUONGTRINH = doan.CHITIETCHUONGTRINH,
                                      GIA_TOUR =tour.GIA,
                                      TEN_TOUR = tour.TEN,
                                      ID_TOUR = tour.ID,
                                  }).ToList();
            cbbxTour.DataSource = DataProvider.Ins.DB.TOURs.Where(t => t.IsDeleted == false).Select(t => t).ToList();
            cbbxTour.DisplayMember = "TEN";

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;

            if (index >= 0)
            {
                id = dgvDoan.Rows[index].Cells["data_ID"].Value.ToString();
                id_tour = dgvDoan.Rows[index].Cells["idtour"].Value.ToString();

                txtbxIDDoan.Text = id;

                datetimeNgayKhoiHanh.Value = (DateTime)dgvDoan.Rows[index].Cells["NGAYKHOIHANH"].Value;
                datetimeNgayKetThuc.Value = (DateTime)dgvDoan.Rows[index].Cells["NGAYKETTHUC"].Value;
                int thoi_han =Convert.ToInt32(( datetimeNgayKetThuc.Value - datetimeNgayKhoiHanh.Value).TotalDays)+1;

                txtbxTenDoan.Text= dgvDoan.Rows[index].Cells["TEN"].Value.ToString();



                decimal tong_gia_tour = Convert.ToDecimal(DataProvider.Ins.DB.tb_DIADIEM_DULICH.Where(x => x.IDTOUR == id_tour && x.IsDeleted == false).Select(x => x.DIADIEM.GIA).Sum());
                decimal tong_gia_khach_san= Convert.ToDecimal(DataProvider.Ins.DB.tb_KHACHSAN.Where(x => x.IDDOAN == id && x.IsDeleted == false).Select(x => x.KHACHSAN.GIA).Sum() * thoi_han);
                decimal tong_gia_phuong_tien = Convert.ToDecimal(DataProvider.Ins.DB.tb_PHUONGTIEN.Where(x => x.IDDOAN == id && x.IsDeleted == false).Select(x => x.PHUONGTIEN.GIA).Sum()*thoi_han);
                txtbxChiPhi.Text =(tong_gia_khach_san + tong_gia_phuong_tien + tong_gia_tour).ToString();

                cbbxTour.Text = dgvDoan.Rows[index].Cells["TENTOUR"].Value.ToString();
                dgvKhachHang.DataSource= (from ve in DataProvider.Ins.DB.VEs
                                           where ve.IDDOAN == id && ve.IsDeleted==false
                                           select new
                                           {
                                               ID = ve.KHACHHANG.ID,
                                               TEN = ve.KHACHHANG.TENKH,
                                           }).ToList();

                dgvKhachSan.DataSource = (from ks in DataProvider.Ins.DB.KHACHSANs
                                            join tb_belong in DataProvider.Ins.DB.tb_KHACHSAN on ks.ID equals tb_belong.IDKHACHSAN
                                            where tb_belong.IDDOAN == id && tb_belong.IsDeleted==false
                                            select new
                                            {
                                                ID = ks.ID,
                                                TEN = ks.TEN,
                                            }).ToList();

                dgvPhuongTien.DataSource = (from pt in DataProvider.Ins.DB.PHUONGTIENs
                                            join tb_belong in DataProvider.Ins.DB.tb_PHUONGTIEN on pt.ID equals tb_belong.IDPHUONGTIEN
                                            where tb_belong.IDDOAN == id && tb_belong.IsDeleted==false
                                            select new
                                            {
                                                ID = pt.ID,
                                                TEN = pt.TEN,
                                            }).ToList();
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
                    if (rdIDSearch.Checked)
                    {
                        dgvDoan.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                              join tb_diadiem in DataProvider.Ins.DB.tb_DIADIEM_DULICH on tour.ID equals tb_diadiem.IDTOUR
                                              join tb_phuongtien in DataProvider.Ins.DB.tb_PHUONGTIEN on doan.ID equals tb_phuongtien.IDDOAN
                                              join tb_khachsan in DataProvider.Ins.DB.tb_KHACHSAN on doan.ID equals tb_khachsan.IDDOAN
                                              where doan.ID.Contains(value) && doan.IsDeleted==false
                                                    select new
                                                    {
                                                        ID = doan.ID,
                                                        TEN = doan.TEN,
                                                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                                        NGAYKETTHUC = doan.NGAYKETTHUC,
                                                        CHITIETCHUONGTRINH = tour.DACDIEM,
                                                        GIA_TOUR = tour.GIA,
                                                        TEN_TOUR = tour.TEN
                                                    }).ToList();


                    }
                    else if (rdNameSearch.Checked)
                    {
                        dgvDoan.DataSource = (from doan in DataProvider.Ins.DB.DOANs
                                                    join tour in DataProvider.Ins.DB.TOURs on doan.IDTOUR equals tour.ID
                                              join tb_diadiem in DataProvider.Ins.DB.tb_DIADIEM_DULICH on tour.ID equals tb_diadiem.IDTOUR
                                              join tb_phuongtien in DataProvider.Ins.DB.tb_PHUONGTIEN on doan.ID equals tb_phuongtien.IDDOAN
                                              join tb_khachsan in DataProvider.Ins.DB.tb_KHACHSAN on doan.ID equals tb_khachsan.IDDOAN
                                              where doan.TEN.Contains(value) &&doan.IsDeleted==false
                                                    select new
                                                    {
                                                        ID = doan.ID,
                                                        TEN = doan.TEN,
                                                        NGAYKHOIHANH = doan.NGAYKHOIHANH,
                                                        NGAYKETTHUC = doan.NGAYKETTHUC,
                                                        CHITIETCHUONGTRINH = tour.DACDIEM,
                                                        GIA_TOUR = tour.GIA,
                                                        TEN_TOUR = tour.TEN
                                                    }).ToList();
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
            if (DateTime.Compare(datetimeNgayKhoiHanh.Value,datetimeNgayKetThuc.Value)>0)
            {
                return false;
            }

            if (txtbxTenDoan.Text.Trim().CompareTo(string.Empty) == 0 || cbbxTour.Text.Trim().CompareTo(string.Empty) == 0)
            {
                return false;
            }

            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (CheckData())
            {
                try
                {
                    randomcode = Converter.Instance.RandomString2(5);
                    var doan = new DOAN() { ID = randomcode, TEN = txtbxTenDoan.Text, NGAYKHOIHANH = datetimeNgayKhoiHanh.Value, NGAYKETTHUC = datetimeNgayKetThuc.Value,IDTOUR= ((TOUR)(cbbxTour.SelectedItem)).ID,IDCHIPHI="0" ,IsDeleted=false};
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
            if (id==null||id.CompareTo(string.Empty) == 0)
            {
                return;
            }
            try
            {
                foreach(var ve in DataProvider.Ins.DB.VEs.Where(x => x.IDDOAN == id))
                {
                    ve.IsDeleted = true;
                }
                DOAN doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id).FirstOrDefault();
                doan.IsDeleted = true;
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
            if (CheckData() == true)
            {
                if (id == null || id.CompareTo(string.Empty) == 0)
                {
                    return;
                }
                try
                {
                    var doan = DataProvider.Ins.DB.DOANs.Where(x => x.ID == id&&x.IsDeleted==false).FirstOrDefault();
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
            txtbxIDDoan.Text = txtbxTenDoan.Text = txtbxChiPhi.Text = cbbxTour.Text="";
            cbbxTour.SelectedIndex = -1;
            datetimeNgayKhoiHanh.Value = datetimeNgayKetThuc.Value = DateTime.Now;
            id = "";
            dgvKhachHang.DataSource = null;
            dgvKhachSan.DataSource = null;
            dgvPhuongTien.DataSource = null;

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
            if (id == null || id.CompareTo(string.Empty) == 0)
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
            if (id == null || id.CompareTo(string.Empty) == 0)
            {
                return;
            }

            AddVehicalForGroup h = new AddVehicalForGroup(id);
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
            if (id.Trim().CompareTo(string.Empty) != 0)
            {
                using (NhiemVuTrongDoan nv = new NhiemVuTrongDoan(id))
                {
                    this.Hide();
                    nv.ShowDialog();
                    this.Show();
                }
            }

        }
    }
}
