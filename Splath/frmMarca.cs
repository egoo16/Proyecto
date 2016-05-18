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
    public partial class frmMarca : Form
    {
        public bool transaccion = false;
        N_Marca lnobj = new N_Marca(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        int codigo;
        public frmMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            if (transaccion)
            {
                foreach (Control c in this.Controls)
                {
                    if (c.GetType() == typeof(TextBox))
                    {
                        ((TextBox)(c)).Text = string.Empty;
                    }
                }
            }
            else
            {
                codigo = Convert.ToInt16(frmListadoMarca.row[0]);
                txtNombre.Text = frmListadoMarca.row[1].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, estado;
            //Validar todos los datos de entrada
            nombre = txtNombre.Text;
            estado = "1";

            if (transaccion)
            {
                //nuevo Proveedor
                lnobj.InsertarMarca(nombre,estado);
            }
            else
            {
                //modificacion de proveedor
                lnobj.ActualizarMarca(codigo, nombre, estado);
            }
            MessageBox.Show("La Marca se inserto correctamente", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
