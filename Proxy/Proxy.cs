using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;
using Tour.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Tour.Proxy
{
    public class Proxy
    {
        Hotel fHotel;
        PhuongTien fPhuongTien;
        Location fLocation;
        public Proxy() { }
        public Proxy(Hotel hotel)
        {
            this.fHotel = hotel;
        }

        public Proxy(PhuongTien phuongTien)
        {
            this.fPhuongTien = phuongTien;
        }

        public Proxy(Location location)
        {
            this.fLocation = location;
        }
        public void ProxyAddLoggerPhuongTien( string name, byte[] img_data, string so_tinh, string ten_tinh, string loai, string gia)
        {
            try
            {
                //Do before adding
            System.Console.WriteLine("Adding new Vehical: " + name + " \n" + ten_tinh + " \n" + loai + " \n" + gia);
            this.fPhuongTien.addNewVehical(name,img_data, so_tinh, ten_tinh, loai, gia);

                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();
                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE = nhanvien.TEN + " đã thêm mới phương tiện",DATE = DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();

                System.Console.WriteLine("Success adding!");

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
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
        public void ProxyAddLoggerKhachSan(string name, byte[] img_data, string so_tinh, string dia_chi,string sdt, string chi_tiet, string gia)
        {
            try
            {
                //Do before adding
                System.Console.WriteLine("Adding new Vehical: " + name + " \n" + dia_chi + " \n" + gia+" \n"+sdt);

                this.fHotel.addNewHotel(name, img_data, so_tinh, dia_chi, sdt,chi_tiet, gia);
                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();

                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE =nhanvien.TEN+ " đã thêm mới khách sạn", DATE = DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();

                System.Console.WriteLine("Success adding!");

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
        public void ProxyAddLoggerDiaDiem(string name, byte[] img_data, string so_tinh, string ten_tinh, string chi_tiet, string gia)
        {
            try
            {
                //Do before adding
                System.Console.WriteLine("Adding new Vehical: " + name + " \n" + ten_tinh + " \n" + chi_tiet + " \n" + gia);
                this.fLocation.addNewLocation(name, img_data, so_tinh, ten_tinh, chi_tiet, gia);

                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();
                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE = nhanvien.TEN + " đã thêm mới địa điểm du lịch",DATE=DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();
                System.Console.WriteLine("Success adding!");

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

        public void ProxyDeleteLoggerPhuongTien(string id)
        {
            try
            {
                //Do before adding
                System.Console.WriteLine("Delete Vehical: " + id);
                this.fPhuongTien.deleteVehical(id);

                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();
                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE = nhanvien.TEN + " đã xóa phương tiện "+id, DATE = DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();

                System.Console.WriteLine("Success adding!");

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
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }
        public void ProxyDeleteLoggerKhachSan(string id)
        {
            try
            {
                //Do before adding
                System.Console.WriteLine("Delete hotel: " + id);

                this.fHotel.deleteHotel(id);
                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();

                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE = nhanvien.TEN + " đã xóa khách sạn "+id, DATE = DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();

                System.Console.WriteLine("Success adding!");

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
        public void ProxyDeleteLoggerDiaDiem(string id)
        {
            try
            {
                //Do before adding
                System.Console.WriteLine("Delete Location: " + id);
                this.fLocation.deleteLocation(id);
                //Do after adding
                var nhanvien = DataProvider.Ins.DB.NHANVIENs.Where(x => x.ID == Properties.Settings.Default.CurUserId).FirstOrDefault();
                var logger = DataProvider.Ins.DB.LOGGERs.Add(new LOGGER() { ID = Utils.Converter.Instance.RandomString2(9, false), EMPLOYEEID = Properties.Settings.Default.CurUserId, MESSAGE = nhanvien.TEN + " đã xóa địa điểm du lịch " + id, DATE = DateTime.Now });
                DataProvider.Ins.DB.SaveChanges();
                System.Console.WriteLine("Success adding!");

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


        public bool testCheckHotelInput(string name, byte[] img_data, string so_tinh, string dia_chi, string chi_tiet, string gia)
        {
            try
            {
                bool check = this.fHotel.CheckData(name, img_data, so_tinh, dia_chi, chi_tiet, gia);
                return check;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool testCheckLocationInput(string name, byte[] img_data, string so_tinh, string chi_tiet, string gia)
        {
            try
            {
                bool check = this.fLocation.CheckData(name, img_data, so_tinh, chi_tiet, gia);
                return check;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public bool testAddLocation(string name, byte[] img_data, string so_tinh, string ten_tinh, string chi_tiet, string gia)
        {
            try
            {
                //Image image = Image.FromFile("Path");
                //byte[] img_data = Converter.Instance.ImageToByte(image);
                DIADIEM location = this.fLocation.addNewLocation(name, img_data, so_tinh, ten_tinh, chi_tiet, gia);
                return this.fLocation.deleteLocation(location.ID);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }

        public bool testCheckVehicalInput(string name, byte[] img_data, string so_tinh, string loai, string gia)
        {
            try
            {
                bool check = this.fPhuongTien.CheckData(name, img_data, so_tinh, loai, gia);
                return check;

            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool testTypeAInput(object sender, string name, byte[] img_data, string so_tinh, string dia_chi, string chi_tiet, string gia)
        {
            try
            {
                bool check = false;
                if (sender is Hotel)
                {
                    check = this.fHotel.CheckData(name, img_data, so_tinh, dia_chi, chi_tiet, gia);
                }
                return check;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());

                return false;
            }
        }

        public bool testTypeBInput(object sender, string name, byte[] img_data, string so_tinh, string thong_tin, string gia)
        {
            try
            {
                bool check = false;
                if (sender is PhuongTien)
                {
                    check = this.fPhuongTien.CheckData(name, img_data, so_tinh, thong_tin, gia);
                }
                else if (sender is Location)
                {
                    check = this.fLocation.CheckData(name, img_data, so_tinh, thong_tin, gia);
                }
                return check;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
