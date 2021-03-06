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
    public class usuariosController : ApiController
    {
        private DB_Tarea3_PVEntities db = new DB_Tarea3_PVEntities();

        // GET: api/usuarios
        public IQueryable<usuario> Getusuarios()
        {
            return db.usuarios;
        }

        // GET: api/usuarios/5
        [ResponseType(typeof(usuario))]
        public IHttpActionResult Getusuario(string id)
        {
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            return Ok(usuario);
        }

        // PUT: api/usuarios/5
        [ResponseType(typeof(void))]
        public IHttpActionResult Putusuario(string id, usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != usuario.ID_Usuario)
            {
                return BadRequest();
            }

            db.Entry(usuario).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!usuarioExists(id))
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

        // POST: api/usuarios
        [ResponseType(typeof(usuario))]
        public IHttpActionResult Postusuario(usuario usuario)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.usuarios.Add(usuario);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (usuarioExists(usuario.ID_Usuario))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = usuario.ID_Usuario }, usuario);
        }

        // DELETE: api/usuarios/5
        [ResponseType(typeof(usuario))]
        public IHttpActionResult Deleteusuario(string id)
        {
            usuario usuario = db.usuarios.Find(id);
            if (usuario == null)
            {
                return NotFound();
            }

            db.usuarios.Remove(usuario);
            db.SaveChanges();

            return Ok(usuario);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool usuarioExists(string id)
        {
            return db.usuarios.Count(e => e.ID_Usuario == id) > 0;
        }
    }
}