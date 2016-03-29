using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using NewTelecom.Web.Models;
using NewTelecom.Domain;
using NewTelecom.Service;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace NewTelecom.Web.Controllers
{
    [Route("api/[controller]")]
    public class ClientePessoaFisicaController : Controller
    {
        // GET api/ClientePessoaFisica
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var model = await new ClienteService().Listar();
            return Ok(model);
        }

        // GET api/ClientePessoaFisica/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {

            var model = new ClientePessoaFisica
            {
                ClienteId = new Guid().ToString(),
                Cpf = "396888178-81",
                DataNascimento = new DateTime(1993, 2, 22),
                DocIdentidade = "489791335",
                Nome = "Mariana Santiago"
            };

            return Ok(model);
        }

        // POST api/ClientePessoaFisica
        [HttpPost]
        public  IActionResult Post([FromBody]ClientePessoaFisica model)
        {
            return Ok();
        }

        // PUT api/ClientePessoaFisica/5
        [HttpPut("{id}")]
        [HttpPut]
        public void Put(string id, [FromBody]ClientePessoaFisica model)
        {
        }

        // DELETE api/ClientePessoaFisica/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
        }
    }
}
