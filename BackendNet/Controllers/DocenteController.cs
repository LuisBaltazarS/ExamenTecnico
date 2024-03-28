using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController: ControllerBase
    {

        private readonly DBContext _context;

        public DocenteController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Docente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Docente>>> GetDocente()
        {

            if(_context.Docente == null)
            {
                return NotFound();
            }

            return await _context.Docente
                .ToListAsync();

        }

    }
}
