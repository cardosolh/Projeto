using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class AnotacaoService : BaseService< AnotacaoDAO, Anotacao, AnotacaoVO, DataBaseContext, AutoMapperProfile>
    {

        //AnotacaoDAO dao = new AnotacaoDAO();
        //public AnotacaoVO save(AnotacaoVO anotacao)
        //{
        //    try
        //    {
        //        dao.Save(anotacao);

        //        return anotacao;
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Update(AnotacaoVO vo)
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

        //public List<AnotacaoVO> GetAll(int pageNumber, int pageSize, AnotacaoVO filter = null)
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

        //public AnotacaoVO GetOne(int id = 0)
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


