using BussinessLayerService.Dtos;
using DataAccessLayerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.Services.Interface
{
    public interface ITeacherService
    {
        Task<string> SaveTeacher(AddTeacherDto teacher);
    }
}
