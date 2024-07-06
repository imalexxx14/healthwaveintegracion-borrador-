using Cuenta;
using Data;

namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class SalaController : ControllerBase
{
    private readonly ApplicationDbContext _context;

    public SalaController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Sala
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Sala>>> GetSalas()
    {
        return await _context.Salas.ToListAsync();
    }

    // GET: api/Sala/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Sala>> GetSala(int id)
    {
        var sala = await _context.Salas.FindAsync(id);

        if (sala == null)
        {
            return NotFound();
        }

        return sala;
    }

    // POST: api/Sala
    [HttpPost]
    public async Task<ActionResult<Sala>> PostSala(Sala sala)
    {
        _context.Salas.Add(sala);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetSala), new { id = sala.NumSala }, sala);
    }
}
