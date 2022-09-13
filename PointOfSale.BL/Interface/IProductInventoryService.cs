using PointOfSale.Model;
using System.Collections.Generic;

namespace PointOfSale.BL.Interface
{
    public interface IProductInventoryService
    {
        void AddProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount);
        void AddProduct(Product newProduct);
        Product GetProductByCode(string productCode);
        List<Product> GetAllProducts();
        void DeleteAllProducts();
        void UpdateProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount);
        void UpdateProductPrice(string productCode, decimal unitPrice);
        void UpdateDiscountPrice(string productCode, BulkOrderDiscount discount);
    }
}
