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
using HNM.WebService.Models;

namespace HNM.WebService.Controllers
{
    public class UtilisateursController : ApiController
    {
        private HomeNMoveContext db = new HomeNMoveContext();

        // GET: api/Utilisateurs
        public IQueryable<Utilisateur> GetUtilisateurs()
        {
            return db.Utilisateurs;
        }

        // GET: api/Utilisateurs/5
        [ResponseType(typeof(Utilisateur))]
        public IHttpActionResult GetUtilisateur(int id)
        {
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            return Ok(utilisateur);
        }

        // PUT: api/Utilisateurs/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutUtilisateur(int id, Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != utilisateur.IdUtilisateur)
            {
                return BadRequest();
            }

            db.Entry(utilisateur).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UtilisateurExists(id))
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

        // POST: api/Utilisateurs
        [ResponseType(typeof(Utilisateur))]
        public IHttpActionResult PostUtilisateur(Utilisateur utilisateur)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Utilisateurs.Add(utilisateur);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (UtilisateurExists(utilisateur.IdUtilisateur))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = utilisateur.IdUtilisateur }, utilisateur);
        }

        // DELETE: api/Utilisateurs/5
        [ResponseType(typeof(Utilisateur))]
        public IHttpActionResult DeleteUtilisateur(int id)
        {
            Utilisateur utilisateur = db.Utilisateurs.Find(id);
            if (utilisateur == null)
            {
                return NotFound();
            }

            db.Utilisateurs.Remove(utilisateur);
            db.SaveChanges();

            return Ok(utilisateur);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool UtilisateurExists(int id)
        {
            return db.Utilisateurs.Count(e => e.IdUtilisateur == id) > 0;
        }
    }
}