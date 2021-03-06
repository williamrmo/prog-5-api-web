using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasTarea4
{
   public class Base
    {
        [JsonProperty("Codigo_producto")]
        public string codigo_producto { get; set; }
        [JsonProperty("Nombre")]
        public string Nombre { get; set; }
        [JsonProperty("Cantidad")]
        public int cantidad { get; set; }
        [JsonProperty("Bodega")]
        public string bodega { get; set; }

        public string tojson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }

    public class Usuario
    {
        [JsonProperty("ID_Usuario")]
        public string id { get; set; }
        [JsonProperty("Nombre")]
        public string Nombre { get; set; }
        [JsonProperty("Apeliido")]
        public string apellido { get; set; }
        [JsonProperty("Password")]
        public string pass { get; set; }

        public string tojson()
        {
            return JsonConvert.SerializeObject(this, Formatting.None);
        }
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
