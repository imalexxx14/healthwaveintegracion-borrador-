using Cuenta;
using Data;

namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class IngresoController : ControllerBase
{
    private readonly ApplicationDbContext<> _context;

    public IngresoController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Ingreso
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Ingreso>>> GetIngresos()
    {
        return await _context.Ingresos.ToListAsync();
    }

    // GET: api/Ingreso/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Ingreso>> GetIngreso(int id)
    {
        var ingreso = await _context.Ingresos.FindAsync(id);

        if (ingreso == null)
        {
            return NotFound();
        }

        return ingreso;
    }

    // POST: api/Ingreso
    [HttpPost]
    public async Task<ActionResult<Ingreso>> PostIngreso(Ingreso ingreso)
    {
        _context.Ingresos.Add(ingreso);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetIngreso), new { id = ingreso.IDIngreso }, ingreso);
    }
}
