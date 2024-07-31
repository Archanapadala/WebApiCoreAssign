using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiCoreAssign.Controllers
{

    //https://loalhost:portnumber/api/student
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudents()
            //IActionResult its an interface which is used to return the result
        {
            string[] studentNames = new string[] { "Archana", "Ninni ", "Padala" };
            return Ok(studentNames);
        }
    }
}
