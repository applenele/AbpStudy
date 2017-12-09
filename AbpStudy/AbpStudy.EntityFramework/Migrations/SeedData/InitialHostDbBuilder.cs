using AbpStudy.EntityFramework;
using EntityFramework.DynamicFilters;

namespace AbpStudy.Migrations.SeedData
{
    public class InitialHostDbBuilder
    {
        private readonly AbpStudyDbContext _context;

        public InitialHostDbBuilder(AbpStudyDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            _context.DisableAllFilters();

            new DefaultEditionsCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();
        }
    }
}
