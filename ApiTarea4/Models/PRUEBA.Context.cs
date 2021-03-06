//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ApiTarea4.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_Tarea3_PVEntities : DbContext
    {
        public DB_Tarea3_PVEntities()
            : base("name=DB_Tarea3_PVEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<producto> productos { get; set; }
        public virtual DbSet<usuario> usuarios { get; set; }
    
        public virtual int eliminar_producto(string codigo_producto)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("eliminar_producto", codigo_productoParameter);
        }
    
        public virtual ObjectResult<login_Result> login(string iD_Usuario, string pass)
        {
            var iD_UsuarioParameter = iD_Usuario != null ?
                new ObjectParameter("ID_Usuario", iD_Usuario) :
                new ObjectParameter("ID_Usuario", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<login_Result>("login", iD_UsuarioParameter, passParameter);
        }
    
        public virtual int moBodega(string codigo_producto, string dato)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var datoParameter = dato != null ?
                new ObjectParameter("Dato", dato) :
                new ObjectParameter("Dato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("moBodega", codigo_productoParameter, datoParameter);
        }
    
        public virtual int moCantida(string codigo_producto, Nullable<int> dato)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var datoParameter = dato.HasValue ?
                new ObjectParameter("Dato", dato) :
                new ObjectParameter("Dato", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("moCantida", codigo_productoParameter, datoParameter);
        }
    
        public virtual int modificar_producto(string codigo_producto, string nombre, Nullable<int> cantidad, string bodega)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var bodegaParameter = bodega != null ?
                new ObjectParameter("Bodega", bodega) :
                new ObjectParameter("Bodega", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("modificar_producto", codigo_productoParameter, nombreParameter, cantidadParameter, bodegaParameter);
        }
    
        public virtual int modiprod(string codigo_producto, string columna, string dato)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var columnaParameter = columna != null ?
                new ObjectParameter("Columna", columna) :
                new ObjectParameter("Columna", typeof(string));
    
            var datoParameter = dato != null ?
                new ObjectParameter("Dato", dato) :
                new ObjectParameter("Dato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("modiprod", codigo_productoParameter, columnaParameter, datoParameter);
        }
    
        public virtual int monombre(string codigo_producto, string dato)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var datoParameter = dato != null ?
                new ObjectParameter("Dato", dato) :
                new ObjectParameter("Dato", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("monombre", codigo_productoParameter, datoParameter);
        }
    
        public virtual ObjectResult<mostrar_producto_Result> mostrar_producto(string codigo_producto)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mostrar_producto_Result>("mostrar_producto", codigo_productoParameter);
        }
    
        public virtual ObjectResult<mostrar_todos_productos_Result> mostrar_todos_productos()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mostrar_todos_productos_Result>("mostrar_todos_productos");
        }
    
        public virtual ObjectResult<mostrar_todos_usuarios_Result> mostrar_todos_usuarios()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mostrar_todos_usuarios_Result>("mostrar_todos_usuarios");
        }
    
        public virtual ObjectResult<mostrar_usuario_Result> mostrar_usuario(string iD_Usuario)
        {
            var iD_UsuarioParameter = iD_Usuario != null ?
                new ObjectParameter("ID_Usuario", iD_Usuario) :
                new ObjectParameter("ID_Usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mostrar_usuario_Result>("mostrar_usuario", iD_UsuarioParameter);
        }
    
        public virtual int nuevo_producto(string codigo_producto, string nombre, Nullable<int> cantidad, string bodega)
        {
            var codigo_productoParameter = codigo_producto != null ?
                new ObjectParameter("Codigo_producto", codigo_producto) :
                new ObjectParameter("Codigo_producto", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var cantidadParameter = cantidad.HasValue ?
                new ObjectParameter("Cantidad", cantidad) :
                new ObjectParameter("Cantidad", typeof(int));
    
            var bodegaParameter = bodega != null ?
                new ObjectParameter("Bodega", bodega) :
                new ObjectParameter("Bodega", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("nuevo_producto", codigo_productoParameter, nombreParameter, cantidadParameter, bodegaParameter);
        }
    
        public virtual int nuevo_usuario(string iD_Usuario, string nombre, string apeliido, string password)
        {
            var iD_UsuarioParameter = iD_Usuario != null ?
                new ObjectParameter("ID_Usuario", iD_Usuario) :
                new ObjectParameter("ID_Usuario", typeof(string));
    
            var nombreParameter = nombre != null ?
                new ObjectParameter("Nombre", nombre) :
                new ObjectParameter("Nombre", typeof(string));
    
            var apeliidoParameter = apeliido != null ?
                new ObjectParameter("Apeliido", apeliido) :
                new ObjectParameter("Apeliido", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("Password", password) :
                new ObjectParameter("Password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("nuevo_usuario", iD_UsuarioParameter, nombreParameter, apeliidoParameter, passwordParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual ObjectResult<mostrar_usuarios_Result> mostrar_usuarios(string iD_Usuario)
        {
            var iD_UsuarioParameter = iD_Usuario != null ?
                new ObjectParameter("ID_Usuario", iD_Usuario) :
                new ObjectParameter("ID_Usuario", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<mostrar_usuarios_Result>("mostrar_usuarios", iD_UsuarioParameter);
        }
    }
}
