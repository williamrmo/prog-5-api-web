using CapasTarea4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class AgrgarProducto : System.Web.UI.Page
    {
        datos da = new  datos();
        protected void Page_Load(object sender, EventArgs e)
        {
            lbError.Visible = false;
            lbSuccess.Visible = false;

        }

        protected void BTNAgregar_Click(object sender, EventArgs e)
        {
            string cod = TXTCod.Text;
            string nombre = TXTNombre.Text;
            string catidad = TXTCantidad.Text;
            int c = int.Parse(catidad);
            string bodega = TXTBodega.Text;

            Base d  = new Base()
            {
                codigo_producto=cod,
                Nombre=nombre,
                cantidad=c,
                bodega=bodega
            };
            da.Agregar(d);
            lbSuccess.Visible = true;
            TXTCod.Text = "";
            TXTNombre.Text = "";
            TXTCantidad.Text = "0";
            TXTBodega.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }
    }
}