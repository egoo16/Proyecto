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
    public partial class frmListadoProducto : Form
    {
        N_Producto lnobj = new N_Producto(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        public static DataRow row;
        public static frmListadoProducto list;
        int codigo;
        public frmListadoProducto()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmproducto frm = new frmproducto();
            frm.transaccion = true;
            frm.ShowDialog();
            CargarProducto();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoProducto_Load(object sender, EventArgs e)
        {
            CargarProducto();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        public void CargarProducto()
        {
            gridControl1.DataSource = lnobj.consultarProducto();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmproducto frm = new frmproducto();
            frm.transaccion = false;
            frm.ShowDialog();
            CargarProducto();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            codigo = Convert.ToInt16(row[0]);
            DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lnobj.EliminarProducto(codigo);
                MessageBox.Show("La categoria se eliminó correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CargarProducto();
        }
    }
}
