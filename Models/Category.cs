using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class Category
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string CategoryID { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string CategoryName { get; set; }


        public ICollection<Product> Products { get; set; }
    }
}
