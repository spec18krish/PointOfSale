using PointOfSale.BL.Interface;
using PointOfSale.Model;
using System.Collections.Generic;

namespace PointOfSale.BL.Service
{
    public  class ProductInventoryService : IProductInventoryService
    {
        private List<Product> _products;       
        public ProductInventoryService()
        {
            _products = new List<Product>();
        }    

        public List<Product> GetAllProducts()
        {
            return _products;
        }

        public void AddProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount)
        {
            var newProduct = new Product()
            {
                ProductCode = productCode,
                UnitPrice = unitPrice,
                Discount = discount
            };

            _products.Add(newProduct);
        }

        public void AddProduct(Product newProduct)
        { 
            _products.Add(newProduct);
        }

        public void UpdateProduct(string productCode, decimal unitPrice, BulkOrderDiscount discount)
        {
            if (string.IsNullOrWhiteSpace(productCode)) return;
            UpdateDiscountPrice(productCode, discount);
            UpdateProductPrice(productCode, unitPrice);
        }

        public void UpdateProduct(Product productToUpdate)
        {
            if (string.IsNullOrWhiteSpace(productToUpdate?.ProductCode)) return;
            UpdateDiscountPrice(productToUpdate.ProductCode, productToUpdate.Discount);
            UpdateProductPrice(productToUpdate.ProductCode, productToUpdate.UnitPrice);
        }

        public Product GetProductByCode(string productCode)
        {
            Product product = null;
            if (string.IsNullOrWhiteSpace(productCode))
            {
                return product;
            }

            product = _products.Find(f => f.ProductCode == productCode);
            return product;
        }

        public void DeleteAllProducts()
        {
            _products.Clear();
        }

        public void UpdateProductPrice(string productCode, decimal unitPrice)
        {
            var product = GetProductByCode(productCode);
            if (product != null)
            {
                product.UnitPrice = unitPrice;
            }
        }

        public void UpdateDiscountPrice(string productCode, BulkOrderDiscount discount)
        {
            var product = GetProductByCode(productCode);
            if (product != null)
            {
                product.Discount = discount;
            }
        }


    }
}
