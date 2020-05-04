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
    public class RecursosController : ControllerBase
    {

        RecursoService recursoService = new RecursoService();

        [HttpGet("{pageNumber}/{pageSize}/")]
        public List<RecursoVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] RecursoVO filter = null)
        {
            return recursoService.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public RecursoVO Get(int id)
        {
            return recursoService.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] RecursoVO recurso)
        {
            try
            {
                recursoService.save(recurso);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(400, e.Message);
            }
            
        }

        [HttpPut]
        public ActionResult Put([FromBody]RecursoVO vo)
        {
            if (vo.id > 0)
            {
                try
                {
                    recursoService.Update(vo);
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
        // DELETE api/<controller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if (recursoService.Delete(id))
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
