using Kreta.Backend.Context;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Backend.Repos.SwitchTables
{
    public class TeacherTeachInSchoolClassRepo<TDbContext> : RepositoryBase<TDbContext, TeacherTeachInSchoolClass>, ITeacherTeachInSchoolClass
        where TDbContext : KretaContext
    {
        public TeacherTeachInSchoolClassRepo(TDbContext? dbContext) : base(dbContext)
        {
        }
    }
}
