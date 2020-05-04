using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PessoaService
    {
        PessoaDAO dao = new PessoaDAO();
        public PessoaVO Save(PessoaVO pessoa)
        {
            try
            {
                if (pessoa.id > 0)
                {
                    dao.Save(pessoa);
                }
            
                return pessoa;
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public List<PessoaVO> GetAll(int pageNumber, int pageSize, PessoaVO filter = null)
        {
            try
            {
                return dao.Select(pageNumber,pageSize,filter);
            }
            catch
            {
                throw new System.ArgumentException("Estudar...", "estudar...");
            }
        }

        public PessoaVO GetOne(int id = 0)
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

        public bool Update(PessoaVO vo)
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
    }
}
