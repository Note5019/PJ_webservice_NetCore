using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PJ_webservice_CRUD.Models;

namespace PJ_webservice_CRUD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PO_HeaderController : ControllerBase
    {
        private readonly PO_HeaderContext _context;

        public PO_HeaderController(PO_HeaderContext context)
        {
            _context = context;
        }

        // GET: api/PO_Header
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PO_Header>>> GetPO_Headers()
        {
            return await _context.PO_Headers.ToListAsync();
        }

        // GET: api/PO_Header/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PO_Header>> GetPO_Header(string id)
        {
            var pO_Header = await _context.PO_Headers.FindAsync(id);

            if (pO_Header == null)
            {
                return NotFound();
            }

            return pO_Header;
        }

        // PUT: api/PO_Header/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPO_Header(string id, PO_Header pO_Header)
        {
            if (id != pO_Header.PO_SupplyID)
            {
                return BadRequest();
            }

            _context.Entry(pO_Header).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PO_HeaderExists(id))
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

        // POST: api/PO_Header
        [HttpPost]
        public async Task<ActionResult<PO_Header>> PostPO_Header(PO_Header pO_Header)
        {
            _context.PO_Headers.Add(pO_Header);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPO_Header", new { id = pO_Header.PO_SupplyID }, pO_Header);
        }

        // DELETE: api/PO_Header/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PO_Header>> DeletePO_Header(string id)
        {
            var pO_Header = await _context.PO_Headers.FindAsync(id);
            if (pO_Header == null)
            {
                return NotFound();
            }

            _context.PO_Headers.Remove(pO_Header);
            await _context.SaveChangesAsync();

            return pO_Header;
        }

        private bool PO_HeaderExists(string id)
        {
            return _context.PO_Headers.Any(e => e.PO_SupplyID == id);
        }
    }
}
