using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class GrupoService : BaseService<GrupoDAO, Grupo, GrupoVO, DataBaseContext, AutoMapperProfile>
    {
        
        //GrupoDAO dao = new GrupoDAO();
        //public GrupoVO save(GrupoVO grupo)
        //{
        //    try
        //    {
        //        if (grupo.id > 0)
        //        {
        //            dao.Save(grupo);
        //        }
        //        return grupo;
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Update(GrupoVO vo)
        //{
        //    try
        //    {
        //        return dao.Update(vo);
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public List<GrupoVO> GetAll(int pageNumber, int pageSize, GrupoVO filter = null)
        //{
        //    try
        //    {
        //        return dao.Select(pageNumber, pageSize, filter);
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public GrupoVO GetOne(int id = 0)
        //{
        //    try
        //    {
        //        return dao.SelectOne(id);
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Delete(int id)
        //{
        //    try
        //    {
        //        return dao.Delete(id);
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}
    }
}
