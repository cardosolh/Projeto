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
        public PessoaVO save(PessoaVO pessoa)
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

        public List<PessoaVO> getAll(int pageNumber, int numberOffElements, PessoaVO filter = null)
        {
            try
            {
                return dao.Select(pageNumber, numberOffElements, filter);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
