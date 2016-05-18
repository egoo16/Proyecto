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
    public partial class frmListadoProveedor : Form
    {
        N_Proveedor lnobj = new N_Proveedor(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        public static DataRow row;
        public static frmListadoProveedor list;
        int codigo;

        public frmListadoProveedor()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmProveedor frm = new frmProveedor();
            frm.transaccion = true;
            frm.ShowDialog();
            cargarDatosProveedor();
        }

        public void cargarDatosProveedor()
        {
            gridControl1.DataSource = lnobj.consultarProveedor();
        }

        private void frmListadoProveedor_Load(object sender, EventArgs e)
        {
            cargarDatosProveedor();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmProveedor frm = new frmProveedor();
            frm.transaccion = false;
            frm.ShowDialog();
            cargarDatosProveedor();
        }
    }
}
