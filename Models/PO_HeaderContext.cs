using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class PO_HeaderContext : DbContext
    {
        public PO_HeaderContext(DbContextOptions<PO_HeaderContext> option) : base(option)
        {

        }

        public DbSet<PO_Header> PO_Headers { get; set; }
    }
}
