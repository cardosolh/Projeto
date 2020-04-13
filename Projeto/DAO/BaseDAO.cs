using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Projeto.Model;
using System.Linq;

namespace Projeto.DAO
{
    public abstract class BaseDAO<Entity, VO, TContext, AutoMapProfile>
        where TContext : DbContext, new()
        where AutoMapProfile : Profile, new()
        where Entity : BaseEntity, new()
    {

        protected IMapper _mapper;

        public BaseDAO()
        {
            // Instancia os mapeamentos de models e value objects
            var config = new MapperConfiguration(cfg =>
            {
                cfg.AddProfile(new AutoMapProfile());
            });

            _mapper = new Mapper(config);
        }

        public virtual void Save(VO vo)
        {
            Entity entity = null;
            try
            {
                using (TContext context = new TContext())
                {

                    // Mapeia o Value Object, ou seja, o converte em objeto-modelo a ser salvo no banco de dados
                    entity = _mapper.Map<VO, Entity>(vo, entity);

                    // Injeta dependencia correta no context e realiza operação no banco de dados (salva o registro)
                    context.Set<Entity>().Add(entity);

                    // Atualiza o estado do entry com estado da operação realizada (adicionar)
                    context.Entry(entity).State = EntityState.Added;

                    // Salva todas as alterações realizadas na sessão e reseta o tracking (state) do objeto de contexto
                    context.SaveChanges();
                }
            }
            catch
            {
                throw new System.Exception("");
            }

        }

        public virtual bool Delete(long id)
        {

            try
            {

                using (TContext context = new TContext())
                {
                    // Recupera o objeto a ser deletado e o atribui a uma variável.
                    // A recuperação se dá utilizando um context injetado que acessa o banco e o 
                    // busca pela primeira entrada que corresponda ao Id recebido como parâmetro.
                    var entity = context.Set<Entity>().Where(m => m.Id == id).FirstOrDefault();

                    // Verifica se a busca retornou objeto válido
                    if(entity != null)
                    {
                        // Injeta o contexto adequado e remove o objeto recuperado na busca anterior.
                        context.Set<Entity>().Remove(entity);

                        // Salva todas as alterações realizadas na sessão e reseta o tracking (state) do objeto de contexto
                        context.SaveChanges();
                        return true;
                    }
                    
                }
            }
            catch
            {
                throw new System.Exception("");
            }

            return false;

        }


    }
}
