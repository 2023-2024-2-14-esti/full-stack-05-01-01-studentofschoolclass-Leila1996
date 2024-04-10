using Kreta.Shared.Dtos;
using Kreta.Shared.Models;
using Kreta.Shared.Models.SwitchTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kreta.Shared.Extensions
{
    public static class TeacherTeachInSchoolClassExtension
    {
        public static TeacherTeachInSchoolClassDto ToDto(this TeacherTeachInSchoolClass model)
        {
            return new TeacherTeachInSchoolClassDto
            {
                Id = model.Id,
                TeacherId = model.TeacherId,
                SchoolClassId = model.SchoolClassId,
                TeacherTeachInScoolClass = model.TeacherTeachInScoolClass,
                SchoolClassWhoTeacherTeach = model.SchoolClassWhoTeacherTeach,
            };               
        }

        public static TeacherTeachInSchoolClass ToModel(this TeacherTeachInSchoolClassDto dto)
        {
            return new TeacherTeachInSchoolClass
            {
                Id = dto.Id,
                TeacherId = dto.TeacherId,
                SchoolClassId = dto.SchoolClassId,
                TeacherTeachInScoolClass = dto.TeacherTeachInScoolClass,
                SchoolClassWhoTeacherTeach = dto.SchoolClassWhoTeacherTeach,
            };
        }
    }                        
}
        

