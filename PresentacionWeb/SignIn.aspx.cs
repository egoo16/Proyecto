using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace PresentacionWeb
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.Cookies["UNAME"]!=null && Request.Cookies["PWD"]!=null)
                {
                    UserName.Text = Request.Cookies["UNAME"].Value;
                    Pass.Attributes["value"] = Request.Cookies["PWD"].Value;
                    CheckBox1.Checked = true;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            String cs = ConfigurationManager.ConnectionStrings["MySQL"].ConnectionString;
            using (MySqlConnection con = new MySqlConnection(cs))
            {
                MySqlCommand cmd = new MySqlCommand("Login", con);
                con.Open(); 
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("PC_NOMUSUARIO", UserName.Text);
                cmd.Parameters.AddWithValue("PC_PASSWORD", Pass.Text);
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                if (dt.Rows.Count != 0)
                {
                    if (CheckBox1.Checked)
                    {
                        Response.Cookies["UNAME"].Value = UserName.Text;
                        Response.Cookies["PWD"].Value = Pass.Text;

                        Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(15);
                        Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(15);
                    }
                    else
                    {
                        Response.Cookies["UNAME"].Expires = DateTime.Now.AddDays(-1);
                        Response.Cookies["PWD"].Expires = DateTime.Now.AddDays(-1);
                    }

                    Session["USERNAME"] = UserName.Text;
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    Label4.Text = "Nombre o Contraseña inválidos";
                }
            }
        }
    }
}