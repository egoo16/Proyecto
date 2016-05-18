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
    public partial class frmListadoPresentacion : Form
    {
        N_Presentacion lnobj = new N_Presentacion(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        public static DataRow row;
        public static frmListadoPresentacion list;
        int codigo;

        public frmListadoPresentacion()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoPresentacion_Load(object sender, EventArgs e)
        {
            cargarPres();
        }

        public void cargarPres()
        {
            gridControl1.DataSource = lnobj.ConsultarPresentacion();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmPresentacion frm = new frmPresentacion();
            frm.transaccion = true;
            frm.ShowDialog();
            cargarPres();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            codigo = Convert.ToInt16(row[0]);
            DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Presentacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lnobj.EliminarPres(codigo);
                MessageBox.Show("La Presentacion se eliminó correctamente", "Presentacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            cargarPres();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmPresentacion frm = new frmPresentacion();
            frm.transaccion = false;
            frm.ShowDialog();
            cargarPres();
        }
    }
}
