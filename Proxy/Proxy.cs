using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tour.Model;
using Tour.Utils;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Tour.Proxy
{
    public class Proxy
    {
        DangKy fDangKy;
        Hotel fHotel;
        PhuongTien fPhuongTien;
        Location fLocation;

        public Proxy() { }
        public Proxy(DangKy dangky)
        {
            this.fDangKy = dangky;
        }

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
                return false;
            }
        }

        public bool testAddVehical(string name, byte[] img_data, string so_tinh, string ten_tinh, string loai, string gia)
        {
            try
            {

                //Image image = Image.FromFile("Path");
                //byte[] img_data = Converter.Instance.ImageToByte(image);
                PHUONGTIEN phuongtien = this.fPhuongTien.addNewVehical(name, img_data, so_tinh, ten_tinh, loai, gia);
                return this.fLocation.deleteLocation(phuongtien.ID);

            }
            catch (Exception ex)
            {
                return false;
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
        public bool testCheckLocationInput(string name, byte[] img_data, string so_tinh)
        {
            try
            {
                bool check = this.fLocation.CheckData(name, img_data, so_tinh);
                return check;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}
