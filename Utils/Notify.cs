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

        public static void Notification(object sender)
        {
            try
            {
                if(sender is System.Windows.Forms.TextBox)
                {
                    var obj=(System.Windows.Forms.TextBox)sender;
                    obj.BackColor = Color.FromArgb(255, 153, 153);

                }
                else if(sender is System.Windows.Forms.ComboBox)
                {
                    var obj= (System.Windows.Forms.ComboBox)sender;
                    obj.BackColor = Color.FromArgb(255, 153, 153);

                }
                else if (sender is System.Windows.Forms.PictureBox)
                {
                    var obj = (System.Windows.Forms.PictureBox)sender;
                    obj.BackColor = Color.FromArgb(255, 153, 153);

                }
                else if (sender is System.Windows.Forms.Panel)
                {
                    var obj = (System.Windows.Forms.Panel)sender;
                    obj.BackColor = Color.FromArgb(255, 153, 153);

                }
                else if (sender is System.Windows.Forms.Button)
                {
                    var obj = (System.Windows.Forms.Button)sender;
                    obj.BackColor = Color.FromArgb(255, 153, 153);

                }
                else
                {

                }
            }
            catch(Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.ToString());

            }
        }

        public static void Unnotification(object sender)
        {
            try
            {
                if (sender is System.Windows.Forms.TextBox)
                {
                    var obj = (System.Windows.Forms.TextBox)sender;
                    obj.BackColor = Color.White;

                }
                else if (sender is System.Windows.Forms.ComboBox)
                {
                    var obj = (System.Windows.Forms.ComboBox)sender;
                    obj.BackColor = Color.White;

                }
                else if (sender is System.Windows.Forms.PictureBox)
                {
                    var obj = (System.Windows.Forms.PictureBox)sender;
                    obj.BackColor = Color.White;

                }
                else if (sender is System.Windows.Forms.Panel)
                {
                    var obj = (System.Windows.Forms.Panel)sender;
                    obj.BackColor = Color.White;

                }
                else if (sender is System.Windows.Forms.Button)
                {
                    var obj = (System.Windows.Forms.Button)sender;
                    obj.BackColor = Color.White;

                }
                else if (sender is System.Windows.Forms.DateTimePicker)
                {
                    var obj = (System.Windows.Forms.DateTimePicker)sender;
                    obj.BackColor = Color.White;

                }
                else
                {

                }
            }
            catch (Exception ex)
            {

                System.Diagnostics.Debug.WriteLine(ex.ToString());

            }
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
