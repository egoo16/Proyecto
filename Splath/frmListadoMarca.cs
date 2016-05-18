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
    public partial class frmListadoMarca : Form
    {
        N_Marca lnobj = new N_Marca(ConfigurationManager.ConnectionStrings["Oracle"].ConnectionString);
        public static DataRow row;
        public static frmListadoMarca list;
        int codigo;
        public frmListadoMarca()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            frmMarca frm = new frmMarca();
            frm.transaccion = true;
            frm.ShowDialog();
            CargarMarca();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmListadoMarca_Load(object sender, EventArgs e)
        {
            CargarMarca();
        }

        public void CargarMarca()
        {
            gridControl1.DataSource = lnobj.ConsultarMarca();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            frmMarca frm = new frmMarca();
            frm.transaccion = false;
            frm.ShowDialog();
            CargarMarca();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            row = gridView1.GetDataRow(gridView1.GetSelectedRows()[0]);
            codigo = Convert.ToInt16(row[0]);
            DialogResult result = MessageBox.Show("¿Desea eliminar este registro?", "Eliminar Mara", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                lnobj.EliminarMarca(codigo);
                MessageBox.Show("La Marca se eliminó correctamente", "Marca", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            CargarMarca();
        }

    }
}
