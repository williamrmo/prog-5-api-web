using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ApiTarea4.Models;

namespace ApiTarea4.Controllers
{
    public class productoController : ApiController
    {
        private DB_Tarea3_PVEntities db = new DB_Tarea3_PVEntities();

        // GET: api/productoes
        public IQueryable<producto> Getproductos()
        {
            return db.productos;
        }

        // GET: api/productoes/5
        [ResponseType(typeof(producto))]
        public IHttpActionResult Getproducto(string id)
        {
            producto producto = db.productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            return Ok(producto);
        }

        // PUT: api/productoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putproducto(string id, producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != producto.Codigo_producto)
            {
                return BadRequest();
            }

            db.Entry(producto).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!productoExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/productoes
        [ResponseType(typeof(producto))]
        public IHttpActionResult Postproducto(producto producto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.productos.Add(producto);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (productoExists(producto.Codigo_producto))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = producto.Codigo_producto }, producto);
        }

        // DELETE: api/productoes/5
        [ResponseType(typeof(producto))]
        public IHttpActionResult Deleteproducto(string id)
        {
            producto producto = db.productos.Find(id);
            if (producto == null)
            {
                return NotFound();
            }

            db.productos.Remove(producto);
            db.SaveChanges();

            return Ok(producto);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool productoExists(string id)
        {
            return db.productos.Count(e => e.Codigo_producto == id) > 0;
        }
    }
}