using AutoMapper;
using BussinessLayerService.ApiResponse;
using BussinessLayerService.Dtos;
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
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepo teacherRepo;
        private readonly IMapper mapper;
        public TeacherService(ITeacherRepo _teacherrepo, IMapper _mapper)
        {
            teacherRepo = _teacherrepo;
            mapper = _mapper;
        }
        public async Task<ApiResponse<string>> SaveTeacher(AddTeacherDto teacher)
        { 
            var teach = mapper.Map<Teacher>(teacher);
            await teacherRepo.SaveTeacher(teach);
            return ApiResponse<string>.SuccessResponse("Teacher Saved Successfully");
        }
    }
}
