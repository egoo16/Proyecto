using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Splath
{
    public partial class frmprincipal : Form
    {
        public frmprincipal()
        {
            InitializeComponent();

        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {
            
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListadoProducto frm = new  frmListadoProducto();
            frm.MdiParent = this;
            frm.Show();
            btncc.Visible = true;
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListadoMarca frm = new frmListadoMarca();
            frm.MdiParent = this;
            frm.Show();
            btncc.Visible = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListadoCategoría frm = new frmListadoCategoría();
            frm.MdiParent = this;
            frm.Show();
            btncc.Visible = true;
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListadoPresentacion frm = new frmListadoPresentacion();
            frm.MdiParent = this;
            frm.Show();
            btncc.Visible = true;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
           
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmListadoProveedor frm = new frmListadoProveedor();
            frm.MdiParent = this;
            frm.Show();
            btncc.Visible = true;
        }
    }
}
