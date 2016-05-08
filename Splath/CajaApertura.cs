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
    public partial class CajaApertura : Form
    {
        public CajaApertura()
        {
            InitializeComponent();
        }

        private void CajaApertura_Load(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Desea Gardar los cambios", "Apertura de Caja", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                frmCaja fr = new frmCaja();
                fr.apertura = true;
                this.Close();
            }
            
        }
    }
}
