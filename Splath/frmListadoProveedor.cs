using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using System.Configuration;


namespace Splath
{
    public partial class frmListadoProveedor : Form
    {
        public frmListadoProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            //frm.transaccion = true;
            frm.ShowDialog();
        }

        private void frmListadoProveedor_Load(object sender, EventArgs e)
        {

        }
    }
}
