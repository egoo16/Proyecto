using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PresentacionWeb
{
    public partial class SignUp : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btAddUser_Click(object sender, EventArgs e)
        {
            
        }

        protected void btAddUser_Click1(object sender, EventArgs e)
        {
            if (tbUname.Text != null && tbPass.Text != null && tbName.Text != null && tbLName.Text != null && tbCPass.Text != null)
            {
                if (tbPass.Text == tbCPass.Text)
                {
                    String cs = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
                    using (SqlConnection con = new SqlConnection(cs))
                    {
                        SqlCommand cmd = new SqlCommand("insertarUsuario");
                        cmd.Parameters.AddWithValue("PC_NOMUSUARIO", tbUname.Text);
                        cmd.Parameters.AddWithValue("PC_PASSWORD", tbPass.Text);
                        cmd.Parameters.AddWithValue("PC_ESTADO", "1");
                        cmd.Connection = con;

                        SqlCommand cm = new SqlCommand("insertarCliente");
                        cm.Parameters.AddWithValue("PC_NOMBRE", tbName.Text);
                        cm.Parameters.AddWithValue("PC_APELLIDO", tbLName.Text);
                        cm.Parameters.AddWithValue("PC_DIRECCION", tbAddress.Text);
                        cm.Parameters.AddWithValue("PC_TELEFONO", tbPhone.Text);
                        cm.Parameters.AddWithValue("PC_NIT", tbNit.Text);
                        cm.Parameters.AddWithValue("PC_FECHAI", DateTime.Today);
                        if (tbMayorista.Text != "")
                        {
                            cm.Parameters.AddWithValue("PC_MAYORISTA", "1");
                            cm.Parameters.AddWithValue("PC_IDMAYORISTA", tbMayorista.Text);
                        }
                        else
                        {
                            cm.Parameters.AddWithValue("PC_MAYORISTA", "0");
                            cm.Parameters.AddWithValue("PC_IDMAYORISTA", null);
                        }

                        cm.Parameters.AddWithValue("PC_ESTADO", "1");
                        //cm.Connection = con;

                        con.Open();
                        cmd.ExecuteNonQuery();
                        cm.ExecuteNonQuery();
                        lblMsg.CssClass = "text-success";
                        lblMsg.Text = "Registro Exitoso";
                    }
                }
                else
                {
                    lblMsg.CssClass = "text-danger";
                    lblMsg.Text = "Las contraseñas no coinciden";
                }
            }
        }

    }
}