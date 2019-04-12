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
    public class PO_DetailController : ControllerBase
    {
        private readonly PO_DetailContext _context;

        public PO_DetailController(PO_DetailContext context)
        {
            _context = context;
        }

        // GET: api/PO_Detail
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PO_Detail>>> GetPO_Details()
        {
            return await _context.PO_Details.ToListAsync();
        }

        // GET: api/PO_Detail/5
        [HttpGet("{id}")]
        public async Task<ActionResult<PO_Detail>> GetPO_Detail(string id)
        {
            var pO_Detail = await _context.PO_Details.FindAsync(id);

            if (pO_Detail == null)
            {
                return NotFound();
            }

            return pO_Detail;
        }

        // PUT: api/PO_Detail/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPO_Detail(string id, PO_Detail pO_Detail)
        {
            if (id != pO_Detail.PO_DetailID)
            {
                return BadRequest();
            }

            _context.Entry(pO_Detail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PO_DetailExists(id))
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

        // POST: api/PO_Detail
        [HttpPost]
        public async Task<ActionResult<PO_Detail>> PostPO_Detail(PO_Detail pO_Detail)
        {
            _context.PO_Details.Add(pO_Detail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPO_Detail", new { id = pO_Detail.PO_DetailID }, pO_Detail);
        }

        // DELETE: api/PO_Detail/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<PO_Detail>> DeletePO_Detail(string id)
        {
            var pO_Detail = await _context.PO_Details.FindAsync(id);
            if (pO_Detail == null)
            {
                return NotFound();
            }

            _context.PO_Details.Remove(pO_Detail);
            await _context.SaveChangesAsync();

            return pO_Detail;
        }

        private bool PO_DetailExists(string id)
        {
            return _context.PO_Details.Any(e => e.PO_DetailID == id);
        }
    }
}
