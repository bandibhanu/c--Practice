using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Myproduct.Models
{
    public class Myproductclass
    {
        [Key]
        public string Id { get; set; }



        [Required]
        [Display(Name = "Product Name")]
        [StringLength(50)]
        public string name { get; set; }
        public string category { get; set; }

        [Display(Name = "Order Date")]
        public DateTime Orderdate { get; set; }

        [Display(Name = "Product Qty")]
        public int productquality { get; set; }

        [DataType(DataType.Currency)]
        public double productprise { get; set; }

    }
}