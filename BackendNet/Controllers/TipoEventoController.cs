using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class TipoEventoController: ControllerBase
    {

        private readonly DBContext _context;

        public TipoEventoController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Tipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TipoEvento>>> GetCampus()
        {
            if (_context.TipoEvento == null)
            {
                return NotFound();
            }

            return await _context.TipoEvento
                .ToListAsync();
        }

    }
}
