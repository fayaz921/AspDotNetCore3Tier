using BussinessLayerService.Repositories.Interface;
using DataAccessLayerService.Data;
using DataAccessLayerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.Repositories.Implementation
{
    public class TeacherRepo : ITeacherRepo
    {
        private readonly AppDbContext appDbContext;
        public TeacherRepo(AppDbContext _appDbContext)
        {
            appDbContext = _appDbContext;
        }
        public async Task SaveTeacher(Teacher teacher)
        {
            await appDbContext.teachers.AddAsync(teacher);
            await appDbContext.SaveChangesAsync();
        }
    }
}
