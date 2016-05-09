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
        N_Proveedor lnobj = new N_Proveedor(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
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
            cargarDatosProveedor();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoCategoría_Load(object sender, EventArgs e)
        {
            cargarDatosProveedor();
        }

        public void cargarDatosProveedor()
        {
            gridControl1.DataSource = lnobj.consultarProveedor();
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmCategoria frm = new frmCategoria();
            frm.transaccion = false;
            frm.ShowDialog();
            cargarDatosProveedor();
        }
    }
}
