using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PointOfSale.Model
{
    public class OrderLine
    {
        public string ProductCode { get; set; }
        public int PurchaseQuantity { get; set; }
        public decimal TotalPrice { get; set; }
    }
}
