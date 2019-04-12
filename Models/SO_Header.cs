using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class SO_Header
    {
        [Key]
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SO_CusID { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SO_CusName { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string SO_Address { get; set; }
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string SO_Email { get; set; }
        [Required]
        [Column(TypeName = "varchar(10)")]
        public string SO_Phone { get; set; }
    }
}
