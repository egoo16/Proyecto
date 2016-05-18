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
    public partial class frmListadoCategoría : Form
    {
        N_Categoria lnobj = new N_Categoria(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        public static DataRow row;
        public static frmListadoCategoría list;
        int codigo;

        public frmListadoCategoría()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmCategoria frm = new frmCategoria();
            frm.transaccion = true;
            frm.ShowDialog();
            cargarDatosCategoria();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoCategoría_Load(object sender, EventArgs e)
        {
            cargarDatosCategoria();
        }

        public void cargarDatosCategoria()
        {
            gridControl1.DataSource = lnobj.consultarCategoria();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            codigo = Convert.ToInt16(row[0]);
            DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Categoria", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lnobj.eliminarCategoria (codigo);
                MessageBox.Show("La categoria se eliminó correctamente", "Categoria", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargarDatosCategoria();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmCategoria frm = new frmCategoria();
            frm.transaccion = false;
            frm.ShowDialog();
            cargarDatosCategoria();
        }
    }
}
