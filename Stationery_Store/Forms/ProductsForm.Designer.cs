using System;
using System.Drawing;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    partial class ProductsForm
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
            filterPanel = new Panel();
            stockStatusComboBox = new ComboBox();
            lblStockStatus = new Label();
            txtMaxPrice = new TextBox();
            lblPriceRange = new Label();
            txtMinPrice = new TextBox();
            categoryComboBox = new ComboBox();
            lblCategory = new Label();
            searchTextBox = new TextBox();
            lblSearch = new Label();
            productsGridView = new DataGridView();
            totalProductsLabel = new Label();
            btnAddProduct = new Button();
            btnEditProduct = new Button();
            btnDeleteProduct = new Button();
            paginationPanel = new Panel();
            btnFirst = new Button();
            btnPrev = new Button();
            btnNext = new Button();
            btnLast = new Button();
            lblPageInfo = new Label();
            flowLayoutPanelNoProducts = new FlowLayoutPanel();
            lblNoProductsText = new Label();
            btnAddNewProductInline = new Button();
            filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            paginationPanel.SuspendLayout();
            flowLayoutPanelNoProducts.SuspendLayout();
            SuspendLayout();
            // 
            // filterPanel
            // 
            filterPanel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            filterPanel.BackColor = Color.FromArgb(236, 240, 241);
            filterPanel.Controls.Add(stockStatusComboBox);
            filterPanel.Controls.Add(lblStockStatus);
            filterPanel.Controls.Add(txtMaxPrice);
            filterPanel.Controls.Add(lblPriceRange);
            filterPanel.Controls.Add(txtMinPrice);
            filterPanel.Controls.Add(categoryComboBox);
            filterPanel.Controls.Add(lblCategory);
            filterPanel.Controls.Add(searchTextBox);
            filterPanel.Controls.Add(lblSearch);
            filterPanel.Location = new Point(-157, 13);
            filterPanel.Name = "filterPanel";
            filterPanel.RightToLeft = RightToLeft.Yes;
            filterPanel.Size = new Size(1192, 80);
            filterPanel.TabIndex = 8;
            // 
            // stockStatusComboBox
            // 
            stockStatusComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            stockStatusComboBox.FormattingEnabled = true;
            stockStatusComboBox.Location = new Point(17, 30);
            stockStatusComboBox.Name = "stockStatusComboBox";
            stockStatusComboBox.Size = new Size(197, 31);
            stockStatusComboBox.TabIndex = 7;
            // 
            // lblStockStatus
            // 
            lblStockStatus.AutoSize = true;
            lblStockStatus.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStockStatus.ForeColor = Color.FromArgb(52, 73, 94);
            lblStockStatus.Location = new Point(220, 33);
            lblStockStatus.Name = "lblStockStatus";
            lblStockStatus.Size = new Size(105, 23);
            lblStockStatus.TabIndex = 6;
            lblStockStatus.Text = "حالة المخزون:";
            // 
            // txtMaxPrice
            // 
            txtMaxPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMaxPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMaxPrice.Location = new Point(351, 30);
            txtMaxPrice.Name = "txtMaxPrice";
            txtMaxPrice.PlaceholderText = "الحد الأعلى";
            txtMaxPrice.Size = new Size(100, 30);
            txtMaxPrice.TabIndex = 5;
            // 
            // lblPriceRange
            // 
            lblPriceRange.AutoSize = true;
            lblPriceRange.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPriceRange.ForeColor = Color.FromArgb(52, 73, 94);
            lblPriceRange.Location = new Point(563, 33);
            lblPriceRange.Name = "lblPriceRange";
            lblPriceRange.Size = new Size(98, 23);
            lblPriceRange.TabIndex = 4;
            lblPriceRange.Text = "نطاق السعر:";
            // 
            // txtMinPrice
            // 
            txtMinPrice.BorderStyle = BorderStyle.FixedSingle;
            txtMinPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtMinPrice.Location = new Point(457, 30);
            txtMinPrice.Name = "txtMinPrice";
            txtMinPrice.PlaceholderText = "الحد الأدنى";
            txtMinPrice.Size = new Size(100, 30);
            txtMinPrice.TabIndex = 3;
            // 
            // categoryComboBox
            // 
            categoryComboBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            categoryComboBox.FormattingEnabled = true;
            categoryComboBox.Location = new Point(681, 30);
            categoryComboBox.Name = "categoryComboBox";
            categoryComboBox.Size = new Size(180, 31);
            categoryComboBox.TabIndex = 3;
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategory.ForeColor = Color.FromArgb(52, 73, 94);
            lblCategory.Location = new Point(867, 33);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(73, 23);
            lblCategory.TabIndex = 2;
            lblCategory.Text = "الأصناف:";
            // 
            // searchTextBox
            // 
            searchTextBox.BorderStyle = BorderStyle.FixedSingle;
            searchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            searchTextBox.Location = new Point(966, 30);
            searchTextBox.Name = "searchTextBox";
            searchTextBox.PlaceholderText = "ابحث عن منتج...";
            searchTextBox.Size = new Size(169, 30);
            searchTextBox.TabIndex = 1;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearch.ForeColor = Color.FromArgb(52, 73, 94);
            lblSearch.Location = new Point(1141, 33);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(47, 23);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "بحث:";
            // 
            // productsGridView
            // 
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.BackgroundColor = Color.FromArgb(236, 240, 241);
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productsGridView.Location = new Point(10, 100);
            productsGridView.Margin = new Padding(3, 4, 3, 4);
            productsGridView.MultiSelect = false;
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.RowTemplate.Height = 35;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.Size = new Size(1394, 550);
            productsGridView.TabIndex = 0;
            // 
            // totalProductsLabel
            // 
            totalProductsLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            totalProductsLabel.AutoSize = true;
            totalProductsLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            totalProductsLabel.ForeColor = Color.FromArgb(52, 73, 94);
            totalProductsLabel.Location = new Point(1232, 622);
            totalProductsLabel.Name = "totalProductsLabel";
            totalProductsLabel.Size = new Size(172, 28);
            totalProductsLabel.TabIndex = 1;
            totalProductsLabel.Text = "إجمالي المنتجات: 0";
            // 
            // btnAddProduct
            // 
            btnAddProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnAddProduct.BackColor = Color.FromArgb(46, 204, 113);
            btnAddProduct.FlatAppearance.BorderSize = 0;
            btnAddProduct.FlatStyle = FlatStyle.Flat;
            btnAddProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddProduct.ForeColor = Color.White;
            btnAddProduct.Location = new Point(10, 606);
            btnAddProduct.Margin = new Padding(3, 4, 3, 4);
            btnAddProduct.Name = "btnAddProduct";
            btnAddProduct.Size = new Size(140, 40);
            btnAddProduct.TabIndex = 2;
            btnAddProduct.Text = "إضافة منتج جديد";
            btnAddProduct.UseVisualStyleBackColor = false;
            btnAddProduct.Click += btnAddProduct_Click;
            // 
            // btnEditProduct
            // 
            btnEditProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnEditProduct.BackColor = Color.FromArgb(52, 152, 219);
            btnEditProduct.FlatAppearance.BorderSize = 0;
            btnEditProduct.FlatStyle = FlatStyle.Flat;
            btnEditProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditProduct.ForeColor = Color.White;
            btnEditProduct.Location = new Point(156, 606);
            btnEditProduct.Margin = new Padding(3, 4, 3, 4);
            btnEditProduct.Name = "btnEditProduct";
            btnEditProduct.Size = new Size(140, 40);
            btnEditProduct.TabIndex = 3;
            btnEditProduct.Text = "تعديل المنتج";
            btnEditProduct.UseVisualStyleBackColor = false;
            btnEditProduct.Click += btnEditProduct_Click;
            // 
            // btnDeleteProduct
            // 
            btnDeleteProduct.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnDeleteProduct.BackColor = Color.FromArgb(231, 76, 60);
            btnDeleteProduct.FlatAppearance.BorderSize = 0;
            btnDeleteProduct.FlatStyle = FlatStyle.Flat;
            btnDeleteProduct.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDeleteProduct.ForeColor = Color.White;
            btnDeleteProduct.Location = new Point(302, 606);
            btnDeleteProduct.Margin = new Padding(3, 4, 3, 4);
            btnDeleteProduct.Name = "btnDeleteProduct";
            btnDeleteProduct.Size = new Size(140, 40);
            btnDeleteProduct.TabIndex = 4;
            btnDeleteProduct.Text = "حذف المنتج";
            btnDeleteProduct.UseVisualStyleBackColor = false;
            btnDeleteProduct.Click += btnDeleteProduct_Click;
            // 
            // paginationPanel
            // 
            paginationPanel.Controls.Add(btnFirst);
            paginationPanel.Controls.Add(btnPrev);
            paginationPanel.Controls.Add(btnNext);
            paginationPanel.Controls.Add(btnLast);
            paginationPanel.Controls.Add(lblPageInfo);
            paginationPanel.Location = new Point(312, 668);
            paginationPanel.Name = "paginationPanel";
            paginationPanel.Size = new Size(538, 40);
            paginationPanel.TabIndex = 10;
            // 
            // btnFirst
            // 
            btnFirst.BackColor = Color.FromArgb(52, 152, 219);
            btnFirst.FlatAppearance.BorderSize = 0;
            btnFirst.FlatStyle = FlatStyle.Flat;
            btnFirst.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFirst.ForeColor = Color.White;
            btnFirst.Location = new Point(455, 5);
            btnFirst.Name = "btnFirst";
            btnFirst.Size = new Size(80, 30);
            btnFirst.TabIndex = 0;
            btnFirst.Text = "الأول";
            btnFirst.UseVisualStyleBackColor = false;
            // 
            // btnPrev
            // 
            btnPrev.BackColor = Color.FromArgb(52, 152, 219);
            btnPrev.FlatAppearance.BorderSize = 0;
            btnPrev.FlatStyle = FlatStyle.Flat;
            btnPrev.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPrev.ForeColor = Color.White;
            btnPrev.Location = new Point(359, 5);
            btnPrev.Name = "btnPrev";
            btnPrev.Size = new Size(80, 30);
            btnPrev.TabIndex = 1;
            btnPrev.Text = "السابق";
            btnPrev.UseVisualStyleBackColor = false;
            // 
            // btnNext
            // 
            btnNext.BackColor = Color.FromArgb(52, 152, 219);
            btnNext.FlatAppearance.BorderSize = 0;
            btnNext.FlatStyle = FlatStyle.Flat;
            btnNext.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNext.ForeColor = Color.White;
            btnNext.Location = new Point(112, 5);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(80, 30);
            btnNext.TabIndex = 2;
            btnNext.Text = "التالي";
            btnNext.UseVisualStyleBackColor = false;
            // 
            // btnLast
            // 
            btnLast.BackColor = Color.FromArgb(52, 152, 219);
            btnLast.FlatAppearance.BorderSize = 0;
            btnLast.FlatStyle = FlatStyle.Flat;
            btnLast.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLast.ForeColor = Color.White;
            btnLast.Location = new Point(14, 5);
            btnLast.Name = "btnLast";
            btnLast.Size = new Size(80, 30);
            btnLast.TabIndex = 3;
            btnLast.Text = "الأخير";
            btnLast.UseVisualStyleBackColor = false;
            // 
            // lblPageInfo
            // 
            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblPageInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPageInfo.Location = new Point(232, 10);
            lblPageInfo.Name = "lblPageInfo";
            lblPageInfo.Size = new Size(98, 20);
            lblPageInfo.TabIndex = 4;
            lblPageInfo.Text = "صفحة 1 من 1";
            // 
            // flowLayoutPanelNoProducts
            // 
            flowLayoutPanelNoProducts.AutoSize = true;
            flowLayoutPanelNoProducts.Controls.Add(lblNoProductsText);
            flowLayoutPanelNoProducts.Controls.Add(btnAddNewProductInline);
            flowLayoutPanelNoProducts.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanelNoProducts.Location = new Point(683, 374);
            flowLayoutPanelNoProducts.Name = "flowLayoutPanelNoProducts";
            flowLayoutPanelNoProducts.Size = new Size(220, 96);
            flowLayoutPanelNoProducts.TabIndex = 11;
            flowLayoutPanelNoProducts.WrapContents = false;
            // 
            // lblNoProductsText
            // 
            lblNoProductsText.AutoSize = true;
            lblNoProductsText.Font = new Font("Segoe UI", 12F);
            lblNoProductsText.ForeColor = Color.DimGray;
            lblNoProductsText.Location = new Point(14, 0);
            lblNoProductsText.Name = "lblNoProductsText";
            lblNoProductsText.Size = new Size(203, 28);
            lblNoProductsText.TabIndex = 0;
            lblNoProductsText.Text = "لا توجد منتجات لعرضها.";
            lblNoProductsText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnAddNewProductInline
            // 
            btnAddNewProductInline.Location = new Point(0, 38);
            btnAddNewProductInline.Margin = new Padding(0, 10, 0, 3);
            btnAddNewProductInline.Name = "btnAddNewProductInline";
            btnAddNewProductInline.Size = new Size(220, 55);
            btnAddNewProductInline.TabIndex = 1;
            btnAddNewProductInline.Text = "إضافة منتج جديد";
            btnAddNewProductInline.UseVisualStyleBackColor = true;
            btnAddNewProductInline.Click += btnAddNewProductInline_Click_1;
            // 
            // ProductsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(1407, 720);
            Controls.Add(flowLayoutPanelNoProducts);
            Controls.Add(paginationPanel);
            Controls.Add(btnDeleteProduct);
            Controls.Add(btnEditProduct);
            Controls.Add(btnAddProduct);
            Controls.Add(totalProductsLabel);
            Controls.Add(productsGridView);
            Controls.Add(filterPanel);
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductsForm";
            Text = "المنتجات";
            Load += ProductsForm_Load;
            filterPanel.ResumeLayout(false);
            filterPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            paginationPanel.ResumeLayout(false);
            paginationPanel.PerformLayout();
            flowLayoutPanelNoProducts.ResumeLayout(false);
            flowLayoutPanelNoProducts.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Panel filterPanel;
        private System.Windows.Forms.DataGridView productsGridView;
        private System.Windows.Forms.Label totalProductsLabel;
        private System.Windows.Forms.ComboBox stockStatusComboBox;
        private System.Windows.Forms.Label lblStockStatus;
        private System.Windows.Forms.TextBox txtMaxPrice;
        private System.Windows.Forms.Label lblPriceRange;
        private System.Windows.Forms.TextBox txtMinPrice;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Panel paginationPanel;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnLast;
        private System.Windows.Forms.Label lblPageInfo;

        private void UpdateStatus(string message)
        {
            if (statusLabel.InvokeRequired)
            {
                statusLabel.Invoke(new Action(() => statusLabel.Text = message));
            }
            else
            {
                statusLabel.Text = message;
            }
        }
        private FlowLayoutPanel flowLayoutPanelNoProducts;
        private Label lblNoProductsText;
        private Button btnAddNewProductInline;
    }
} 