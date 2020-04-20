using Projeto.DAO;
using Projeto.VO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projeto.Service
{
    public class GrupoService
    {
        GrupoDAO dao = new GrupoDAO();
        public GrupoVO save(GrupoVO pessoa)
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

        public List<GrupoVO> getAll(GrupoVO filter = null)
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
