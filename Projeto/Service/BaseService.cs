using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public abstract class BaseService<DAO, Entity, VO, TContext, AutoMapProfile>
        where DAO : BaseDAO<Entity, VO, TContext, AutoMapProfile>, new()
        where TContext : DbContext, new()
        where AutoMapProfile : Profile, new()
        where Entity : BaseEntity, new()
        where VO : BaseVO, new()
    {
        DAO dao = new DAO();

        public VO save(VO vo)
        {
            try
            {
                dao.Save(vo);

                return vo;
            }
            catch (Exception e)
            {
                throw new System.ArgumentException(e.Message);
            }
        }

        public bool Update(VO vo)
        {
            try
            {
                return dao.Update(vo);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public List<VO> GetAll(int pageNumber, int pageSize, VO filter = null)
        {
            try
            {
                return dao.Select(pageNumber, pageSize, filter);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public VO GetOne(int id = 0)
        {
            try
            {
                return dao.SelectOne(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Delete(int id)
        {
            try
            {
                return dao.Delete(id);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }
    }
}

