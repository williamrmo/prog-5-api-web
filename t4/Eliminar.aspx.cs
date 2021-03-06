using CapasTarea4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class Eliminar : System.Web.UI.Page
    {
        datos da = new datos();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnEliminar_Click(object sender, EventArgs e)
        {
            string cod = Txtcod.Text;
            da.Eliminar(cod);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }
    }
}