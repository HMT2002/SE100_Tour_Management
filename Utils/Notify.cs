using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tour.Utils
{
    public class Notify
    {

        private static Notify instance;

        public static Notify Instance
        {
            get { if (instance == null) instance = new Notify(); return Notify.instance; }
            private set { Notify.instance = value; }
        }
        private Notify()
        {

        }


        public static void NotificationField(object sender)
        {
            try
            {
                Guna.UI2.WinForms.Guna2TextBox txtbx = (Guna.UI2.WinForms.Guna2TextBox)sender;


                txtbx.FillColor = Color.FromArgb(255, 153, 153);
            }
            catch
            {

            }


        }

        public static void UnnotificationField(object sender)
        {
            try
            {
                Guna.UI2.WinForms.Guna2TextBox txtbx = (Guna.UI2.WinForms.Guna2TextBox)sender;

                txtbx.FillColor = Color.White;
            }
            catch
            {

            }
        }

        public static void NotificationSelect(object sender)
        {
            try
            {
                Guna.UI2.WinForms.Guna2ComboBox txtbx = (Guna.UI2.WinForms.Guna2ComboBox)sender;

                txtbx.FillColor = Color.FromArgb(254, 184, 177);
            }
            catch
            {

            }
        }

        public static void UnnotificationSelect(object sender)
        {
            try
            {
                Guna.UI2.WinForms.Guna2ComboBox txtbx = (Guna.UI2.WinForms.Guna2ComboBox)sender;

                txtbx.FillColor = Color.White;

            }
            catch
            {

            }
        }
    }
}
