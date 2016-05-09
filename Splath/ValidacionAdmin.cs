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
    public partial class ValidacionAdmin : Form
    {
        public ValidacionAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //En esta parte va un if para la validacion de los datos
            frmCaja frm = new frmCaja();
            CajaApertura ap = new CajaApertura();
            ap.cerrar = true;
            ap.Refresh();
            frm.apertura = true;
            this.Close();
        }
    }
}
