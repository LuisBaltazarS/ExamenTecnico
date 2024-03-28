using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EventoController : ControllerBase
    {

        private readonly DBContext _context;

        public EventoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Evento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Evento>>> GetCampus()
        {
            if (_context.Evento == null)
            {
                return NotFound();
            }

            return await _context.Evento
                .ToListAsync();
        }

    }
}
