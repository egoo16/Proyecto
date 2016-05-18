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
    public partial class frmPresentacion : Form
    {
        public bool transaccion = false;
        N_Presentacion lnobj = new N_Presentacion(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        int codigo;
        public frmPresentacion()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPresentacion_Load(object sender, EventArgs e)
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
                codigo = Convert.ToInt16(frmListadoPresentacion.row[0]);
                txtNombre.Text = frmListadoPresentacion.row[1].ToString();
                txtDescripcion.Text = frmListadoPresentacion.row[2].ToString();
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, descripcion;
            //Validar todos los datos de entrada
            nombre = txtNombre.Text;
            descripcion = txtDescripcion.Text;

            if (transaccion)
            {
                //nueva Presentacoin
                lnobj.InsertarPres(nombre, descripcion);
            }
            else
            {
                //modificacion de Presentacion
                lnobj.ActualizarPres(codigo, nombre, descripcion);
            }
            MessageBox.Show("La Presentacion se inserto correctamente", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
