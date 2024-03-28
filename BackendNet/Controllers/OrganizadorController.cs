using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class OrganizadorController: ControllerBase
    {

        private readonly DBContext _context;

        public OrganizadorController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Organizador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Organizador>>> GetCampus()
        {
            if (_context.Organizador == null)
            {
                return NotFound();
            }

            return await _context.Organizador
                .ToListAsync();
        }

    }
}
