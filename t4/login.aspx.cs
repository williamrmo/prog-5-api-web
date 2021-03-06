using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CapasTarea4;

namespace t4
{
    public partial class login : System.Web.UI.Page
    {
        Reglas r = new Reglas();
        datos d = new datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbError.Visible = false;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrarse.aspx");
        }

        protected void BTNLOGIN_Click(object sender, EventArgs e)
        {
            string nick = TXTNick.Text;
            string pass = TXTPass.Text;


            string cod=  r.Codificar(pass);
            bool a = true;
            if (d.ValidarUsuario(nick, cod))
            {
                Session["Usuario"] = a;
                Response.Redirect("~/Menu.aspx");
            }
            else
            {
                //string respuesta5 = "contraseña o usuario incorrecto";
                //this.Page.Response.Write("<script language='JavaScript'>window.alert('" + respuesta5 + "');</script>");
                lbError.Visible = true;
            }
            //  List<Usuario> us= d.login(nick);



            //  foreach (Usuario usur in us)
            //  {



            //  }
            //if(  us.Contains(new Usuario { id = nick, pass =cod })){
            //      Response.Redirect("~/Menu.aspx");

            //  }



        }

        protected void volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Registrarse.aspx");
        }
    }
}