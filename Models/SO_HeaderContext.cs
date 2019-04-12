using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class SO_HeaderContext : DbContext
    {
        public SO_HeaderContext(DbContextOptions<SO_HeaderContext> option) : base(option)
        {

        }

        public DbSet<SO_Header> SO_Headers { get; set; }
    }
}
