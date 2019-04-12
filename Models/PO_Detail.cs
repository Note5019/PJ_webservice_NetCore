using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class PO_Detail
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string PO_DetailID { get; set; }
        [Required]
        public PO_Header PO_Header { get; set; }
        [Required]
        public Product Product { get; set; }
        [Required]
        public int PO_Quantity { get; set; }
        [Required]
        public DateTime PO_Date { get; set; }
        [Required]
        public int PO_PriceOfUnit { get; set; }
    }
}
