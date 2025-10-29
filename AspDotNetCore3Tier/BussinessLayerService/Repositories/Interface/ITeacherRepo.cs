using DataAccessLayerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.Repositories.Interface
{
    public interface ITeacherRepo
    {
        Task SaveTeacher(Teacher teacher);
    }
}
