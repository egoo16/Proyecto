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
    public partial class frmproducto : Form
    {
        public bool transaccion = false;
        public frmproducto()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();this.Close();
        }

        private void aCat_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            //frm.transaccion = true;
            frm.ShowDialog();
        }

        private void aMar_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            //frm.transaccion = true;
            frm.ShowDialog();
        }

        private void frmproducto_Load(object sender, EventArgs e)
        {

        }
    }
}
