using Microsoft.Data.Sqlite;
using Stationery_Store.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stationery_Store.Forms
{
    public partial class HomeForm : BaseForm
    {
        CategoryForm categoryForm;
        SellForm sellForm;
        ProductsForm productsForm;
        Report reportForm;
        UsersForm usersForm;
        private Context dbContext;

        private const int CollapsedSidebarWidth = 66;
        private const int ExpandedSidebarWidth = 187;
        private bool sidebarExpand = true; // Initial state: sidebar is expanded

        private Form lastActiveChild;
        private Role userRole;

        // Statistics Labels
        private Label lblTotalProducts;
        private Label lblTotalCategories;
        private Label lblTotalSales;
        private Label lblTotalRevenue;
        private Label lblLowStockItems;
        private Label lblMostSoldProduct;
        private Panel statisticsPanel;

        private Panel userWelcomePanel;

        public HomeForm(Role role)
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            dbContext = new Context();

            // Set RightToLeft properties for Arabic UI (handled by BaseForm now, but kept for clarity)
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;

            this.userRole = role;

            this.Shown += HomeForm_Shown;

            // These properties are now set in BaseForm, but keeping them here for understanding
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = true;
            this.SizeGripStyle = SizeGripStyle.Hide;

            this.WindowState = FormWindowState.Maximized;

            if (userRole == Role.Admin)
            {
                InitializeStatisticsPanel();
                LoadStatistics();
            }
            else
            {
                InitializeUserWelcomePanel();
            }
        }

        private void InitializeStatisticsPanel()
        {
            statisticsPanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(236, 240, 241),
                Padding = new Padding(20)
            };

            TableLayoutPanel statsTable = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 3,
                RowCount = 2,
                Padding = new Padding(15),
                CellBorderStyle = TableLayoutPanelCellBorderStyle.None
            };

            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            statsTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.33F));
            for (int i = 0; i < 2; i++)
            {
                statsTable.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            }

            lblTotalProducts = new Label();
            lblTotalCategories = new Label();
            lblTotalSales = new Label();
            lblTotalRevenue = new Label();
            lblLowStockItems = new Label();
            lblMostSoldProduct = new Label();

            // We'll add the cards in LoadStatistics to allow dynamic details
            statisticsPanel.Controls.Add(statsTable);
            this.Controls.Add(statisticsPanel);
            statisticsPanel.BringToFront();
        }

        private void InitializeUserWelcomePanel()
        {
            userWelcomePanel = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(236, 240, 241),
                Padding = new Padding(20)
            };

            Label welcomeLabel = new Label
            {
                Text = "مرحباً بك في نظام إدارة المكتبة!",
                Font = new Font("Segoe UI", 22F, FontStyle.Bold),
                ForeColor = Color.FromArgb(41, 128, 185),
                TextAlign = ContentAlignment.TopCenter,
                Dock = DockStyle.Top,
                Height = 60,
                Margin = new Padding(0, 40, 0, 10)
            };

            Label instructionLabel = new Label
            {
                Text = "يمكنك البدء بعملية البيع من القائمة الجانبية أو الضغط على الزر أدناه.",
                Font = new Font("Segoe UI", 13F, FontStyle.Regular),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.TopCenter,
                Dock = DockStyle.Top,
                Height = 40,
                Margin = new Padding(0, 10, 0, 20)
            };

            Button startSellButton = new Button
            {
                Text = "بدء عملية بيع جديدة",
                Font = new Font("Segoe UI", 14F, FontStyle.Bold),
                BackColor = Color.FromArgb(46, 204, 113),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Height = 50,
                Width = 250,
                Cursor = Cursors.Hand,
                Dock = DockStyle.Top,
                Margin = new Padding(0, 30, 0, 0)
            };
            startSellButton.FlatAppearance.BorderSize = 0;
            startSellButton.Click += (s, e) => buttonSell.PerformClick();

            userWelcomePanel.Controls.Add(startSellButton);
            userWelcomePanel.Controls.Add(instructionLabel);
            userWelcomePanel.Controls.Add(welcomeLabel);

            this.Controls.Add(userWelcomePanel);
            userWelcomePanel.BringToFront();
        }

        private Panel CreateStatCard(string title, string icon, Label valueLabel, string details = null, Color? borderColor = null, string tooltipText = null)
        {
            Panel card = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.White,
                Padding = new Padding(15),
                Margin = new Padding(15),
                BorderStyle = BorderStyle.None,
            };

            card.Paint += (s, e) =>
            {
                var g = e.Graphics;
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var shadowBrush = new SolidBrush(Color.FromArgb(30, 0, 0, 0)))
                {
                    g.FillRectangle(shadowBrush, 5, 5, card.Width - 10, card.Height - 10);
                }
                using (var borderPen = new Pen(borderColor ?? Color.FromArgb(220, 220, 220), 3))
                using (var bgBrush = new SolidBrush(card.BackColor))
                {
                    var rect = new Rectangle(0, 0, card.Width - 1, card.Height - 1);
                    g.FillRectangle(bgBrush, rect);
                    g.DrawRectangle(borderPen, rect);
                }
            };

            Label iconLabel = new Label
            {
                Text = icon,
                Font = new Font("Segoe UI", 28F, FontStyle.Bold),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 60
            };

            Label titleLabel = new Label
            {
                Text = title,
                Font = new Font("Segoe UI", 13F, FontStyle.Bold),
                ForeColor = Color.FromArgb(52, 73, 94),
                TextAlign = ContentAlignment.MiddleCenter,
                Dock = DockStyle.Top,
                Height = 32
            };

            valueLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            valueLabel.ForeColor = Color.FromArgb(41, 128, 185);
            valueLabel.TextAlign = ContentAlignment.MiddleCenter;
            valueLabel.Dock = DockStyle.Top;
            valueLabel.Padding = new Padding(5);
            valueLabel.Height = 40;

            Label detailsLabel = null;
            if (!string.IsNullOrEmpty(details))
            {
                detailsLabel = new Label
                {
                    Text = details,
                    Font = new Font("Segoe UI", 10F, FontStyle.Regular),
                    ForeColor = Color.FromArgb(52, 73, 94),
                    TextAlign = ContentAlignment.TopCenter,
                    Dock = DockStyle.Fill,
                    AutoSize = false,
                    Padding = new Padding(2),
                };
            }

            card.MouseEnter += (s, e) =>
            {
                card.BackColor = Color.FromArgb(245, 245, 245);
            };
            card.MouseLeave += (s, e) =>
            {
                card.BackColor = Color.White;
            };

            if (!string.IsNullOrEmpty(tooltipText))
            {
                ToolTip tip = new ToolTip();
                tip.SetToolTip(card, tooltipText);
            }

            card.Controls.Add(detailsLabel ?? new Label { Height = 10, Dock = DockStyle.Fill });
            card.Controls.Add(valueLabel);
            card.Controls.Add(titleLabel);
            card.Controls.Add(iconLabel);

            return card;
        }

        private void LoadStatistics()
        {
            try
            {
                var statsTable = (TableLayoutPanel)statisticsPanel.Controls[0];
                statsTable.Controls.Clear();

                // Total Products
                int totalProducts = dbContext.Products.Count();
                var productNames = dbContext.Products.Select(p => p.Name).ToList();
                string productDetails = totalProducts > 0 ? string.Join("، ", productNames) : "لا يوجد منتجات";
                lblTotalProducts.Text = totalProducts > 0 ? totalProducts.ToString("N0") : "لا يوجد";
                lblTotalProducts.ForeColor = totalProducts > 0 ? Color.FromArgb(41, 128, 185) : Color.Gray;
                ToolTipService(lblTotalProducts, "عدد جميع المنتجات المسجلة في النظام.");
                statsTable.Controls.Add(CreateStatCard("إجمالي المنتجات", "📦", lblTotalProducts, productDetails), 0, 0);

                // Total Categories
                int totalCategories = dbContext.Categories.Count();
                var categoryNames = dbContext.Categories.Select(c => c.Name).ToList();
                string categoryDetails = totalCategories > 0 ? string.Join("، ", categoryNames) : "لا يوجد فئات";
                lblTotalCategories.Text = totalCategories > 0 ? totalCategories.ToString("N0") : "لا يوجد";
                lblTotalCategories.ForeColor = totalCategories > 0 ? Color.FromArgb(41, 128, 185) : Color.Gray;
                ToolTipService(lblTotalCategories, "عدد جميع الفئات المسجلة في النظام.");
                statsTable.Controls.Add(CreateStatCard("إجمالي الفئات", "📑", lblTotalCategories, categoryDetails), 1, 0);

                // Total Sales and Revenue
                var orders = dbContext.Orders.ToList();
                int totalSales = orders.Sum(o => o.TotalAmount);
                double totalRevenue = orders.Sum(o => o.TotalPrice);
                var salesDetails = orders.Count > 0 ? string.Join("\n", orders.Select(o => $"طلب #{o.ID}: {o.TotalAmount} وحدة")) : "لا يوجد مبيعات";
                lblTotalSales.Text = totalSales > 0 ? totalSales.ToString("N0") : "لا يوجد";
                lblTotalSales.ForeColor = totalSales > 0 ? Color.FromArgb(39, 174, 96) : Color.Gray;
                ToolTipService(lblTotalSales, "إجمالي عدد المنتجات المباعة.");
                statsTable.Controls.Add(CreateStatCard("إجمالي المبيعات", "💰", lblTotalSales, salesDetails), 2, 0);

                lblTotalRevenue.Text = totalRevenue > 0 ? totalRevenue.ToString("C") : "لا يوجد";
                lblTotalRevenue.ForeColor = totalRevenue > 0 ? Color.FromArgb(39, 174, 96) : Color.Gray;
                ToolTipService(lblTotalRevenue, "إجمالي الإيرادات من جميع المبيعات.");
                statsTable.Controls.Add(CreateStatCard("إجمالي الإيرادات", "💵", lblTotalRevenue, $"{totalRevenue:N2} ج.م"), 0, 1);

                // Low Stock Items (less than 10 items)
                var lowStockProducts = dbContext.Products.Where(p => p.Quantity < 10).Select(p => $"{p.Name} ({p.Quantity})").ToList();
                int lowStockItems = lowStockProducts.Count;
                string lowStockDetails = lowStockItems > 0 ? string.Join("، ", lowStockProducts) : "لا يوجد منتجات منخفضة";
                lblLowStockItems.Text = lowStockItems > 0 ? lowStockItems.ToString("N0") : "0";
                lblLowStockItems.ForeColor = lowStockItems > 0 ? Color.FromArgb(231, 76, 60) : Color.FromArgb(41, 128, 185);
                ToolTipService(lblLowStockItems, "عدد المنتجات التي يقل مخزونها عن 10 وحدات.");
                statsTable.Controls.Add(CreateStatCard("المنتجات منخفضة المخزون", "⚠️", lblLowStockItems, lowStockDetails), 1, 1);

                // Most Sold Product
                var mostSoldProduct = dbContext.Order_Items
                    .GroupBy(oi => oi.ProductName)
                    .Select(g => new { ProductName = g.Key, TotalQuantity = g.Sum(oi => oi.Quantity) })
                    .OrderByDescending(x => x.TotalQuantity)
                    .FirstOrDefault();
                string mostSoldDetails = mostSoldProduct != null ? $"{mostSoldProduct.ProductName}\n({mostSoldProduct.TotalQuantity:N0} وحدة)" : "لا يوجد مبيعات";
                if (mostSoldProduct != null)
                {
                    lblMostSoldProduct.Text = $"{mostSoldProduct.ProductName}\n({mostSoldProduct.TotalQuantity:N0} وحدة)";
                    lblMostSoldProduct.ForeColor = Color.FromArgb(243, 156, 18);
                }
                else
                {
                    lblMostSoldProduct.Text = "لا يوجد مبيعات";
                    lblMostSoldProduct.ForeColor = Color.Gray;
                }
                ToolTipService(lblMostSoldProduct, "المنتج الذي تم بيعه بأكبر كمية.");
                statsTable.Controls.Add(CreateStatCard("المنتج الأكثر مبيعاً", "🏆", lblMostSoldProduct, mostSoldDetails), 2, 1);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"حدث خطأ أثناء تحميل الإحصائيات: {ex.Message}", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToolTipService(Control control, string text)
        {
            ToolTip tip = new ToolTip();
            tip.SetToolTip(control, text);
        }

        private void HomeForm_Shown(object sender, EventArgs e)
        {
            if (userRole != Role.Admin)
            {
                // إخفاء كل الأزرار ما عدا البيع
                buttonCategories.Visible = false;
                buttonProducts.Visible = false;
                buttonReports.Visible = false;
                buttonUsers.Visible = false;
                //BackupBtn.Visible = false;

                // مباشرة عرض شاشة البيع للمستخدم العادي
                buttonSell.PerformClick();
            }
        }

        private void HomeForm_Resize(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                if (child.WindowState != FormWindowState.Maximized)
                {
                    child.WindowState = FormWindowState.Maximized;
                }
            }
            lastActiveChild?.Activate();
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand) // Sidebar is currently expanded, need to collapse
            {
                sidebar.Width -= 27; // Adjust speed as needed
                if (sidebar.Width <= CollapsedSidebarWidth)
                {
                    sidebarTransition.Stop();
                    sidebar.Width = CollapsedSidebarWidth; // Ensure it snaps to exact collapsed width
                }
            }
            else // Sidebar is currently collapsed, need to expand
            {
                sidebar.Width += 27; // Adjust speed as needed
                if (sidebar.Width >= ExpandedSidebarWidth)
                {
                    sidebarTransition.Stop();
                    sidebar.Width = ExpandedSidebarWidth; // Ensure it snaps to exact expanded width
                }
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            // Toggle the sidebar state
            sidebarExpand = !sidebarExpand;
            sidebarTransition.Start();
        }

        private void buttonCategories_Click(object sender, EventArgs e)
        {
            if (statisticsPanel != null)
                statisticsPanel.Visible = false;
            if (categoryForm == null)
            {
                categoryForm = new CategoryForm();
                categoryForm.FormClosed += categoryForm_FormClosed;
                categoryForm.MdiParent = this;
                categoryForm.FormBorderStyle = FormBorderStyle.None;
                categoryForm.Show();
                // Force resize after showing
                categoryForm.WindowState = FormWindowState.Normal;
                categoryForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                categoryForm.Activate();
            }

            lastActiveChild = categoryForm;
        }

        private void categoryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            categoryForm = null;
        }

        private void buttonSell_Click(object sender, EventArgs e)
        {
            if (statisticsPanel != null)
                statisticsPanel.Visible = false;
            if (userWelcomePanel != null)
                userWelcomePanel.Visible = false;
            if (sellForm == null)
            {
                sellForm = new SellForm();
                sellForm.FormClosed += sellForm_FormClosed;
                sellForm.MdiParent = this;
                sellForm.FormBorderStyle = FormBorderStyle.None;
                sellForm.Show();
                sellForm.WindowState = FormWindowState.Normal;
                sellForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                sellForm.Activate();
            }
            lastActiveChild = sellForm;
        }

        private void sellForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            sellForm = null;
        }

        private void buttonProducts_Click(object sender, EventArgs e)
        {
            if (statisticsPanel != null)
                statisticsPanel.Visible = false;
            if (productsForm == null)
            {
                productsForm = new ProductsForm();
                productsForm.FormClosed += productsForm_FormClosed;
                productsForm.MdiParent = this;
                productsForm.FormBorderStyle = FormBorderStyle.None;
                productsForm.Show();
                productsForm.WindowState = FormWindowState.Normal;
                productsForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                productsForm.Activate();
            }
            lastActiveChild = productsForm;
        }
        private void productsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            productsForm = null;
        }

        private void buttonReports_Click(object sender, EventArgs e)
        {
            if (statisticsPanel != null)
                statisticsPanel.Visible = false;
            if (reportForm == null)
            {
                reportForm = new Report();
                reportForm.FormClosed += reportForm_FormClosed;
                reportForm.MdiParent = this;
                reportForm.FormBorderStyle = FormBorderStyle.None;  // Remove borders
                reportForm.Show();
                reportForm.WindowState = FormWindowState.Normal;
                reportForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                reportForm.Activate();
            }
            lastActiveChild = reportForm;
        }

        private void reportForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            reportForm = null;
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            if (statisticsPanel != null)
                statisticsPanel.Visible = false;
            if (usersForm == null)
            {
                usersForm = new UsersForm();
                usersForm.FormClosed += (s, args) => usersForm = null;
                usersForm.MdiParent = this;
                usersForm.FormBorderStyle = FormBorderStyle.None;
                usersForm.Show();
                usersForm.WindowState = FormWindowState.Normal;
                usersForm.WindowState = FormWindowState.Maximized;
            }
            else
            {
                usersForm.Activate();
            }

            lastActiveChild = usersForm;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            foreach (Form child in this.MdiChildren)
            {
                child.Close();
            }

            if (userRole == Role.Admin && statisticsPanel != null)
            {
                statisticsPanel.Visible = true;
                statisticsPanel.BringToFront();
                LoadStatistics();
            }
            else if (userWelcomePanel != null)
            {
                userWelcomePanel.Visible = true;
                userWelcomePanel.BringToFront();
            }
        }
        private void BackupSqliteDatabase(string sourcePath, string destinationPath)
        {
            if (File.Exists(sourcePath))
            {
                File.Copy(sourcePath, destinationPath, true); // true = overwrite if exists
            }
            else
            {
                MessageBox.Show("❌ قاعدة البيانات الأصلية غير موجودة!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BackupBtn_Click(object sender, EventArgs e)
        {
            // Get the path of the executable (base directory)
            string projectBasePath = AppDomain.CurrentDomain.BaseDirectory;

            // Define the backup folder path inside the project directory
            string backupFolder = Path.Combine(projectBasePath, "backup");

            // Create the backup folder if it doesn't exist
            if (!Directory.Exists(backupFolder))
            {
                Directory.CreateDirectory(backupFolder);
            }

            // Define the path of the source database
            string dbPath = Path.Combine(projectBasePath, "Data", "appdata.db");

            // Show Save File Dialog with default path set to the backup folder
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                InitialDirectory = backupFolder,
                Filter = "SQLite Database (*.sqlite)|*.sqlite|All Files (*.*)|*.*",
                FileName = "BackupDatabase.sqlite"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string backupFilePath = saveFileDialog.FileName;
                BackupSqliteDatabase(dbPath, backupFilePath);
                MessageBox.Show("✅ تم إنشاء نسخة احتياطية بنجاح!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            // Any initialization logic for the form when it loads
            // For example, if you want to perform some actions when the form is first shown
        }

        private void HomeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Any cleanup logic when the form is closed
        }

    }
}


