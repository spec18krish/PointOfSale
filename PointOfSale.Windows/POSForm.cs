using PointOfSale.BL.Interface;
using PointOfSale.BL.Service;
using PointOfSale.Model;
using PointOfSale.Windows.Helpers.Interface;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PointOfSale.Windows
{
    public partial class POSForm : Form
    {
        private IProductInventoryService _productInventory;
        private IPointOfSaleService _posService;
        private IValidationHelpers _validationHelper;
        public POSForm( IValidationHelpers validationHelper,
                        IPointOfSaleService posService,
                        IProductInventoryService productInventory
                       )
        {
            _productInventory = productInventory;
            _posService = posService;
            _validationHelper = validationHelper;
            InitializeComponent();
            AddScanButton();
        }

        private void AddScanButton()
        {
            var scanButtonColumn = new DataGridViewButtonColumn();
            scanButtonColumn.Name = "Scan";
            scanButtonColumn.Text = "Scan";
            scanButtonColumn.ToolTipText = "Click to scan the product";
            scanButtonColumn.UseColumnTextForButtonValue = true;
            grvScanProducts.Columns.Add(scanButtonColumn);

            var removeButtonColumn = new DataGridViewButtonColumn();
            removeButtonColumn.Name = "Remove";
            removeButtonColumn.Text = "Remove";
            scanButtonColumn.ToolTipText = "Click to remove the scaned product";
            removeButtonColumn.UseColumnTextForButtonValue = true;
            grvScanProducts.Columns.Add(removeButtonColumn);
        }

        private void LoadUpdateProductCombo()
        {
            var allProductCodes = _productInventory.GetAllProducts().Select(s => s.ProductCode).ToList();
            cmbProductCode.DataSource = allProductCodes;
        }

        private void LoadProducts()
        {
            var products = _productInventory.GetAllProducts();

            DataTable dtProducts = new DataTable("Products");
            dtProducts.Columns.Add("ProductCode", typeof(string));
            dtProducts.Columns.Add("UnitPrice", typeof(decimal));
            dtProducts.Columns.Add("BulkPrice", typeof(string));
            dtProducts.Columns.Add("PurchaseQuantity", typeof(int));
            dtProducts.Columns.Add("Price", typeof(decimal));

            foreach (var product in products)
            {
                var scannedProductInfo = _posService.GetScannedProductInfo(product.ProductCode);
                DataRow dr = dtProducts.NewRow();
                dr["ProductCode"] = product.ProductCode;
                dr["UnitPrice"] = product.UnitPrice;
                dr["BulkPrice"] = product.Discount.Quantity != 0 ?
                                         $"${product.Discount.DiscountedPrice} for {product.Discount.Quantity} Items" :
                                         "N/A";
                if (scannedProductInfo != null)
                {
                    dr["PurchaseQuantity"] = scannedProductInfo.PurchaseQuantity;
                    dr["Price"] = scannedProductInfo.TotalPrice;
                }

                dtProducts.Rows.Add(dr);
            }

            grvScanProducts.DataSource = dtProducts;
            lblTotalPrice.Text = $"Total Price: $" + _posService.CalculateTotal();

            if (grvScanProducts.Columns["Scan"] == null)
            {
                AddScanButton();
            }

        }       

        private void ClearAll()
        {
            txtProductCode.Text = string.Empty;
            _numDrUnitPrice.Value = 0;
            _numDrBulkPrice.Value = 0;
            _numDrBulkQuantity.Value = 0;
        }

        private void ScanProduct(string productCode)
        {
            _posService.ScanProduct(productCode);
            _posService.CalculateTotal();
        }

        private void DisplayValidationMessage(List<ValidationResult> validationResults)
        {
            string validationMessage = _validationHelper.GetValidationMessage(validationResults);
            MessageBox.Show(validationMessage, "Validation Errors");
        }       

        #region Events
        private void grvScanProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grvScanProducts.Rows.Count == 0)
            {
                MessageBox.Show("No products found, Please add products and try again");
                return;
            }

            string productCode = grvScanProducts.Rows[e.RowIndex].Cells["ProductCode"].Value.ToString();
            if (e.ColumnIndex == grvScanProducts.Columns["Scan"].Index)
            {
                ScanProduct(productCode);
                LoadProducts();
            }

            if (e.ColumnIndex == grvScanProducts.Columns["Remove"].Index)
            {
                var product = _productInventory.GetProductByCode(productCode);
                var scannedProducts = _posService.GetScannedProducts();
                if (scannedProducts.Count() == 0)
                {
                    MessageBox.Show("The Product is not Scanned");
                    return;
                }
                scannedProducts.Remove(product);
                _posService.CalculateTotal();
                LoadProducts();
            }
        }

        private void cmbProductCode_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedProductCode = cmbProductCode.SelectedValue.ToString();
            var product = _productInventory.GetProductByCode(selectedProductCode);
            _numDrUpdateUnitPrice.Value = product.UnitPrice;
            if (product.Discount != null)
            {
                _numDrUpdateBulkPrice.Value = product.Discount.DiscountedPrice;
                _numDrUpdateBulkQuantity.Value = product.Discount.Quantity;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string selectedProductCode = cmbProductCode?.SelectedValue?.ToString();

            if (string.IsNullOrWhiteSpace(selectedProductCode))
            {
                MessageBox.Show("No products found, Please add products and try again");
                return;
            }
           
            var existingProduct = _productInventory.GetProductByCode(selectedProductCode);
            existingProduct.Discount = new BulkOrderDiscount((int)_numDrUpdateBulkQuantity.Value, _numDrUpdateBulkPrice.Value);
            existingProduct.UnitPrice = _numDrUpdateUnitPrice.Value;

            _validationHelper.Validate(existingProduct);
            var validationResult = _validationHelper.Validate(existingProduct);
            if (validationResult.Count() > 0)
            {
                DisplayValidationMessage(validationResult);
                return;
            }

            _productInventory.UpdateProduct(selectedProductCode, existingProduct.UnitPrice, existingProduct.Discount);
            LoadProducts();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Product product = new Product()
            {
                ProductCode = txtProductCode.Text,
                UnitPrice = _numDrUnitPrice.Value
            };

            product.Discount = new BulkOrderDiscount()
            {
                DiscountedPrice = _numDrBulkPrice.Value,
                Quantity = Convert.ToInt32(_numDrBulkQuantity.Value)
            };           
          

            var existingProduct = _productInventory.GetProductByCode(product.ProductCode);

            if (existingProduct != null)
            {
                MessageBox.Show("Product already exists");
                return;
            }

            var validationResult = _validationHelper.Validate(product);
            if (validationResult.Count() > 0)
            {
                DisplayValidationMessage(validationResult);
                return;
            }
           

            _productInventory.AddProduct(product);
            MessageBox.Show("Product Added Successfully");
            ClearAll();
            LoadProducts();
            LoadUpdateProductCombo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        #endregion
    }
}
