using Cuenta;
using Data;

namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class FacturaController : ControllerBase
{
    private readonly ApplicationDbContext<> _context;

    public FacturaController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/Factura
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Factura>>> GetFacturas()
    {
        return await _context.Facturas.ToListAsync();
    }

    // GET: api/Factura/5
    [HttpGet("{id}")]
    public async Task<ActionResult<Factura>> GetFactura(string id)
    {
        var factura = await _context.Facturas.FindAsync(id);

        if (factura == null)
        {
            return NotFound();
        }

        return factura;
    }

    // POST: api/Factura
    [HttpPost]
    public async Task<ActionResult<Factura>> PostFactura(Factura factura)
    {
        _context.Facturas.Add(factura);
        await _context.SaveChangesAsync();

        return CreatedAtAction(nameof(GetFactura), new { id = factura.FacturaCodigo }, factura);
    }
}
