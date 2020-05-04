using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class RecursoService
    {
        
        RecursoDAO dao = new RecursoDAO();
        public RecursoVO save(RecursoVO recurso)
        {
            try
            {
                if (recurso.descricao.Count() > 0)
                {
                    dao.Save(recurso);
                }
                return recurso;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public bool Update(RecursoVO vo)
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

        public List<RecursoVO> GetAll(int pageNumber, int pageSize, RecursoVO filter = null)
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

        public RecursoVO GetOne(int id = 0)
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
