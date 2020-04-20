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
        public PerfilVO save(PerfilVO pessoa)
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

        public List<PerfilVO> getAll(PerfilVO filter = null)
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
