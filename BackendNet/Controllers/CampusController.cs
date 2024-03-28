using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CampusController: ControllerBase
    {
        private readonly DBContext _context;

        public CampusController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Campus
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Campus>>> GetCampus()
        {
            if (_context.Campus == null)
            {
                return NotFound();
            }

            return await _context.Campus
                .ToListAsync();
        }

    }
}
