using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class PO_Header
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string PO_SupplyID { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PO_SupplyName { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string PO_Adress { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string PO_Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string PO_Tel { get; set; }
    }
}
