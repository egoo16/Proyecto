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
    public partial class Splath : Form
    {
        public Splath()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Increment(1);
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                frmMenuPrincipal frm = new frmMenuPrincipal();
                frm.Show();
                this.Hide();
            }
        }

        private void Splath_Load(object sender, EventArgs e)
        {

        }
    }
}
