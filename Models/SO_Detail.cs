using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class SO_Detail
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SO_DetailID { get; set; }
        [Required]
        public SO_Header SO_Header { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int SO_Quantity { get; set; }
        [Required]
        public DateTime SO_Date { get; set; }
        [Required]
        public int SO_PriceOfUnit { get; set; }
    }
}
