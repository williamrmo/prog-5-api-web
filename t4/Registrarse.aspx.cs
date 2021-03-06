using CapasTarea4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class Registrarse : System.Web.UI.Page
    {
        datos da = new datos();
        Reglas r = new Reglas();
      
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNAutogenerar_Click(object sender, EventArgs e)
        {
            string n = TXTNOMBRE.Text;
            string a = TXTAPELLIDOS.Text;
            TXTPass.Text = r.Contraseña(n, a);
        }

        protected void BTNRegistrarse_Click(object sender, EventArgs e)
        {
            string nom = TXTNOMBRE.Text;
            string ap = TXTAPELLIDOS.Text;
            string n = TXTNick.Text;
            string p = TXTPass.Text;

            string codificado= r.Codificar(p);

            Usuario b = new Usuario() {
                id = n,
                Nombre = nom,
                apellido = ap,
                pass = codificado
            
            };

            da.AgregarUsuario(b);
            Response.Redirect("~/Menu.aspx");
            bool a = true;
            Session["Usuario"] = a;
        }

        protected void BTNVolver_Click(object sender, EventArgs e)
        {

        }
    }
}