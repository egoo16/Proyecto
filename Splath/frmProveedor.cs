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
    public partial class frmProveedor : Form
    {
        public bool transaccion = false;
        N_Proveedor lnobj = new N_Proveedor(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        int codigo;

        public frmProveedor()
        {
            InitializeComponent();
        }

        private void textEdit4_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void frmProveedor_Load(object sender, EventArgs e)
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
                codigo = Convert.ToInt16(frmListadoProveedor.row[0]);
                txtNombre.Text = frmListadoProveedor.row[1].ToString();
                txtDireccion.Text = frmListadoProveedor.row[2].ToString();
                txtTelefono.Text = frmListadoProveedor.row[3].ToString();
                txtCorreo.Text = frmListadoProveedor.row[4].ToString();
                txtFecha.Text = frmListadoProveedor.row[5].ToString();
            }
        }

        private void textEdit5_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtDireccion_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            string nombre, direccion, telefono, correo, fecha;
            //Validar todos los datos de entrada
            nombre = txtNombre.Text;
            direccion = txtDireccion.Text;
            telefono = txtTelefono.Text;
            correo = txtCorreo.Text;
            fecha = txtFecha.Text;

            if (transaccion)
            {
                //nuevo Proveedor
                lnobj.insertarProveedor(nombre, direccion, telefono, correo, fecha);
            }
            else
            {
                //modificacion de proveedor
                lnobj.ActualizarProveedor(codigo, nombre, direccion, telefono, correo, fecha);
            }
            MessageBox.Show("El Proveedor se inserto correctamente", "Proveedor", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}
