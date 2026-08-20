using computadora.Models;
using Microsoft.AspNetCore.Mvc;

namespace computadora.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ComputadoraController : ControllerBase
    {
        // GET: api/Computadora
        [HttpGet]
        public Computadora Get()
        {
            Computadora compu = new Computadora();

            compu.marca = "Apple";
            compu.procesador = "M5 Pro";
            compu.ram = 16;

            List<string> programas = new List<string>();

            programas.Add("Safari");
            programas.Add("Chrome");
            programas.Add("Visual Studio");

            compu.programasInstalados = programas;

            return compu;
        }


        // GET: api/Computadora/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            if (id == 0)
            {
                return "ERROR";
            }

            return "OK";
        }


        // POST: api/Computadora
        [HttpPost]
        public string Post(Computadora compu)
        {
            return compu.marca;
        }


        // PUT: api/Computadora/5
        [HttpPut("{id}")]
        public void Put(int id, Computadora compu)
        {
        }


        // DELETE: api/Computadora/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}