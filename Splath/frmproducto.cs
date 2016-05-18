using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BLL;


namespace Splath
{
    public partial class frmproducto : Form
    {
        public bool transaccion = false;
        N_Categoria ccat = new N_Categoria(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        N_Marca cmar = new N_Marca(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        N_Producto CPRO = new N_Producto(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        int codigo;
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
            frm.transaccion = true;
            frm.ShowDialog();
        }

        private void aMar_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.transaccion = true;
            frm.ShowDialog();
        }

        private void frmproducto_Load(object sender, EventArgs e)
        {
            //CATEGORIA
            comboBox1.DataSource = ccat.consultarCategoria();
            comboBox1.DisplayMember = "NOMBRE";
            comboBox1.ValueMember = "IDCATEGORIA";
            //MARCA
            comboBox2.DataSource = cmar.ConsultarMarca();
            comboBox2.DisplayMember = "NOMBRE";
            comboBox2.ValueMember = "IDMARCA";

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
                codigo = Convert.ToInt16(frmListadoProducto.row[0]);
                comboBox1.SelectedValue = frmListadoProducto.row[1];
                comboBox2.SelectedValue = frmListadoProducto.row[2];
                txtNombre.Text = frmListadoProducto.row[3].ToString();
                txtDescripcion.Text = frmListadoProducto.row[4].ToString();
            }


        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int idcat, idmar;
            string nombre, descripcion,estado;
            //Validar todos los datos de entrada
            idcat = Convert.ToInt16(comboBox1.SelectedValue);
            idmar = Convert.ToInt16(comboBox2.SelectedValue);
            nombre = txtNombre.Text;
            descripcion = txtDescripcion.Text;
            estado = "1";

            if (transaccion)
            {
                //nuevo Proveedor
                CPRO.insertarProducto(idcat, idmar, nombre, descripcion,estado);
            }
            else
            {
                //modificacion de proveedor
                CPRO.ActualizarProducto(codigo, idcat,idmar, nombre, descripcion,estado);
            }
            MessageBox.Show("La Categoria se inserto correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        
        }

       
    }
}
