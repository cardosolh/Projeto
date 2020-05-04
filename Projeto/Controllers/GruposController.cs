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

        [HttpGet("{pageNumber}/{pageSize}/")]
        public List<GrupoVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] GrupoVO filter = null)
        {
            return grupoService.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public GrupoVO Get(int id)
        {
            return grupoService.GetOne(id);
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
            catch(Exception e)
            {
                return StatusCode(400, e.Message);
            }
            
        }

        [HttpPut]
        public ActionResult Put([FromBody]GrupoVO vo)
        {
            if (vo.id > 0)
            {
                try
                {
                    grupoService.Update(vo);
                    return Ok();
                }
                catch
                {
                    return StatusCode(400, "Coloque o erro correto e uma msg");
                }

            }
            else
            {
                return StatusCode(400, "Coloque o erro correto e uma msg");
            }

        }

        [HttpDelete("{id}")]
        // DELETE api/<controller>/5
        public ActionResult Delete(int id)
        {
            try
            {
                if (grupoService.Delete(id))
                    return Ok();
                else
                    return BadRequest();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }
        }

    }
}
