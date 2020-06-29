using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projeto.DAO;
using Projeto.Model;
using Projeto.Service;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class BaseController<Service, DAO, Entity, VO, TContext, AutoMapProfile> : ControllerBase
        where Service : BaseService<DAO, Entity, VO, TContext, AutoMapProfile>, new()
        where DAO : BaseDAO<Entity, VO, TContext, AutoMapProfile>, new()
        where TContext : DbContext, new()
        where AutoMapProfile : Profile, new()
        where Entity : BaseEntity, new()
        where VO : BaseVO, new()
    {

        Service baseService = new Service();

        [HttpGet("{pageNumber}/{pageSize}/")]
        public List<VO> Get(int pageNumber = 1, int pageSize = 100, [FromQuery] VO filter = null)
        {
            return baseService.GetAll(pageNumber, pageSize, filter);
        }

        [HttpGet("{id}")]
        // GET api/<controller>/5
        public VO Get(int id)
        {
            return baseService.GetOne(id);
        }

        // POST api/<controller>
        [HttpPost]
        public ActionResult Post([FromBody] VO anotacao)
        {
            try
            {
                Random random = new Random();
                anotacao.id = random.Next(3, 70);
                baseService.save(anotacao);
                return Ok();
            }
            catch (Exception e)
            {
                return StatusCode(400, e.Message);
            }

        }

        [HttpPut]
        public ActionResult Put([FromBody]VO vo)
        {
            if (vo.id > 0)
            {
                try
                {
                    baseService.Update(vo);
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
                if (baseService.Delete(id))
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
