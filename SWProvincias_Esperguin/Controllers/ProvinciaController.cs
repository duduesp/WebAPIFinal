using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SWProvincias_Esperguin.Data;
using SWProvincias_Esperguin.Models;

namespace SWProvincias_Esperguin.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {

        private readonly DBPaisContext context;


        public ProvinciaController(DBPaisContext context)
        {
            this.context = context;
        }

        //GET: api/provincia
        [HttpGet]

        public ActionResult<IEnumerable<Provincia>> Get()
        {
            return context.Provincias.ToList();
        }

        //Post api/provincia
        [HttpPost]

        public ActionResult Post(Provincia provincia)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(provincia);
            }
            context.Provincias.Add(provincia);
            context.SaveChanges();
            return Ok();
        }

        //Put api/provincia/2

        [HttpPut("{id}")]

        public ActionResult Put(int id, [FromBody] Provincia provincia)
        {
            if (id != provincia.IdProvincia)
            {
                return BadRequest();
            }
            context.Entry(provincia).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();

            return Ok();
        }


        //Delele api/provincia/2

        [HttpDelete("{id}")]

        public ActionResult<Provincia> Delete(int id)
        {
            var provincia = (from a in context.Provincias
                           where a.IdProvincia == id
                           select a).SingleOrDefault();
            if (provincia == null)
            {
                return NotFound();
            }
            context.Provincias.Remove(provincia);
            context.SaveChanges();
            return provincia;

        }

    }
}
