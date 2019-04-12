using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class SO_DetailContext: DbContext
    {
        public SO_DetailContext(DbContextOptions<SO_DetailContext> option) : base(option)
        {

        }

        public DbSet<SO_Detail> SO_Details { get; set; }
    }
}
