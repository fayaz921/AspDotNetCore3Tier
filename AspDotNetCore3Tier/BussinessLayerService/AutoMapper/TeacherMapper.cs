using AutoMapper;
using BussinessLayerService.Dtos;
using DataAccessLayerService.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayerService.AutoMapper
{
    public class TeacherMapper : Profile
    {
        public TeacherMapper()
        {
            CreateMap<Teacher,AddTeacherDto>().ReverseMap();
        }
    }
}
