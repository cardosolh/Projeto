using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PessoaGrupoService : BaseService<PessoaGrupoDAO, PessoaGrupo, PessoaGrupoVO, DataBaseContext, AutoMapperProfile>
    {
        
        //PessoaGrupoDAO dao = new PessoaGrupoDAO();
        //public PessoaGrupoVO save(PessoaGrupoVO pessoa_grupo)
        //{
        //    try
        //    {
        //        if (pessoa_grupo.id > 0)
        //        {
        //            dao.Save(pessoa_grupo);
        //        }
        //        return pessoa_grupo;
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Update(PessoaGrupoVO vo)
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

        //public List<PessoaGrupoVO> GetAll(int pageNumber, int pageSize, PessoaGrupoVO filter = null)
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

        //public PessoaGrupoVO GetOne(int id = 0)
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
