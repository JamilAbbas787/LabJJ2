using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace LabJJ2.Models
{
    public class Products
    {

        // Name(Required, Maxlength 20)
        [Required]
        [DisplayName("Product Name")]
        [MaxLength(20)]
        public string Name { get; set; }


        //Description(Required, Maxlength 50)
        [DisplayName("Description")]
        [Required]
        [MaxLength(50)]
        public string Description { get; set; }

        // Price(Required, Decimal)
        [DisplayName("Price")]
        [Required]
        public decimal Price { get; set; }

    }
}