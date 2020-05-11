using Projeto.DAO;
using Projeto.Model;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class LoginService : BaseService<LoginDAO, Login, LoginVO, DataBaseContext, AutoMapperProfile>
    {
        
        //LoginDAO dao = new LoginDAO();
        //public LoginVO save(LoginVO login)
        //{
        //    try
        //    {
        //        if (login.id > 0)
        //        {
        //            dao.Save(login);
        //        }
        //        return login;
        //    }
        //    catch
        //    {
        //        throw new System.ArgumentException("Estudar...", "estudar...");
        //    }
        //}

        //public bool Update(LoginVO vo)
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

        //public List<LoginVO> GetAll(int pageNumber, int pageSize, LoginVO filter = null)
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

        //public LoginVO GetOne(int id = 0)
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
