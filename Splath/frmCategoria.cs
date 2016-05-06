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
    public partial class frmCategoria : Form
    {
        public bool transaccion = false;
        N_Categoria lnobj = new N_Categoria(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        int codigo;

        public frmCategoria()
        {
            InitializeComponent();
        }

        private void frmCategoria_Load(object sender, EventArgs e)
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
                codigo = Convert.ToInt16(frmListadoCategoría.row[0]);
                txtNombre.Text = frmListadoCategoría.row[1].ToString();
                textEdit1.Text = frmListadoCategoría.row[2].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
                //Validar todos los datos de entrada
                nombre = txtNombre.Text;
                descripcion = textEdit1.Text;

                if (transaccion)
                {
                    //nuevo Proveedor
                    lnobj.insertarCategoria(nombre, descripcion);
                }
                else
                {
                    //modificacion de proveedor
                    lnobj.ActualizarCategoria(codigo, nombre, descripcion);
                }
                MessageBox.Show("La Categoria se inserto correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
        }
    }
}
