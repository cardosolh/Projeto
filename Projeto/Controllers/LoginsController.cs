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
    public class LoginsController : BaseController<LoginService, LoginDAO, Login, LoginVO, DataBaseContext, AutoMapperProfile>
    {

        [HttpGet("teste/{pagNumber}/{pageSize}/")]

        public List<LoginVO> GetInclude(int pageNumber = 1, int pageSize = 100, [FromQuery] LoginVO filter = null)
        {
            return new LoginService().GetAllInclude(pageNumber, pageSize, filter);
        }

        //LoginService loginService = new LoginService();

        //[HttpGet("{pageNumber}/{pageSize}/")]
        //public List<LoginVO> Get(int pageNumber = 1, int pageSize = 1, [FromQuery] LoginVO filter = null)
        //{
        //    return loginService.GetAll(pageNumber, pageSize, filter);
        //}

        //[HttpGet("{id}")]
        //// GET api/<controller>/5
        //public LoginVO Get(int id)
        //{
        //    return loginService.GetOne(id);
        //}

        //// POST api/<controller>
        //[HttpPost]
        //public ActionResult Post([FromBody] LoginVO login)
        //{
        //    try
        //    {
        //        loginService.save(login);
        //        return Ok();
        //    }
        //    catch(Exception e)
        //    {
        //        return StatusCode(400, e.Message);
        //    }

        //}

        //[HttpPut]
        //public ActionResult Put([FromBody]LoginVO vo)
        //{
        //    if (vo.id > 0)
        //    {
        //        try
        //        {
        //            loginService.Update(vo);
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
        //        if (loginService.Delete(id))
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
