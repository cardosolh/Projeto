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
    public class PessoasController : ControllerBase
    {

        PessoaService pessoaService = new PessoaService();
        //exemplo de chamada do postman
        //https://localhost:5002/api/pessoas/1/100?nome=Rodrigo
        [HttpGet("{pageNumber}/{pageSize}/")]
        // GET api/<controller>
        public List<PessoaVO> Get(int pageNumber = 1, int pageSize = 100, [FromQuery] PessoaVO filter = null)
        {
            return pessoaService.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public PessoaVO Get(int id)
        {
            return pessoaService.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] PessoaVO pessoa)
        {
            try
            {
                pessoaService.Save(pessoa);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }

        }

        [HttpPut]
        public ActionResult Put([FromBody]PessoaVO vo)
        {
            if(vo.id > 0)
            {
                try 
                { 
                    pessoaService.Update(vo);
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
        //para testar fica assim https://localhost:5001/api/pessoas/1 onde 1 é o id que vc quer apagar
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            try
            {
                if(pessoaService.Delete(id))
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
