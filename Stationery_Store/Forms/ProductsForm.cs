using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Stationery_Store.Forms
{
    public partial class ProductsForm : BaseForm
    {
        private Context context = new Context();
        private int currentPage = 1;
        private int pageSize = 3;
        private int totalPages = 1;
        private IQueryable<Product> filteredQuery;
        private ToolTip tooltip;
        private Label statusLabel;

        public ProductsForm()
        {
            InitializeComponent();
            // Set RightToLeft properties for Arabic UI
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            InitializeEnhancedUI();
            ConfigureProductGrid();
            LoadCategories();

            stockStatusComboBox.Items.Add(new { Text = "الكل", Value = "All" });
            stockStatusComboBox.Items.Add(new { Text = "متوفر في المخزون", Value = "InStock" });
            stockStatusComboBox.Items.Add(new { Text = "غير متوفر في المخزون", Value = "OutOfStock" });
            stockStatusComboBox.DisplayMember = "Text";
            stockStatusComboBox.ValueMember = "Value";
            stockStatusComboBox.SelectedIndex = 0;

            InitializePaginationControls();
            LoadProducts();

            searchTextBox.TextChanged += SearchTextBox_TextChanged;
            categoryComboBox.SelectedIndexChanged += CategoryComboBox_SelectedIndexChanged;
            txtMinPrice.TextChanged += PriceRange_TextChanged;
            txtMaxPrice.TextChanged += PriceRange_TextChanged;
            stockStatusComboBox.SelectedIndexChanged += StockStatus_SelectedIndexChanged;
            productsGridView.Resize += ProductsGridView_Resize;
            this.Activated += ProductsForm_Activated;
        }

        private void InitializeEnhancedUI()
        {
            // Initialize tooltip
            tooltip = new ToolTip();
            tooltip.AutoPopDelay = 5000;
            tooltip.InitialDelay = 1000;
            tooltip.ReshowDelay = 500;
            tooltip.ShowAlways = true;

            // Create status label
            statusLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 9F, FontStyle.Italic),
                ForeColor = Color.FromArgb(52, 73, 94),
                Location = new Point(10, 10),
                Text = "جاهز للعرض"
            };

            // Add controls to form
            this.Controls.Add(statusLabel);
        }

        private void ProductsForm_Activated(object sender, EventArgs e)
        {
            // Reset filters to default state
            searchTextBox.Text = string.Empty;
            categoryComboBox.SelectedIndex = 0; // Assuming 0 is "جميع الأصناف"
            txtMinPrice.Text = string.Empty;
            txtMaxPrice.Text = string.Empty;
            stockStatusComboBox.SelectedIndex = 0; // Assuming 0 is "الكل"

            // Reset pagination to the first page and show paginated data
            currentPage = 1;

            LoadProducts();
            LoadCategories();
            UpdateStatus("تم إعادة تعيين الفلاتر");
        }

        private void ProductsGridView_Resize(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void ProductsForm_Resize(object sender, EventArgs e)
        {
            CenterPaginationPanel();
        }

        private void InitializePaginationControls()
        {
            paginationPanel.Dock = DockStyle.Bottom;
            paginationPanel.Height = 50; // Increased height for better appearance
            paginationPanel.BackColor = Color.FromArgb(236, 240, 241); // Light gray background
            paginationPanel.Padding = new Padding(10);

            btnFirst.Text = "الأول";
            btnPrev.Text = "السابق";
            btnNext.Text = "التالي";
            btnLast.Text = "الأخير";

            // Enhanced button styling
            foreach (Button btn in new[] { btnFirst, btnPrev, btnNext, btnLast })
            {
                btn.Size = new Size(80, 35);
                btn.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
                btn.BackColor = Color.FromArgb(52, 152, 219);
                btn.ForeColor = Color.White;
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.Cursor = Cursors.Hand;
            }

            lblPageInfo.AutoSize = true;
            lblPageInfo.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblPageInfo.ForeColor = Color.FromArgb(52, 73, 94);
            lblPageInfo.Text = $"صفحة {currentPage} من {totalPages}";

            // Modified pagination button handlers to toggle between paginated and all data
            btnFirst.Click += (s, e) =>
            {
                currentPage = 1;
                LoadProducts();
                UpdateStatus("تم الانتقال للصفحة الأولى");
            };
            btnPrev.Click += (s, e) =>
            {
                if (currentPage > 1)
                {
                    currentPage--;
                }
                LoadProducts();
                UpdateStatus($"تم الانتقال للصفحة {currentPage}");
            };
            btnNext.Click += (s, e) =>
            {
                if (currentPage < totalPages)
                {
                    currentPage++;
                }
                LoadProducts();
                UpdateStatus($"تم الانتقال للصفحة {currentPage}");
            };
            btnLast.Click += (s, e) =>
            {
                currentPage = totalPages;
                LoadProducts();
                UpdateStatus($"تم الانتقال للصفحة الأخيرة");
            };
        }

        private void ConfigureProductGrid()
        {
            productsGridView.Columns.Clear();
            productsGridView.AutoGenerateColumns = false;

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "ID",
                HeaderText = "الرقم",
                DataPropertyName = "ID",
                Width = 60,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Name",
                HeaderText = "الاسم",
                DataPropertyName = "Name",
                Width = 180,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Description",
                HeaderText = "الوصف",
                DataPropertyName = "Description",
                Width = 250,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Price",
                HeaderText = "السعر",
                DataPropertyName = "Price",
                Width = 120,
                ReadOnly = true,
                DefaultCellStyle = new DataGridViewCellStyle { Format = "N2" }
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "Quantity",
                HeaderText = "الكمية",
                DataPropertyName = "Quantity",
                Width = 100,
                ReadOnly = true
            });

            productsGridView.Columns.Add(new DataGridViewTextBoxColumn
            {
                Name = "CategoryName",
                HeaderText = "الأصناف",
                DataPropertyName = "CategoryName",
                Width = 120,
                ReadOnly = true
            });

            // Enhanced grid styling
            productsGridView.EnableHeadersVisualStyles = false;
            productsGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Dark blue
            productsGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            productsGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            productsGridView.ColumnHeadersHeight = 45;
            productsGridView.RowTemplate.Height = 40;
            productsGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(248, 249, 250);
            productsGridView.DefaultCellStyle.Font = new Font("Segoe UI", 9F);
            productsGridView.DefaultCellStyle.SelectionBackColor = Color.FromArgb(52, 152, 219);
            productsGridView.DefaultCellStyle.SelectionForeColor = Color.White;
            productsGridView.GridColor = Color.FromArgb(189, 195, 199);
            productsGridView.BorderStyle = BorderStyle.None;
            productsGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            productsGridView.RowHeadersVisible = false;
            productsGridView.AllowUserToResizeRows = false;
            productsGridView.AllowUserToAddRows = false;
            productsGridView.AllowUserToDeleteRows = false;
            productsGridView.ReadOnly = true;
            productsGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            productsGridView.MultiSelect = false;
            productsGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            productsGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;

            productsGridView.CellFormatting += ProductsGridView_CellFormatting;

            // Add selection changed event for better feedback
            productsGridView.SelectionChanged += ProductsGridView_SelectionChanged;
        }

        private void LoadProducts()
        {
            try
            {
                UpdateStatus("جاري تحميل البيانات...");

                context?.Dispose();
                context = new Context();

                // First, check if there are any products at all in the database
                bool hasAnyProducts = context.Products.Any();

                if (!hasAnyProducts)
                {
                    // No products exist in the database at all
                    filterPanel.Visible = false;
                    productsGridView.Visible = false;
                    totalProductsLabel.Visible = false;
                    btnAddProduct.Visible = false;
                    btnEditProduct.Visible = false;
                    btnDeleteProduct.Visible = false;
                    paginationPanel.Visible = false;

                    flowLayoutPanelNoProducts.Visible = true;

                    // Style the label and button for better appearance
                    lblNoProductsText.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
                    lblNoProductsText.ForeColor = Color.FromArgb(149, 165, 166);
                    lblNoProductsText.TextAlign = ContentAlignment.MiddleCenter;
                    btnAddNewProductInline.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
                    btnAddNewProductInline.BackColor = Color.FromArgb(52, 152, 219);
                    btnAddNewProductInline.ForeColor = Color.White;
                    btnAddNewProductInline.FlatStyle = FlatStyle.Flat;
                    btnAddNewProductInline.FlatAppearance.BorderSize = 0;
                    btnAddNewProductInline.Size = new Size(220, 50);
                    btnAddNewProductInline.TextAlign = ContentAlignment.MiddleCenter;

                    UpdateStatus("لا توجد منتجات في قاعدة البيانات");
                    return;
                }
                else
                {
                    flowLayoutPanelNoProducts.Visible = false;
                }

                // There are products in the database, now apply filters
                filteredQuery = GetFilteredQuery();

                var allFilteredProducts = filteredQuery.ToList();
                long totalItems = allFilteredProducts.LongCount();

                List<object> products;

                if (totalItems == 0)
                {
                    // No products match the current filters, but there are products in the database
                    products = new List<object>();
                    totalPages = 1;
                    currentPage = 1;

                    // Show empty grid with filters still visible
                    productsGridView.Visible = true;
                    totalProductsLabel.Visible = true;
                    filterPanel.Visible = true;
                    btnAddProduct.Visible = true;
                    btnEditProduct.Visible = true;
                    btnDeleteProduct.Visible = true;
                    paginationPanel.Visible = true;

                    productsGridView.DataSource = null;
                    productsGridView.DataSource = products;
                    productsGridView.Refresh();

                    UpdateTotalProductsLabel(totalItems);
                    UpdatePaginationControls();
                    UpdateStatus("لا توجد منتجات تطابق الفلاتر المحددة");
                }
                else
                {
                    // Show paginated data (3 items per page)
                    if (productsGridView.RowTemplate.Height > 0 && productsGridView.Height > 0)
                    {
                        pageSize = productsGridView.Height / productsGridView.RowTemplate.Height;
                    }
                    else
                    {
                        pageSize = 3; // Default to 3 items per page
                    }
                    if (pageSize <= 0) pageSize = 1;

                    // Calculate totalPages using long to avoid intermediate overflow
                    long calculatedTotalPages = (long)Math.Ceiling((double)totalItems / pageSize);

                    // Assign to totalPages, capping at int.MaxValue if calculated value is too large
                    if (calculatedTotalPages > int.MaxValue)
                    {
                        totalPages = int.MaxValue;
                    }
                    else
                    {
                        totalPages = (int)calculatedTotalPages;
                    }

                    if (currentPage > totalPages)
                        currentPage = totalPages;
                    if (currentPage < 1)
                        currentPage = 1;

                    products = allFilteredProducts
                        .Skip((currentPage - 1) * pageSize)
                        .Take(pageSize)
                        .Select(p => new
                        {
                            p.ID,
                            p.Name,
                            p.Description,
                            p.Price,
                            p.Quantity,
                            CategoryName = p.Category == null ? "غير مصنف" : p.Category.Name
                        })
                        .ToList<object>();

                    UpdateStatus($"الصفحة {currentPage} من {totalPages} - إجمالي {totalItems} منتج");
                }

                if (products.Any())
                {
                    productsGridView.Visible = true;
                    totalProductsLabel.Visible = true;
                    filterPanel.Visible = true;
                    btnAddProduct.Visible = true;
                    btnEditProduct.Visible = true;
                    btnDeleteProduct.Visible = true;
                    paginationPanel.Visible = true;

                    productsGridView.DataSource = null;
                    productsGridView.DataSource = products;
                    productsGridView.Refresh();

                    // Update total label to show total filtered products count
                    UpdateTotalProductsLabel(totalItems);
                    UpdatePaginationControls();

                    // Clear selection after loading
                    productsGridView.ClearSelection();
                }
                else
                {
                    // This should not happen now since we handle empty results above
                    // But keeping it as a fallback
                    productsGridView.Visible = true;
                    totalProductsLabel.Visible = true;
                    filterPanel.Visible = true;
                    btnAddProduct.Visible = true;
                    btnEditProduct.Visible = true;
                    btnDeleteProduct.Visible = true;
                    paginationPanel.Visible = true;

                    productsGridView.DataSource = null;
                    productsGridView.DataSource = products;
                    productsGridView.Refresh();

                    UpdateTotalProductsLabel(totalItems);
                    UpdatePaginationControls();
                    UpdateStatus("لا توجد منتجات لعرضها");
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"حدث خطأ أثناء تحميل البيانات: {ex.Message}");
                MessageBox.Show($"حدث خطأ أثناء تحميل البيانات:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IQueryable<Product> GetFilteredQuery()
        {
            var searchTerm = searchTextBox.Text.Trim().ToLower();
            var selectedCategory = categoryComboBox.SelectedItem;
            string minPriceText = txtMinPrice.Text.Trim();
            string maxPriceText = txtMaxPrice.Text.Trim();
            string stockStatusValue = (stockStatusComboBox.SelectedItem as dynamic)?.Value ?? "All";

            double minPrice = 0;
            double maxPrice = double.MaxValue;

            if (!string.IsNullOrEmpty(minPriceText) && double.TryParse(minPriceText, out double parsedMinPrice))
            {
                minPrice = parsedMinPrice;
            }

            if (!string.IsNullOrEmpty(maxPriceText) && double.TryParse(maxPriceText, out double parsedMaxPrice))
            {
                maxPrice = parsedMaxPrice;
            }

            var query = context.Products.Include(p => p.Category).AsQueryable();

            // Apply category filter
            if (selectedCategory != null)
            {
                int selectedCategoryId = 0;
                dynamic item = selectedCategory;
                if (item.ID != null)
                {
                    selectedCategoryId = (int)item.ID;
                }

                if (selectedCategoryId != 0)
                {
                    query = query.Where(p => p.CategoryId == selectedCategoryId);
                }
            }

            // Apply search filter
            if (!string.IsNullOrEmpty(searchTerm))
            {
                query = query.Where(p => p.Name.ToLower().Contains(searchTerm) ||
                                       p.Description.ToLower().Contains(searchTerm));
            }

            // Apply price range filter
            query = query.Where(p => (double)p.Price >= minPrice && (double)p.Price <= maxPrice);

            // Apply stock status filter
            if (stockStatusValue == "InStock")
            {
                query = query.Where(p => p.Quantity > 0);
            }
            else if (stockStatusValue == "OutOfStock")
            {
                query = query.Where(p => p.Quantity <= 0);
            }

            return query;
        }

        private void UpdatePaginationControls()
        {
            lblPageInfo.Text = $"صفحة {currentPage} من {totalPages}";

            btnFirst.Enabled = currentPage > 1;
            btnPrev.Enabled = currentPage > 1;
            btnNext.Enabled = currentPage < totalPages;
            btnLast.Enabled = currentPage < totalPages;
        }

        private void LoadCategories()
        {
            var categories = context.Categories.ToList();
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.Add(new { ID = 0, Name = "جميع الأصناف" });
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";

            foreach (var category in categories)
            {
                categoryComboBox.Items.Add(category);
            }

            categoryComboBox.SelectedIndex = 0;
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void CategoryComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void PriceRange_TextChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void StockStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterProducts();
        }

        private void FilterProducts()
        {
            try
            {
                UpdateStatus("جاري تطبيق الفلاتر...");

                // Reset to paginated view when filtering
                currentPage = 1;

                // Use the same logic as LoadProducts for consistency
                LoadProducts();

                UpdateStatus("تم تطبيق الفلاتر بنجاح");
            }
            catch (Exception ex)
            {
                UpdateStatus($"حدث خطأ أثناء تطبيق الفلاتر: {ex.Message}");
                MessageBox.Show($"حدث خطأ أثناء تطبيق الفلاتر:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateTotalProductsLabel(long count)
        {
            totalProductsLabel.Text = $"إجمالي المنتجات: {count:N0}";
            totalProductsLabel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            totalProductsLabel.ForeColor = Color.FromArgb(52, 73, 94);
        }

        private void ProductsGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (productsGridView.Columns[e.ColumnIndex].DataPropertyName == "Quantity" && e.RowIndex >= 0)
            {
                var product = productsGridView.Rows[e.RowIndex].DataBoundItem;
                if (product != null)
                {
                    var quantityProperty = product.GetType().GetProperty("Quantity");
                    if (quantityProperty != null)
                    {
                        int quantity = (int)quantityProperty.GetValue(product);
                        if (quantity > 0)
                        {
                            e.Value = quantity.ToString();
                            e.CellStyle.ForeColor = Color.Green;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                        else
                        {
                            e.Value = "غير متوفر";
                            e.CellStyle.ForeColor = Color.Red;
                            e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        }
                        e.FormattingApplied = true;
                    }
                }
            }
            else if (productsGridView.Columns[e.ColumnIndex].DataPropertyName == "Price" && e.RowIndex >= 0)
            {
                var product = productsGridView.Rows[e.RowIndex].DataBoundItem;
                if (product != null)
                {
                    var priceProperty = product.GetType().GetProperty("Price");
                    if (priceProperty != null)
                    {
                        var priceValue = priceProperty.GetValue(product);
                        decimal price = Convert.ToDecimal(priceValue);
                        e.Value = price.ToString("N2") + " ج.م";
                        e.CellStyle.ForeColor = Color.FromArgb(41, 128, 185);
                        e.CellStyle.Font = new Font(e.CellStyle.Font, FontStyle.Bold);
                        e.FormattingApplied = true;
                    }
                }
            }
            else if (productsGridView.Columns[e.ColumnIndex].DataPropertyName == "CategoryName" && e.RowIndex >= 0)
            {
                var product = productsGridView.Rows[e.RowIndex].DataBoundItem;
                if (product != null)
                {
                    var categoryNameProperty = product.GetType().GetProperty("CategoryName");
                    if (categoryNameProperty != null)
                    {
                        e.Value = categoryNameProperty.GetValue(product);
                        e.CellStyle.ForeColor = Color.FromArgb(155, 89, 182);
                        e.FormattingApplied = true;
                    }
                }
            }
        }

        private void lblPriceRange_Click(object sender, EventArgs e)
        {

        }

        private void ProductsForm_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            CenterPaginationPanel();

            // Add keyboard shortcuts
            this.KeyPreview = true;
            this.KeyDown += ProductsForm_KeyDown;

            // Set focus to search box for better UX
            searchTextBox.Focus();
        }

        private void ProductsForm_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F5:
                    // Refresh data
                    LoadProducts();
                    e.Handled = true;
                    break;
                case Keys.Add:
                case Keys.Oemplus:
                    // Next page
                    if (currentPage < totalPages)
                    {
                        currentPage++;
                        LoadProducts();
                    }
                    e.Handled = true;
                    break;
                case Keys.Subtract:
                case Keys.OemMinus:
                    // Previous page
                    if (currentPage > 1)
                    {
                        currentPage--;
                        LoadProducts();
                    }
                    e.Handled = true;
                    break;
                case Keys.Home:
                    // First page
                    currentPage = 1;
                    LoadProducts();
                    e.Handled = true;
                    break;
                case Keys.End:
                    // Last page
                    currentPage = totalPages;
                    LoadProducts();
                    e.Handled = true;
                    break;
            }
        }

        private void CenterPaginationPanel()
        {
            int x = (this.ClientSize.Width - paginationPanel.Width) / 2;
            paginationPanel.Location = new Point(x, paginationPanel.Location.Y);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            btnAddProduct.Enabled = false;
            try
            {
                UpdateStatus("جاري فتح نافذة إضافة منتج جديد...");

                var multiProductForm = new MultiProductForm();
                multiProductForm.FormClosed += (s, args) =>
                {
                    btnAddProduct.Enabled = true;
                    LoadProducts();
                    UpdateStatus("تم إغلاق نافذة إضافة المنتجات");
                };
                multiProductForm.ShowDialog();
            }
            catch (Exception ex)
            {
                btnAddProduct.Enabled = true;
                UpdateStatus($"حدث خطأ أثناء فتح نافذة إضافة المنتج: {ex.Message}");
                MessageBox.Show($"حدث خطأ أثناء فتح نافذة إضافة المنتج:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count == 0)
            {
                UpdateStatus("يرجى تحديد منتج للتعديل");
                MessageBox.Show("يرجى تحديد منتج للتعديل", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnEditProduct.Enabled = false;
            try
            {
                UpdateStatus("جاري فتح نافذة تعديل المنتج...");

                var selectedRow = productsGridView.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ID"].Value;

                var productDetailsForm = new ProductDetailsForm(productId);
                productDetailsForm.FormClosed += (s, args) =>
                {
                    btnEditProduct.Enabled = true;
                    LoadProducts();
                    UpdateStatus("تم إغلاق نافذة تعديل المنتج");
                };
                productDetailsForm.ShowDialog();
            }
            catch (Exception ex)
            {
                btnEditProduct.Enabled = true;
                UpdateStatus($"حدث خطأ أثناء فتح نافذة تعديل المنتج: {ex.Message}");
                MessageBox.Show($"حدث خطأ أثناء فتح نافذة تعديل المنتج:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            if (productsGridView.SelectedRows.Count == 0)
            {
                UpdateStatus("يرجى تحديد منتج للحذف");
                MessageBox.Show("يرجى تحديد منتج للحذف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            btnDeleteProduct.Enabled = false;
            try
            {
                UpdateStatus("جاري حذف المنتج...");

                var selectedRow = productsGridView.SelectedRows[0];
                int productId = (int)selectedRow.Cells["ID"].Value;
                string productName = selectedRow.Cells["Name"].Value.ToString();

                var result = MessageBox.Show($"هل أنت متأكد من حذف المنتج '{productName}'؟", "تأكيد الحذف",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    var product = context.Products.Find(productId);
                    if (product != null)
                    {
                        context.Products.Remove(product);
                        context.SaveChanges();
                        LoadProducts();
                        UpdateStatus($"تم حذف المنتج '{productName}' بنجاح");

                        using (var msgBox = new CustomMessageBoxForm($"تم حذف المنتج '{productName}' بنجاح"))
                        {
                            msgBox.ShowDialog();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                UpdateStatus($"حدث خطأ أثناء حذف المنتج: {ex.Message}");
                MessageBox.Show($"حدث خطأ أثناء حذف المنتج:\n{ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnDeleteProduct.Enabled = true;
            }
        }

        private void btnAddNewProductInline_Click(object sender, EventArgs e)
        {
            btnAddProduct.PerformClick();
        }

        private void ProductsGridView_SelectionChanged(object sender, EventArgs e)
        {
            // Remove status update on selection
            // if (productsGridView.SelectedRows.Count > 0)
            // {
            //     var selectedRow = productsGridView.SelectedRows[0];
            //     var productName = selectedRow.Cells["Name"].Value?.ToString() ?? "";
            //     UpdateStatus($"تم تحديد المنتج: {productName}");
            // }
        }

        private void btnAddNewProductInline_Click_1(object sender, EventArgs e)
        {
            btnAddProduct_Click(sender, e);

        }
    }
} 