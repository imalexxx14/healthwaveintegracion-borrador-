using Cuenta;
using Data;

namespace Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

[Route("api/[controller]")]
[ApiController]
public class CuentaCobrarController : ControllerBase
{
    private readonly ApplicationDbContext<> _context;

    public CuentaCobrarController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: api/CuentaCobrar
    [HttpGet]
    public async Task<ActionResult<IEnumerable<CuentaCobrar>>> GetCuentasCobrar()
    {
        return await _context.CuentasCobrar.ToListAsync();
    }

// GET: api/CuentaCobrar/5

