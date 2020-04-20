using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class LoginService
    {
        LoginDAO dao = new LoginDAO();
        public LoginVO save(LoginVO login)
        {
            try
            {
                if (login.id > 0)
                {
                    dao.Save(login);
                }
                return login;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public List<LoginVO> getAll(LoginVO filter = null)
        {
            try
            {
                return dao.Select(1, 5, filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
