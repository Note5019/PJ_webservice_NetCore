using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class CategoryContext: DbContext
    {
        public CategoryContext(DbContextOptions<CategoryContext> option) : base(option)
        {

        }

        public DbSet<Category> Category { get; set; }
    }
}
