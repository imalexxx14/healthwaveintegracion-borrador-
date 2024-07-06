using Cuenta;
using Data;

namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class ConsultaController : ControllerBase
{
    private readonly ApplicationDbContext<> _context;

    public ConsultaController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Consulta
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Consulta>>> GetConsultas()
    {
        return await _context.Consultas.ToListAsync();
    }

    // GET: api/Consulta/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Consulta>> GetConsulta(int id)
    {
        var consulta = await _context.Consultas.FindAsync(id);

        if (consulta == null)
        {
            return NotFound();
        }

        return consulta;
    }

    // POST: api/Consulta
    [HttpPost]
    public async Task<ActionResult<Consulta>> PostConsulta(Consulta consulta)
    {
        _context.Consultas.Add(consulta);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetConsulta), new { id = consulta.ConsultaCodigo }, consulta);
    }
}
