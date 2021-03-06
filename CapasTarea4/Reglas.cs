using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapasTarea4
{
   public class Reglas
    {
        public string Contraseña(string nombre, string apellido)
        {
            string nueva;
            nueva = nombre.Substring(0, 4);
            nueva = nueva + apellido.Substring(0, 4);
            return nueva;
        }

        public string Codificar(string pass)
        {

            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(pass);
            result = Convert.ToBase64String(encryted);
            return result;


        }
    }
}
