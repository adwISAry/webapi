using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using webapi.Context;

namespace webapi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StController : ControllerBase
    {
        StContext _context { get; }
        public StController(StContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await _context.Students.ToListAsync());
        }
        //public async Task<IActionResult> Get(int id)
        //{
        //    if (id == null) return BadRequest();
        //    return Ok(await _context.Students.FindAsync(id));
        //}
    }
}