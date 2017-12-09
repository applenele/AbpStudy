using Abp.Domain.Entities;
using Abp.EntityFramework;
using Abp.EntityFramework.Repositories;

namespace AbpStudy.EntityFramework.Repositories
{
    public abstract class AbpStudyRepositoryBase<TEntity, TPrimaryKey> : EfRepositoryBase<AbpStudyDbContext, TEntity, TPrimaryKey>
        where TEntity : class, IEntity<TPrimaryKey>
    {
        protected AbpStudyRepositoryBase(IDbContextProvider<AbpStudyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //add common methods for all repositories
    }

    public abstract class AbpStudyRepositoryBase<TEntity> : AbpStudyRepositoryBase<TEntity, int>
        where TEntity : class, IEntity<int>
    {
        protected AbpStudyRepositoryBase(IDbContextProvider<AbpStudyDbContext> dbContextProvider)
            : base(dbContextProvider)
        {

        }

        //do not add any method here, add to the class above (since this inherits it)
    }
}
