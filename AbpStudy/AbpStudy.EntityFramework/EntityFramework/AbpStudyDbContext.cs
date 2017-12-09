using System.Data.Common;
using Abp.Zero.EntityFramework;
using AbpStudy.Authorization.Roles;
using AbpStudy.Authorization.Users;
using AbpStudy.MultiTenancy;

namespace AbpStudy.EntityFramework
{
    public class AbpStudyDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public AbpStudyDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in AbpStudyDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of AbpStudyDbContext since ABP automatically handles it.
         */
        public AbpStudyDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public AbpStudyDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public AbpStudyDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
