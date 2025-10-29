using BussinessLayerService.Services.Interface;
using DataAccessLayerService.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AspDotCoreWebApi3Tier.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService teacherService;
        public TeacherController(ITeacherService _teacherservice)
        {
            teacherService = _teacherservice;
        }
        [HttpPost]
        [Route("SaveTeacher")]
        public async Task<IActionResult> SaveTeacher(Teacher teacher)
        {
            await teacherService.SaveTeacher(teacher);
            return Ok("Teacher Saved Successfully");
        }
    }
}
