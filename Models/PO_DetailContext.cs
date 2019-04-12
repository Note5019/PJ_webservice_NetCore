using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class PO_DetailContext : DbContext
    {
        public PO_DetailContext(DbContextOptions<PO_DetailContext> option) : base(option)
        {

        }

        public DbSet<PO_Detail> PO_Details { get; set; }
    }
}
