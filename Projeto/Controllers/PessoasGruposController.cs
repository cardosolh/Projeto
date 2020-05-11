using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Projeto.DAO;
using Projeto.Model;
using Projeto.Service;
using Projeto.VO;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasGruposController : BaseController<PessoaGrupoService, PessoaGrupoDAO, PessoaGrupo, PessoaGrupoVO, DataBaseContext, AutoMapperProfile>
    {

        //PessoaGrupoService pessoaGrupoService = new PessoaGrupoService();

        //[HttpGet("{pageNumber}/{pageSize}/")]
        //public List<PessoaGrupoVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] PessoaGrupoVO filter = null)
        //{
        //    return pessoaGrupoService.GetAll(pageNumber, pageSize, filter);
        //}

        //[HttpGet("{id}")]
        //// GET api/<controller>/5
        //public PessoaGrupoVO Get(int id)
        //{
        //    return pessoaGrupoService.GetOne(id);
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public ActionResult Post([FromBody] PessoaGrupoVO pessoa_grupo)
        //{
        //    try
        //    {
        //        pessoaGrupoService.save(pessoa_grupo);
        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return StatusCode(400, e.Message);
        //    }
            
        //}

        //[HttpPut]
        //public ActionResult Put([FromBody]PessoaGrupoVO vo)
        //{
        //    if (vo.id > 0)
        //    {
        //        try
        //        {
        //            pessoaGrupoService.Update(vo);
        //            return Ok();
        //        }
        //        catch
        //        {
        //            return StatusCode(400, "Coloque o erro correto e uma msg");
        //        }

        //    }
        //    else
        //    {
        //        return StatusCode(400, "Coloque o erro correto e uma msg");
        //    }

        //}

        //// DELETE api/<controller>/5
        //[HttpDelete("{id}")]
        //public ActionResult Delete(int id)
        //{
        //    try
        //    {
        //        if (pessoaGrupoService.Delete(id))
        //            return Ok();
        //        else
        //            return BadRequest();
        //    }
        //    catch (Exception e)
        //    {
        //        return StatusCode(400, e.Message);
        //    }
        //}

    }
}
