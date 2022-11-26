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

namespace Tour
{
    public partial class fPrint : Form
    {
        public VE Ve = new VE();

        public fPrint()
        {
            InitializeComponent();
        }

        public fPrint(VE ve)
        {
            InitializeComponent();

        }

        public fPrint(TOUR tour)
        {
            InitializeComponent();

        }

    }
}
