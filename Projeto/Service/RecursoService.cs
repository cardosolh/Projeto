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
                if (recurso.descricao.Length > 0)
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
    }
}
