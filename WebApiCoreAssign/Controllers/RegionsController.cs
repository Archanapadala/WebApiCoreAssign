using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using WebApiCoreAssign.Data;

namespace WebApiCoreAssign.Controllers
{
    //https://localhost:portnumber/api/Regions
    [Route("api/[controller]")]
    [ApiController]
    public class RegionsController : ControllerBase
    {

        private readonly WalksDbContext _context;
        public RegionsController(WalksDbContext dbcontext)
        {
            this._context = dbcontext;
        }
        [HttpGet]
        public IActionResult GetAll()
        {

            var regions = _context.Regions.ToList();
            return Ok(regions);
        }
        [HttpGet]
        [Route("{id:Guid}")]
        public IActionResult GetById([FromRoute] Guid id)
        {

           // var region = _context.Regions.Find(id);
            var region = _context.Regions.FirstOrDefault(x => x.Id == id);
            if (region == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(region);
            }

        }
    }
}
