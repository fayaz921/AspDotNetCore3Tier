using BussinessLayerService.Repositories.Interface;
using BussinessLayerService.Services.Interface;
using DataAccessLayerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.Services.Implementation
{
    internal class TeacherService : ITeacherService
    {
        private readonly ITeacherRepo teacherRepo;
        public TeacherService(ITeacherRepo _teacherrepo)
        {
            teacherRepo = _teacherrepo;
        }
        public async Task<string> SaveTeacher(Teacher teacher)
        {
             await teacherRepo.SaveTeacher(teacher);
             return "Teacher Saved Successfully";
        }
    }
}
