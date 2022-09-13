using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
    public class BulkOrderDiscount
    {
        public BulkOrderDiscount()
        {

        }

        public BulkOrderDiscount(int quantity, decimal discountedPrice)
        {
            Quantity = quantity;
            DiscountedPrice = discountedPrice;
        }

        [Range(1, int.MaxValue, ErrorMessage = "The {0} must be greater than 0.")]
        public int Quantity { get; set; }

        [Range(1, double.MaxValue, ErrorMessage = "The {0} must be greater than 0.")]
        public decimal DiscountedPrice { get; set; }
    }
}
