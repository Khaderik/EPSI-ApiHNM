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
    public class NuitsController : ApiController
    {
        private HomeNMoveContext db = new HomeNMoveContext();

        // GET: api/Nuits
        public IQueryable<Nuit> GetNuits()
        {
            return db.Nuits;
        }

        // GET: api/Nuits/5
        [ResponseType(typeof(Nuit))]
        public IHttpActionResult GetNuit(int id)
        {
            Nuit nuit = db.Nuits.Find(id);
            if (nuit == null)
            {
                return NotFound();
            }

            return Ok(nuit);
        }

        // PUT: api/Nuits/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutNuit(int id, Nuit nuit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != nuit.IdNuit)
            {
                return BadRequest();
            }

            db.Entry(nuit).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!NuitExists(id))
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

        // POST: api/Nuits
        [ResponseType(typeof(Nuit))]
        public IHttpActionResult PostNuit(Nuit nuit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Nuits.Add(nuit);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (NuitExists(nuit.IdNuit))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = nuit.IdNuit }, nuit);
        }

        // DELETE: api/Nuits/5
        [ResponseType(typeof(Nuit))]
        public IHttpActionResult DeleteNuit(int id)
        {
            Nuit nuit = db.Nuits.Find(id);
            if (nuit == null)
            {
                return NotFound();
            }

            db.Nuits.Remove(nuit);
            db.SaveChanges();

            return Ok(nuit);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool NuitExists(int id)
        {
            return db.Nuits.Count(e => e.IdNuit == id) > 0;
        }
    }
}