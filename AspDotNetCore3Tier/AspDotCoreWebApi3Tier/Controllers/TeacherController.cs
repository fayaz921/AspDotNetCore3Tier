using BussinessLayerService.Dtos;
using BussinessLayerService.Services.Interface;
using DataAccessLayerService.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotCoreWebApi3Tier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService teacherService;
        public TeacherController(ITeacherService _teacherservice)
        {
            teacherService = _teacherservice;
        }
        [HttpPost]
        [Route("SaveTeacher")]
        public async Task<IActionResult> SaveTeacher([FromBody]AddTeacherDto teacher)
        {
           var response = await teacherService.SaveTeacher(teacher);
            return response.Data is null ? NotFound(response.Error) : Ok(response.Data);
            
        }
    }
}
