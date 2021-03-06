using CapasTarea4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class Modificar : System.Web.UI.Page
    {
        datos da = new datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (TXTCOD.Text.Equals(""))
            {
                string paramIl = HttpUtility.ParseQueryString(this.ClientQueryString).Get("codigo");
                string paramI2 = HttpUtility.ParseQueryString(this.ClientQueryString).Get("nombre");
                string paramI3 = HttpUtility.ParseQueryString(this.ClientQueryString).Get("cantidad");
                string paramI4 = HttpUtility.ParseQueryString(this.ClientQueryString).Get("bodega");
                TXTCOD.Text = paramIl.ToString();
                TXTnombre.Text = paramI2.ToString();
                TXTCantidad.Text = paramI3.ToString();
                TXTbodega.Text = paramI4.ToString();
            }
            
            TXTCOD.Enabled = false;
        }

            protected void Btnmodificar_Click(object sender, EventArgs e)
        {

            string cod = TXTCOD.Text;
            string nom = TXTnombre.Text;
            string cant = TXTCantidad.Text;
            string bod = TXTbodega.Text;

            int ca = int.Parse(cant);

            Base b = new Base() { 
            codigo_producto=cod,
            Nombre=nom,
            cantidad=ca,
            bodega=bod
            
            };
            da.Modificar(cod,b);
            Response.Redirect("~/mostra.aspx");
        }

        protected void Btnvolver_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mostra.aspx");
        }
    }
}