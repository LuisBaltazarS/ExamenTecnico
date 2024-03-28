using BackendNet.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BackendNet.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class UbicacionController : ControllerBase
    {

        private readonly DBContext _context;

        public UbicacionController(DBContext context)
        {
            _context = context;
        }

        // GET: api/Ubicacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ubicacion>>> GetCampus()
        {
            if (_context.Ubicacion == null)
            {
                return NotFound();
            }

            return await _context.Ubicacion
                .ToListAsync();
        }


    }
}
