using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApi.Data;
using WebApi.Models;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturasController : ControllerBase
    {
        private readonly VentasContext _context;

        public FacturasController(VentasContext context)
        {
            _context = context;
        }

        // GET: api/Facturas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facturas>>> GetFacturas()
        {
            return await _context.Facturas.ToListAsync();
        }

        // GET: api/Facturas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facturas>> GetFacturas(int id)
        {
            var facturas = await _context.Facturas.FindAsync(id);

            if (facturas == null)
            {
                return NotFound();
            }

            return facturas;
        }

        // PUT: api/Facturas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacturas(int id, Facturas facturas)
        {
            if (id != facturas.idFactura)
            {
                return BadRequest();
            }

            _context.Entry(facturas).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacturasExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Facturas
        [HttpPost]
        public async Task<ActionResult<Facturas>> PostFacturas(Facturas facturas)
        {
            _context.Facturas.Add(facturas);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacturas", new { id = facturas.idFactura }, facturas);
        }

        // DELETE: api/Facturas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Facturas>> DeleteFacturas(int id)
        {
            var facturas = await _context.Facturas.FindAsync(id);
            if (facturas == null)
            {
                return NotFound();
            }

            _context.Facturas.Remove(facturas);
            await _context.SaveChangesAsync();

            return facturas;
        }

        private bool FacturasExists(int id)
        {
            return _context.Facturas.Any(e => e.idFactura == id);
        }
    }
}
