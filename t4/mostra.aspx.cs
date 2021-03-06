using CapasTarea4;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace t4
{
    public partial class mostra : System.Web.UI.Page
    {


        public const string url_Producto = "http://localhost/ApiTarea4/api/producto";

        datos Datos = new datos();

        protected void Page_Load(object sender, EventArgs e)
        {
                    List<Base> prueba = Datos.Mostrar();
                    GridView1.DataSource = prueba;
                    GridView1.DataBind();
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Menu.aspx");
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            TableCell cell = GridView1.Rows[e.RowIndex].Cells[1];
            string cod = cell.Text;
            Datos.Eliminar(cod);
            Response.Redirect("~/mostra.aspx");
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codigo = GridView1.SelectedRow.Cells[1].Text;
            string nombre = GridView1.SelectedRow.Cells[2].Text;
            string cantidad = GridView1.SelectedRow.Cells[3].Text;
            string bodega = GridView1.SelectedRow.Cells[4].Text;
            Response.Redirect("~/Modificar.aspx"+"?"+"codigo="+codigo+"&" + "nombre=" + nombre + "&" + "cantidad=" + cantidad + "&" + "bodega=" + bodega);
        }
    }
}