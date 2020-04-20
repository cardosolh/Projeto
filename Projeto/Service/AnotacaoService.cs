using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class AnotacaoService
    {
        AnotacaoDAO dao = new AnotacaoDAO();
        public AnotacaoVO save(AnotacaoVO pessoa)
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

        public List<AnotacaoVO> getAll(AnotacaoVO filter = null)
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
