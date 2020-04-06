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
                    entity = _mapper.Map<VO, Entity>(vo, entity);
                    context.Set<Entity>().Add(entity);
                    context.Entry(entity).State = EntityState.Added;
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
                    var entity = context.Set<Entity>().Where(m => m.Id == id).FirstOrDefault();

                    if(entity != null)
                    {
                        context.Set<Entity>().Remove(entity);
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
