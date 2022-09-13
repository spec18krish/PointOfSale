using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
    public  class Product
    {
        [Required]
        public string ProductCode { get; set; }

        [Required]
        [Range(1, double.MaxValue, ErrorMessage = "The {0} must be non empty and greater than 0.")]
        public decimal UnitPrice { get; set; }

        public BulkOrderDiscount Discount { get; set; }
    }
}
