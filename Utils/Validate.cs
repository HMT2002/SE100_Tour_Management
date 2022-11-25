﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tour.Utils
{
    public class Validate
    {

        private static Validate instance;

        public static Validate Instance
        {
            get { if (instance == null) instance = new Validate(); return Validate.instance; }
            private set { Validate.instance = value; }
        }
        private Validate()
        {

        }

        public static bool CapitalFlag = false;


        public static void CapitaLetter(object sender, KeyPressEventArgs e)
        {
            try
            {
                Guna.UI2.WinForms.Guna2TextBox txtbx = (Guna.UI2.WinForms.Guna2TextBox)sender;

                if (txtbx != null)
                {
                    if (CapitalFlag == true || txtbx.Text.Length == 0 || txtbx.Text[txtbx.Text.Length - 1] == (char)Keys.Space)
                    {
                        CapitalFlag = false;
                        e.KeyChar = char.ToUpper(e.KeyChar);
                    }
                    if (e.KeyChar == (char)Keys.Space)
                    {
                        CapitalFlag = true;
                    }

                }
            }
            catch
            {

            }
        }
    }
}
