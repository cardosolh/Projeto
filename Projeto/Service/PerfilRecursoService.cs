using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PerfilRecursoService : BaseService<PerfilRecursoDAO, PerfilRecurso, PerfilRecursoVO, DataBaseContext, AutoMapperProfile>
    {
        
        //PerfilRecursoDAO dao = new PerfilRecursoDAO();
        //public PerfilRecursoVO save(PerfilRecursoVO perfil_recurso)
        //{
        //    try
        //    {
        //        if (perfil_recurso.id > 0)
        //        {
        //            dao.Save(perfil_recurso);
        //        }
        //        return perfil_recurso;
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Update(PerfilRecursoVO vo)
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

        //public List<PerfilRecursoVO> GetAll(int pageNumber, int pageSize, PerfilRecursoVO filter = null)
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

        //public PerfilRecursoVO GetOne(int id = 0)
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
