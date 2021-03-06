using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class Menu : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BTNAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/AgrgarProducto.aspx");
        }

        protected void BTNMostrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/mostra.aspx");
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Modificar.aspx");
        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Eliminar.aspx");
        }

        protected void BTNCerrar_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/login.aspx");
        }
    }
}