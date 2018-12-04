using DGFScouting.Data;
using DGFScouting.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DGFScouting.Controllers
{
    public class RecruitsController : ApiController
    {
        RecruitsDbContext recruitsDbContext = new RecruitsDbContext();
        // GET: api/Recruits
        public IHttpActionResult Get()
        {
            // Makes use of Eager loading with the Include() method
            var recruit = recruitsDbContext.Recruits.Include("ScoutingReports");
            return Ok(recruit);
        }

        // GET: api/Recruits/5
        public IHttpActionResult Get(int id)
        {
            //var recruit = recruitsDbContext.Recruits.Find(id);
            var recruit = recruitsDbContext.Recruits.Include("ScoutingReports").FirstOrDefault(q => q.RecruitId == id);

            if (recruit == null)
            {
                return NotFound();
            }
            return Ok(recruit);
        }

        // POST: api/Recruits
        public IHttpActionResult Post([FromBody]Recruit recruit)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            recruitsDbContext.Recruits.Add(recruit);
            recruitsDbContext.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }

        // PUT: api/Recruits/5
        public IHttpActionResult Put(int id, [FromBody]Recruit recruit)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var entity = recruitsDbContext.Recruits.FirstOrDefault(q => q.RecruitId == id);

            if (entity == null)
            {
                return BadRequest("No Recruit record found matching this ID.");
            }

            entity.FirstName = recruit.FirstName;
            entity.LastName = recruit.LastName;
            entity.Position = recruit.Position;
            entity.Rating = recruit.Rating;
            entity.Notes = recruit.Notes;
            recruitsDbContext.SaveChanges();
            return Ok("Recruit record updated successfully.");
        }

        // DELETE: api/Recruits/5
        public IHttpActionResult Delete(int id)
        {
            var recruit = recruitsDbContext.Recruits.Find(id);

            if (recruit == null)
            {
                return BadRequest("Delete failed as no Recruit record was found with this Id.");
            }

            recruitsDbContext.Recruits.Remove(recruit);
            recruitsDbContext.SaveChanges();
            return Ok("Recruit record successfully deleted.");
        }
    }
}