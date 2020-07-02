using Microsoft.EntityFrameworkCore;
using Projeto.Model;
using Projeto.VO;
using System.Collections.Generic;
using System.Linq;

namespace Projeto.DAO
{
    public class LoginDAO : BaseDAO<Login, LoginVO, DataBaseContext, AutoMapperProfile>
    {
        public virtual List<LoginVO> SelectWithInclude(int pageNumber, int numberOfElements, LoginVO filter)
        {
            var filteredItensVO = new List<LoginVO>();

            using (DataBaseContext context = new DataBaseContext())
            {
                //context.Login.Include(p => p.Pessoa).Load();

                int currentPage = pageNumber == 0 ? pageNumber = 1 : pageNumber;

                IQueryable<Login> dbQuery = context.Set<Login>();
                dbQuery = GetCustomWhere(dbQuery, filter);

                int totalItens = dbQuery.Count();
                int itemPerPage = numberOfElements == 0 ? totalItens : numberOfElements;

                dbQuery = dbQuery
                    .Skip((currentPage - 1) * numberOfElements)
                    .Take(itemPerPage);

                IEnumerable<Login> filteredItens = dbQuery;

                if (itemPerPage > 0)
                {
                    filteredItensVO = filteredItens
                            .Select(m => FromEntityToVO(m))
                            .ToList();

                }

            }

            return filteredItensVO;

        }


    }
}
