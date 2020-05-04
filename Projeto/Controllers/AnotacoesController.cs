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
    public class AnotacoesController : ControllerBase
    {

        AnotacaoService anotacaoService = new AnotacaoService();

        [HttpGet("{pageNumber}/{pageSize}/")]
        public List<AnotacaoVO> Get(int pageNumber = 1, int pageSize = 100, [FromQuery] AnotacaoVO filter = null)
        {
            return anotacaoService.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public AnotacaoVO Get(int id)
        {
            return anotacaoService.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] AnotacaoVO anotacao)
        {
            try
            {
                anotacaoService.save(anotacao);
                return Ok();
            }
            catch(Exception e)
            {
                return StatusCode(400, e.Message);
            }
            
        }

        [HttpPut]
        public ActionResult Put([FromBody]AnotacaoVO vo)
        {
            if (vo.id > 0)
            {
                try
                {
                    anotacaoService.Update(vo);
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
                if (anotacaoService.Delete(id))
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
