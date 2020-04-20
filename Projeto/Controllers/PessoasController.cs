﻿using System;
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

        [HttpGet]
        // GET api/<controller>
        public List<PessoaVO> Get( int pageNumber = 0, int numberOffElements = 0)
        {
            try
            {
                
                return pessoaService.getAll(pageNumber, numberOffElements, null);
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
        public ActionResult Post([FromBody] PessoaVO pessoa)
        {
            try
            {
                pessoaService.save(pessoa);
                return Ok();
            }
            catch(Exception e)
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
