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
    public class PerfisRecursosController : BaseController<PerfilRecursoService, PerfilRecursoDAO, PerfilRecurso, PerfilRecursoVO, DataBaseContext, AutoMapperProfile>
    {

        //PerfilRecursoService perfilRecursoService = new PerfilRecursoService();

        //[HttpGet("{pageNumber}/{pageSize}/")]
        //public List<PerfilRecursoVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] PerfilRecursoVO filter = null)
        //{
        //    return perfilRecursoService.GetAll(pageNumber, pageSize, filter);
        //}

        //[HttpGet("{id}")]
        //// GET api/<controller>/5
        //public PerfilRecursoVO Get(int id)
        //{
        //    return perfilRecursoService.GetOne(id);
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public ActionResult Post([FromBody] PerfilRecursoVO perfil_recurso)
        //{
        //    try
        //    {
        //        perfilRecursoService.save(perfil_recurso);
        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return StatusCode(400, e.Message);
        //    }
            
        //}

        //[HttpPut]
        //public ActionResult Put([FromBody]PerfilRecursoVO vo)
        //{
        //    if (vo.id > 0)
        //    {
        //        try
        //        {
        //            perfilRecursoService.Update(vo);
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
        //        if (perfilRecursoService.Delete(id))
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
