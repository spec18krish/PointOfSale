namespace PointOfSale.Windows
{
    partial class POSForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlPOS = new System.Windows.Forms.Panel();
            this.lblScanProducts = new System.Windows.Forms.Label();
            this.cmbProductCode = new System.Windows.Forms.ComboBox();
            this.lblUpdateProduct = new System.Windows.Forms.Label();
            this._numDrUpdateUnitPrice = new System.Windows.Forms.NumericUpDown();
            this._numDrUpdateBulkQuantity = new System.Windows.Forms.NumericUpDown();
            this._numDrUpdateBulkPrice = new System.Windows.Forms.NumericUpDown();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblUpdateBulkQuantity = new System.Windows.Forms.Label();
            this.lblUpdateBulkPrice = new System.Windows.Forms.Label();
            this.lblUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lblUpdateProductCode = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.grvScanProducts = new System.Windows.Forms.DataGridView();
            this.lblAddProduct = new System.Windows.Forms.Label();
            this._numDrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this._numDrBulkQuantity = new System.Windows.Forms.NumericUpDown();
            this._numDrBulkPrice = new System.Windows.Forms.NumericUpDown();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblBulkPrice = new System.Windows.Forms.Label();
            this.lblBulkQuantity = new System.Windows.Forms.Label();
            this.lblUnitPrice = new System.Windows.Forms.Label();
            this.txtProductCode = new System.Windows.Forms.TextBox();
            this.lblProductCode = new System.Windows.Forms.Label();
            this.lblVoyagerTechnicalTest = new System.Windows.Forms.Label();
            this.pnlPOS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlPOS
            // 
            this.pnlPOS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlPOS.Controls.Add(this.lblScanProducts);
            this.pnlPOS.Controls.Add(this.cmbProductCode);
            this.pnlPOS.Controls.Add(this.lblUpdateProduct);
            this.pnlPOS.Controls.Add(this._numDrUpdateUnitPrice);
            this.pnlPOS.Controls.Add(this._numDrUpdateBulkQuantity);
            this.pnlPOS.Controls.Add(this._numDrUpdateBulkPrice);
            this.pnlPOS.Controls.Add(this.btnUpdate);
            this.pnlPOS.Controls.Add(this.lblUpdateBulkQuantity);
            this.pnlPOS.Controls.Add(this.lblUpdateBulkPrice);
            this.pnlPOS.Controls.Add(this.lblUpdateUnitPrice);
            this.pnlPOS.Controls.Add(this.lblUpdateProductCode);
            this.pnlPOS.Controls.Add(this.lblTotalPrice);
            this.pnlPOS.Controls.Add(this.grvScanProducts);
            this.pnlPOS.Controls.Add(this.lblAddProduct);
            this.pnlPOS.Controls.Add(this._numDrUnitPrice);
            this.pnlPOS.Controls.Add(this._numDrBulkQuantity);
            this.pnlPOS.Controls.Add(this._numDrBulkPrice);
            this.pnlPOS.Controls.Add(this.btnCancel);
            this.pnlPOS.Controls.Add(this.btnAdd);
            this.pnlPOS.Controls.Add(this.lblBulkPrice);
            this.pnlPOS.Controls.Add(this.lblBulkQuantity);
            this.pnlPOS.Controls.Add(this.lblUnitPrice);
            this.pnlPOS.Controls.Add(this.txtProductCode);
            this.pnlPOS.Controls.Add(this.lblProductCode);
            this.pnlPOS.Location = new System.Drawing.Point(51, 112);
            this.pnlPOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlPOS.Name = "pnlPOS";
            this.pnlPOS.Size = new System.Drawing.Size(1472, 891);
            this.pnlPOS.TabIndex = 0;
            // 
            // lblScanProducts
            // 
            this.lblScanProducts.AutoSize = true;
            this.lblScanProducts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblScanProducts.Location = new System.Drawing.Point(788, 48);
            this.lblScanProducts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblScanProducts.Name = "lblScanProducts";
            this.lblScanProducts.Size = new System.Drawing.Size(153, 25);
            this.lblScanProducts.TabIndex = 28;
            this.lblScanProducts.Text = "Scan Products";
            // 
            // cmbProductCode
            // 
            this.cmbProductCode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbProductCode.Location = new System.Drawing.Point(168, 574);
            this.cmbProductCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbProductCode.Name = "cmbProductCode";
            this.cmbProductCode.Size = new System.Drawing.Size(160, 28);
            this.cmbProductCode.TabIndex = 27;
            this.cmbProductCode.SelectedIndexChanged += new System.EventHandler(this.cmbProductCode_SelectedIndexChanged);
            // 
            // lblUpdateProduct
            // 
            this.lblUpdateProduct.AutoSize = true;
            this.lblUpdateProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblUpdateProduct.Location = new System.Drawing.Point(92, 490);
            this.lblUpdateProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateProduct.Name = "lblUpdateProduct";
            this.lblUpdateProduct.Size = new System.Drawing.Size(161, 25);
            this.lblUpdateProduct.TabIndex = 26;
            this.lblUpdateProduct.Text = "Update Product";
            // 
            // _numDrUpdateUnitPrice
            // 
            this._numDrUpdateUnitPrice.DecimalPlaces = 2;
            this._numDrUpdateUnitPrice.Location = new System.Drawing.Point(168, 634);
            this._numDrUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrUpdateUnitPrice.Name = "_numDrUpdateUnitPrice";
            this._numDrUpdateUnitPrice.Size = new System.Drawing.Size(160, 27);
            this._numDrUpdateUnitPrice.TabIndex = 25;
            // 
            // _numDrUpdateBulkQuantity
            // 
            this._numDrUpdateBulkQuantity.Location = new System.Drawing.Point(168, 762);
            this._numDrUpdateBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrUpdateBulkQuantity.Name = "_numDrUpdateBulkQuantity";
            this._numDrUpdateBulkQuantity.Size = new System.Drawing.Size(160, 27);
            this._numDrUpdateBulkQuantity.TabIndex = 24;
            // 
            // _numDrUpdateBulkPrice
            // 
            this._numDrUpdateBulkPrice.DecimalPlaces = 2;
            this._numDrUpdateBulkPrice.Location = new System.Drawing.Point(168, 699);
            this._numDrUpdateBulkPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrUpdateBulkPrice.Name = "_numDrUpdateBulkPrice";
            this._numDrUpdateBulkPrice.Size = new System.Drawing.Size(160, 27);
            this._numDrUpdateBulkPrice.TabIndex = 23;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(149, 831);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 35);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblUpdateBulkQuantity
            // 
            this.lblUpdateBulkQuantity.AutoSize = true;
            this.lblUpdateBulkQuantity.Location = new System.Drawing.Point(60, 765);
            this.lblUpdateBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBulkQuantity.Name = "lblUpdateBulkQuantity";
            this.lblUpdateBulkQuantity.Size = new System.Drawing.Size(100, 20);
            this.lblUpdateBulkQuantity.TabIndex = 20;
            this.lblUpdateBulkQuantity.Text = "Bulk Quantity:";
            // 
            // lblUpdateBulkPrice
            // 
            this.lblUpdateBulkPrice.AutoSize = true;
            this.lblUpdateBulkPrice.Location = new System.Drawing.Point(60, 699);
            this.lblUpdateBulkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateBulkPrice.Name = "lblUpdateBulkPrice";
            this.lblUpdateBulkPrice.Size = new System.Drawing.Size(76, 20);
            this.lblUpdateBulkPrice.TabIndex = 19;
            this.lblUpdateBulkPrice.Text = "Bulk Price:";
            // 
            // lblUpdateUnitPrice
            // 
            this.lblUpdateUnitPrice.AutoSize = true;
            this.lblUpdateUnitPrice.Location = new System.Drawing.Point(60, 634);
            this.lblUpdateUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateUnitPrice.Name = "lblUpdateUnitPrice";
            this.lblUpdateUnitPrice.Size = new System.Drawing.Size(75, 20);
            this.lblUpdateUnitPrice.TabIndex = 18;
            this.lblUpdateUnitPrice.Text = "Unit Price:";
            // 
            // lblUpdateProductCode
            // 
            this.lblUpdateProductCode.AutoSize = true;
            this.lblUpdateProductCode.Location = new System.Drawing.Point(60, 574);
            this.lblUpdateProductCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUpdateProductCode.Name = "lblUpdateProductCode";
            this.lblUpdateProductCode.Size = new System.Drawing.Size(102, 20);
            this.lblUpdateProductCode.TabIndex = 16;
            this.lblUpdateProductCode.Text = "Product Code:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblTotalPrice.Location = new System.Drawing.Point(1084, 462);
            this.lblTotalPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(183, 25);
            this.lblTotalPrice.TabIndex = 15;
            this.lblTotalPrice.Text = "Total Price: $0.00";
            // 
            // grvScanProducts
            // 
            this.grvScanProducts.AllowUserToAddRows = false;
            this.grvScanProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grvScanProducts.Location = new System.Drawing.Point(375, 115);
            this.grvScanProducts.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grvScanProducts.Name = "grvScanProducts";
            this.grvScanProducts.ReadOnly = true;
            this.grvScanProducts.RowHeadersWidth = 51;
            this.grvScanProducts.Size = new System.Drawing.Size(1003, 315);
            this.grvScanProducts.TabIndex = 14;
            this.grvScanProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grvScanProducts_CellClick);
            // 
            // lblAddProduct
            // 
            this.lblAddProduct.AutoSize = true;
            this.lblAddProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblAddProduct.Location = new System.Drawing.Point(128, 48);
            this.lblAddProduct.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddProduct.Name = "lblAddProduct";
            this.lblAddProduct.Size = new System.Drawing.Size(131, 25);
            this.lblAddProduct.TabIndex = 13;
            this.lblAddProduct.Text = "Add Product";
            // 
            // _numDrUnitPrice
            // 
            this._numDrUnitPrice.DecimalPlaces = 2;
            this._numDrUnitPrice.Location = new System.Drawing.Point(168, 198);
            this._numDrUnitPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrUnitPrice.Name = "_numDrUnitPrice";
            this._numDrUnitPrice.Size = new System.Drawing.Size(160, 27);
            this._numDrUnitPrice.TabIndex = 12;
            // 
            // _numDrBulkQuantity
            // 
            this._numDrBulkQuantity.Location = new System.Drawing.Point(168, 326);
            this._numDrBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrBulkQuantity.Name = "_numDrBulkQuantity";
            this._numDrBulkQuantity.Size = new System.Drawing.Size(160, 27);
            this._numDrBulkQuantity.TabIndex = 11;
            // 
            // _numDrBulkPrice
            // 
            this._numDrBulkPrice.DecimalPlaces = 2;
            this._numDrBulkPrice.Location = new System.Drawing.Point(168, 262);
            this._numDrBulkPrice.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this._numDrBulkPrice.Name = "_numDrBulkPrice";
            this._numDrBulkPrice.Size = new System.Drawing.Size(160, 27);
            this._numDrBulkPrice.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(235, 395);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(100, 35);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(64, 395);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 35);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblBulkPrice
            // 
            this.lblBulkPrice.AutoSize = true;
            this.lblBulkPrice.Location = new System.Drawing.Point(60, 329);
            this.lblBulkPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulkPrice.Name = "lblBulkPrice";
            this.lblBulkPrice.Size = new System.Drawing.Size(100, 20);
            this.lblBulkPrice.TabIndex = 6;
            this.lblBulkPrice.Text = "Bulk Quantity:";
            // 
            // lblBulkQuantity
            // 
            this.lblBulkQuantity.AutoSize = true;
            this.lblBulkQuantity.Location = new System.Drawing.Point(60, 262);
            this.lblBulkQuantity.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBulkQuantity.Name = "lblBulkQuantity";
            this.lblBulkQuantity.Size = new System.Drawing.Size(76, 20);
            this.lblBulkQuantity.TabIndex = 4;
            this.lblBulkQuantity.Text = "Bulk Price:";
            // 
            // lblUnitPrice
            // 
            this.lblUnitPrice.AutoSize = true;
            this.lblUnitPrice.Location = new System.Drawing.Point(60, 198);
            this.lblUnitPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnitPrice.Name = "lblUnitPrice";
            this.lblUnitPrice.Size = new System.Drawing.Size(75, 20);
            this.lblUnitPrice.TabIndex = 2;
            this.lblUnitPrice.Text = "Unit Price:";
            // 
            // txtProductCode
            // 
            this.txtProductCode.Location = new System.Drawing.Point(168, 132);
            this.txtProductCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.Size = new System.Drawing.Size(165, 27);
            this.txtProductCode.TabIndex = 1;
            // 
            // lblProductCode
            // 
            this.lblProductCode.AutoSize = true;
            this.lblProductCode.Location = new System.Drawing.Point(60, 138);
            this.lblProductCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.Size = new System.Drawing.Size(102, 20);
            this.lblProductCode.TabIndex = 0;
            this.lblProductCode.Text = "Product Code:";
            // 
            // lblVoyagerTechnicalTest
            // 
            this.lblVoyagerTechnicalTest.AutoSize = true;
            this.lblVoyagerTechnicalTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.lblVoyagerTechnicalTest.Location = new System.Drawing.Point(746, 44);
            this.lblVoyagerTechnicalTest.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVoyagerTechnicalTest.Name = "lblVoyagerTechnicalTest";
            this.lblVoyagerTechnicalTest.Size = new System.Drawing.Size(188, 25);
            this.lblVoyagerTechnicalTest.TabIndex = 29;
            this.lblVoyagerTechnicalTest.Text = "Xe Technical Test";
            // 
            // POSForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1680, 1069);
            this.Controls.Add(this.lblVoyagerTechnicalTest);
            this.Controls.Add(this.pnlPOS);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "POSForm";
            this.Text = "Point of Sale";
            this.pnlPOS.ResumeLayout(false);
            this.pnlPOS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUpdateBulkPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grvScanProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._numDrBulkPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel pnlPOS;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblBulkPrice;
        private System.Windows.Forms.Label lblBulkQuantity;
        private System.Windows.Forms.Label lblUnitPrice;
        private System.Windows.Forms.TextBox txtProductCode;
        private System.Windows.Forms.Label lblProductCode;
        private System.Windows.Forms.NumericUpDown _numDrUnitPrice;
        private System.Windows.Forms.NumericUpDown _numDrBulkQuantity;
        private System.Windows.Forms.NumericUpDown _numDrBulkPrice;
        private System.Windows.Forms.DataGridView grvScanProducts;
        private System.Windows.Forms.Label lblAddProduct;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Label lblUpdateProduct;
        private System.Windows.Forms.NumericUpDown _numDrUpdateUnitPrice;
        private System.Windows.Forms.NumericUpDown _numDrUpdateBulkQuantity;
        private System.Windows.Forms.NumericUpDown _numDrUpdateBulkPrice;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblUpdateBulkQuantity;
        private System.Windows.Forms.Label lblUpdateBulkPrice;
        private System.Windows.Forms.Label lblUpdateUnitPrice;
        private System.Windows.Forms.Label lblUpdateProductCode;
        private System.Windows.Forms.ComboBox cmbProductCode;
        private System.Windows.Forms.Label lblScanProducts;
        private System.Windows.Forms.Label lblVoyagerTechnicalTest;
    }
}

