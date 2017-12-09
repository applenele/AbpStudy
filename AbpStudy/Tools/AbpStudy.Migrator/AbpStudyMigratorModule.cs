using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using AbpStudy.EntityFramework;

namespace AbpStudy.Migrator
{
    [DependsOn(typeof(AbpStudyDataModule))]
    public class AbpStudyMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<AbpStudyDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}