using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CapasTarea4
{
    public class datos
    {

        private const string url_cliente = "http://localhost/ApiTarea4/api/usuarios";
        private const string url_Producto = "http://localhost/ApiTarea4/api/producto";
        private List<Base> Prueba { get; set; }
        private List<Usuario> us { get; set; }
        public List<Base> Mostrar()
        {
            IEnumerable<Base> A;
            using (var client = new HttpClient())
            {
                var task = Task.Run(async () =>
                {
                    return await client.GetAsync(url_Producto);
                }

                );
                HttpResponseMessage message = task.Result;
                if (message.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultstr = task2.Result;
                    Prueba = JsonConvert.DeserializeObject<List<Base>>(resultstr);

                }

            }
            return Prueba;


        }
        public void Agregar(Base B)
        {

            string json = B.tojson();
            using (var client = new HttpClient())
            {

                var task = Task.Run(async () =>
                {
                    return await client.PostAsync(url_Producto,
                        new StringContent(json, Encoding.UTF8, "application/json"));
                }

                );
                HttpResponseMessage message = task.Result;
                if (message.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultstr = task2.Result;
                    Base result = JsonConvert.DeserializeObject<Base>(resultstr);
                    Console.WriteLine("Cliente {0} creado con el codigo {1}", result.Nombre, result.bodega);
                }
                else
                {
                    Console.WriteLine("error intente mas tarde");
                }
            }
        }
        public void Eliminar(string cod)
        {
            Base b = new Base();
            b.codigo_producto = cod;
            string json = JsonConvert.SerializeObject(cod, Formatting.None);

            using (var client = new HttpClient())
            {

                var task = Task.Run(async () =>
                {
                    return await client.DeleteAsync(url_Producto + "/" + cod);
                }

                );
                HttpResponseMessage message = task.Result;
                if (message.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultstr = task2.Result;
                    Base result = JsonConvert.DeserializeObject<Base>(resultstr);
                    Console.WriteLine("Cliente {0} eliminado con el codigo {1}", result.Nombre, result.bodega);
                }
                else
                {
                    Console.WriteLine("error intente mas tarde");
                }
            }

        }
        public void Modificar(string cod, Base b)
        {
            string json = b.tojson();
            using (var client = new HttpClient())
            {

                var task = Task.Run(async () =>
                {
                    return await client.PutAsync(url_Producto + "/" + cod,
                        new StringContent(json, Encoding.UTF8, "application/json"));
                }

                );
                HttpResponseMessage message = task.Result;
                if (message.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultstr = task2.Result;
                    Base result = JsonConvert.DeserializeObject<Base>(resultstr);
                    Console.WriteLine("Cliente {0} creado con el codigo {1}", result.Nombre, result.bodega);
                }
                else
                {
                    Console.WriteLine("error intente mas tarde");
                }
            }
        }
        public void AgregarUsuario(Usuario u)
        {

            string json = u.tojson();
            using (var client = new HttpClient())
            {

                var task = Task.Run(async () =>
                {
                    return await client.PostAsync(url_cliente,
                        new StringContent(json, Encoding.UTF8, "application/json"));
                }

                );
                HttpResponseMessage message = task.Result;
                if (message.StatusCode == System.Net.HttpStatusCode.Created)
                {
                    var task2 = Task<string>.Run(async () =>
                    {
                        return await message.Content.ReadAsStringAsync();
                    });
                    string resultstr = task2.Result;
                    Base result = JsonConvert.DeserializeObject<Base>(resultstr);
                    Console.WriteLine("Cliente {0} creado con el codigo {1}", result.Nombre, result.bodega);
                }
                else
                {
                    Console.WriteLine("error intente mas tarde");
                }
            }
        }

        public bool ValidarUsuario(string id, string pass)
        {using (var client = new HttpClient())
            {try
                {bool valid = false;
                    var task = Task.Run(async () =>
                    {return await client.GetAsync(String.Concat(url_cliente, "/", id));
                    });
                    HttpResponseMessage message = task.Result;
                    if (message.StatusCode == System.Net.HttpStatusCode.OK)
                    {var task2 = Task<string>.Run(async () =>
                    {   
                    return await message.Content.ReadAsStringAsync();
                     });
                     string resultstr = task2.Result;
                        Usuario u = JsonConvert.DeserializeObject<Usuario>(resultstr);
                        if (u.pass.ToString() == pass) { valid = true; }



//User = JsonConvert.DeserializeObject<List<Usuario>>(resultstr);
                    }
                return valid;
                    }
                catch { return false; }


            }
        }
    }
}



        //public List<Usuario> login(string nick) {

        //    IEnumerable<Usuario> A;
        //    using (var client = new HttpClient())
        //    {
        //        var task = Task.Run(async () =>
        //        {
        //            return await client.GetAsync(url_cliente, );
        //        }

        //        );
        //        HttpResponseMessage message = task.Result;
        //        if (message.StatusCode == System.Net.HttpStatusCode.OK)
        //        {
        //            var task2 = Task<string>.Run(async () =>
        //            {
        //                return await message.Content.ReadAsStringAsync();
        //            });
        //            string resultstr = task2.Result;
        //            us = JsonConvert.DeserializeObject<List<Usuario>>(resultstr);

        //        }

        //    }
        //    return us;
        //}
    



