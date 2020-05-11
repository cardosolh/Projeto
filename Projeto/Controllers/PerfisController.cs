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
    public class PerfisController : BaseController<PerfilService, PerfilDAO, Perfil, PerfilVO, DataBaseContext, AutoMapperProfile>
    { 

        //PerfilService perfilService = new PerfilService();

        //[HttpGet("{pageNumber}/{pageSize}/")]
        //public List<PerfilVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] PerfilVO filter = null)
        //{
        //    return perfilService.GetAll(pageNumber, pageSize, filter);
        //}

        //[HttpGet("{id}")]
        //// GET api/<controller>/5
        //public PerfilVO Get(int id)
        //{
        //    return perfilService.GetOne(id);
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public ActionResult Post([FromBody] PerfilVO perfil)
        //{
        //    try
        //    {
        //        perfilService.save(perfil);
        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return StatusCode(400, e.Message);
        //    }
            
        //}

        //[HttpPut]
        //public ActionResult Put([FromBody]PerfilVO vo)
        //{
        //    if (vo.id > 0)
        //    {
        //        try
        //        {
        //            perfilService.Update(vo);
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
        //        if (perfilService.Delete(id))
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
