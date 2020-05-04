using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PerfilService
    {
        
        PerfilDAO dao = new PerfilDAO();
        public PerfilVO save(PerfilVO perfil)
        {
            try
            {
                if (perfil.descricao.Count() > 0)
                {
                    dao.Save(perfil);
                }
                return perfil;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Update(PerfilVO vo)
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

        public List<PerfilVO> GetAll(int pageNumber, int pageSize, PerfilVO filter = null)
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

        public PerfilVO GetOne(int id = 0)
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
