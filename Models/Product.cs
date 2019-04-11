using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PJ_webservice_CRUD.Models
{
    public class Product
    {
        //[Key]
        [Column(TypeName = "varchar(10)")]
        public string ProductID { get; set; }
        [Column(TypeName = "varchar(50)")]
        public string ProductName { get; set; }
        [Column(TypeName = "varchar(10)")]
        public string CatID { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
        public string ImgURL { get; set; }
    }
}
