using System;
using Projeto.DAO;
using Projeto.VO;

using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class PessoaGrupoService
    {
        PessoaGrupoDAO dao = new PessoaGrupoDAO();
        public PessoaGrupoVO save(PessoaGrupoVO pessoa)
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

        public List<PessoaGrupoVO> getAll(PessoaGrupoVO filter = null)
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
