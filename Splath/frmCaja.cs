using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splath
{
    public partial class frmCaja : Form
    {
        public bool apertura = false;
        public frmCaja()
        {
            InitializeComponent();
        }

        private void aperturaDeCajaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CajaApertura frm = new CajaApertura();
            frm.ShowDialog();

        }

        private void frmCaja_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }
    }
}
