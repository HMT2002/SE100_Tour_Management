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
                System.Windows.Forms.TextBox txtbx = (System.Windows.Forms.TextBox)sender;


                txtbx.BackColor = Color.FromArgb(255, 153, 153);
            }
            catch
            {

            }


        }

        public static void UnnotificationField(object sender)
        {
            try
            {
                System.Windows.Forms.TextBox txtbx = (System.Windows.Forms.TextBox)sender;

                txtbx.BackColor = Color.White;
            }
            catch
            {

            }
        }

        public static void NotificationSelect(object sender)
        {
            try
            {
                System.Windows.Forms.ComboBox txtbx = (System.Windows.Forms.ComboBox)sender;

                txtbx.BackColor = Color.FromArgb(254, 184, 177);
            }
            catch
            {

            }
        }

        public static void UnnotificationSelect(object sender)
        {
            try
            {
                System.Windows.Forms.ComboBox txtbx = (System.Windows.Forms.ComboBox)sender;

                txtbx.BackColor = Color.White;

            }
            catch
            {

            }
        }

        public static void NotificationSelectDateTime(object sender)
        {
            try
            {
                System.Windows.Forms.DateTimePicker picker = (System.Windows.Forms.DateTimePicker)sender;


            }
            catch
            {

            }
        }

        public static void UnnotificationSelectDateTime(object sender)
        {
            try
            {
                System.Windows.Forms.DateTimePicker picker = (System.Windows.Forms.DateTimePicker)sender;


            }
            catch
            {

            }
        }
    }
}
