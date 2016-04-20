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
    public class ChambresController : ApiController
    {
        private HomeNMoveContext db = new HomeNMoveContext();

        // GET: api/Chambres
        public IQueryable<Chambre> GetChambres()
        {
            return db.Chambres;
        }

        // GET: api/Chambres/5
        [ResponseType(typeof(Chambre))]
        public IHttpActionResult GetChambre(int id)
        {
            Chambre chambre = db.Chambres.Find(id);
            if (chambre == null)
            {
                return NotFound();
            }

            return Ok(chambre);
        }

        // PUT: api/Chambres/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChambre(int id, Chambre chambre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != chambre.IdChambre)
            {
                return BadRequest();
            }

            db.Entry(chambre).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChambreExists(id))
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

        // POST: api/Chambres
        [ResponseType(typeof(Chambre))]
        public IHttpActionResult PostChambre(Chambre chambre)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            db.Chambres.Add(chambre);

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ChambreExists(chambre.IdChambre))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = chambre.IdChambre }, chambre);
        }

        // DELETE: api/Chambres/5
        [ResponseType(typeof(Chambre))]
        public IHttpActionResult DeleteChambre(int id)
        {
            Chambre chambre = db.Chambres.Find(id);
            if (chambre == null)
            {
                return NotFound();
            }

            db.Chambres.Remove(chambre);
            db.SaveChanges();

            return Ok(chambre);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChambreExists(int id)
        {
            return db.Chambres.Count(e => e.IdChambre == id) > 0;
        }
    }
}