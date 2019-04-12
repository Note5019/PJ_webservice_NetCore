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
    public class PurchaseController : ControllerBase
    {
        private readonly PO_HeaderContext _context_PO_Header;
        private readonly PO_DetailContext _context_PO_Deatil;

        public PurchaseController(PO_HeaderContext context1, PO_DetailContext context2)
        {
            _context_PO_Header = context1;
            _context_PO_Deatil = context2;
        }
        // GET: api/Purchase
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PO_Header>>> GetAllPurchaseHeader()
        {
            return await _context_PO_Header.PO_Headers.ToListAsync();
        }

        // GET: api/Purchase/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Purchase
        [HttpPost]
        public async Task<string> Post([FromBody]Object temp)
        {


            //try
            //{
            //await new PO_HeaderController(_context_PO_Header).PostPO_Header(Header);
            //foreach (PO_Detail detail in Details)
            //{
            //    await new PO_DetailController(_context_PO_Deatil).PostPO_Detail(detail);
            //}
            return "succ";
            //}
            //catch
            //{
            //return "fail";
            //}
        }

        // PUT: api/Purchase/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Purchase/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return "123456789";
        }
    }
}
