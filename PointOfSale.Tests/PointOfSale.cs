using NUnit.Framework;
using PointOfSale.BL.Interface;
using PointOfSale.BL.Service;
using PointOfSale.Model;
using System.Collections.Generic;
using System.Linq;

namespace PointOfSale.Tests
{
    [TestFixture]
    public class PointOfSale
    {
        IProductInventoryService _productInventoryService;
        IPointOfSaleService _posService;

        public PointOfSale()
        {
             _productInventoryService = new ProductInventoryService();
             _posService = new PointOfSaleService(_productInventoryService);            
        }

        private void AddProduct(string productCode, decimal unitPrice, decimal discountPrice = 0, int bulkQuantity = 0)
        {
            _productInventoryService.AddProduct(productCode, unitPrice, new BulkOrderDiscount() { Quantity = bulkQuantity, DiscountedPrice = discountPrice });
        }

        [SetUp]
        public void InitializeProduct()
        {
            _productInventoryService.DeleteAllProducts();
            _posService.ClearScannedProducts();

            AddProduct("A", (decimal)1.25, 3, 3);
            AddProduct("B", (decimal)4.25);
            AddProduct("C", 1, 5, 6);
            AddProduct("D", (decimal)0.75);
        }

        [Test]
        [TestCase("A,B,C,D,A,B,A", 13.25)] //case for ABCDABA
        [TestCase("C,C,C,C,C,C,C", 6.00)] //case for CCCCCCC
        [TestCase("A,B,C,D", 7.25)] //case for ABCD
        public void ShouldScanAndCalculateCorrectTotal(string productCodes, decimal expectedValue)
        {
            List<string> allProductCodes = productCodes.Split(',').ToList();
            allProductCodes.ForEach(productCode => _posService.ScanProduct(productCode));
            Assert.AreEqual(_posService.CalculateTotal(), expectedValue);
        }

        [Test]
        [TestCase("A", 1.25)]
        [TestCase("A", 0)]
        [TestCase("A", -0.45)]
        public void ShouldSetCorrectUnitPriceForProducts(string productCode, decimal unitPrice)
        {
            _posService.SetPricing(productCode, unitPrice);
            var product = _productInventoryService.GetProductByCode(productCode);
            Assert.AreEqual(product.UnitPrice, unitPrice);
        }

        [Test]
        [TestCase("A", 1)]
        [TestCase("A,B,C,D", 4)]
        public void ShouldScanProducts(string productCodes, int expectedProductCount)
        {
            List<string> allProductCodes = productCodes.Split(',').ToList();
            allProductCodes.ForEach(productCode => _posService.ScanProduct(productCode));
            Assert.AreEqual(_posService.GetScannedProducts().Count(), expectedProductCount);
        }

    }
}