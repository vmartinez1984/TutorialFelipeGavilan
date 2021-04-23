using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiPaises.Models;

namespace WebApiPaises.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        //public PaisController(ApplicationDbContext context)
        //{
        //    this.Context = context;
        //}

        //public ApplicationDbContext Context { get; }

        List<Pais> paises;

        public PaisController()
        {
            paises = new List<Pais>();
            paises.Add(new Pais { Id = 1, Nombre = "Rusia" });
            paises.Add(new Pais { Id = 2, Nombre = "China" });
            paises.Add(new Pais { Id = 3, Nombre = "Cuba" });
        }

        [HttpGet]
        public IEnumerable<Pais> Get()
        {
            return paises;
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            Pais pais;

            pais = paises.Where(x => x.Id == id).FirstOrDefault();

            if (pais == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(pais);
            }
        }

        [HttpPost]
        public IActionResult Post(Pais pais)
        {
            //return StatusCode(StatusCodes.Status500InternalServerError, new Exception ("Valio pepino"  ));
            try
            {
                if (ModelState.IsValid)
                {
                    paises.Add(pais);

                    return Created($@"Api/Pais/{pais.Id}", new { IsSuccess = true });
                }
                else
                {
                    return BadRequest(ModelState);
                }
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex);
            }
        }
    }
}
