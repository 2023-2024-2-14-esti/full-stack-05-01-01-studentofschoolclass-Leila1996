using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Dtos;
using Kreta.Shared.Models.SwitchTable;

namespace Kreta.Backend.Controllers
{
    public class TeacherTeachInSchoolClassController : BaseController<TeacherTeachInSchoolClass, TeacherTeachInSchoolClassDto>
    {
        public TeacherTeachInSchoolClassController(Assambler<TeacherTeachInSchoolClass, TeacherTeachInSchoolClassDto>? assambler, IRepositoryBase<TeacherTeachInSchoolClass>? repo) : base(assambler, repo)
        {
        }
    }
}
