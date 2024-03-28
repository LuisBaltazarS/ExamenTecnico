using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class SubTipoEventoController: ControllerBase
    {

        private readonly DBContext _context;

        public SubTipoEventoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/SubTipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<SubtipoEvento>>> GetCampus()
        {
            if (_context.SubtipoEvento == null)
            {
                return NotFound();
            }

            return await _context.SubtipoEvento
                .ToListAsync();
        }

    }
}
