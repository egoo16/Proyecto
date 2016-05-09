﻿using System;
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
                codigo = Convert.ToInt16(frmListadoCategoría.row[0]);
                txtNombre.Text = frmListadoCategoría.row[1].ToString();
                textEdit1.Text = frmListadoCategoría.row[2].ToString();
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

        }
    }
}
