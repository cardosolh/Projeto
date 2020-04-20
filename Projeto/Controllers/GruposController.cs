using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.Model;
using Projeto.Service;
using Projeto.VO;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GruposController : ControllerBase
    {

        GrupoService grupoService = new GrupoService();

        [HttpGet]
        // GET api/<controller>
        public List<GrupoVO> Get()
        {
            try
            {

                return grupoService.getAll();
            }
            catch (Exception e)
            {
                throw;
            }
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] GrupoVO grupo)
        {
            try
            {
                grupoService.save(grupo);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }

        }

        // PUT api/<controller>/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        [HttpDelete]
        public void Delete(int id)
        {
        }

    }
}
