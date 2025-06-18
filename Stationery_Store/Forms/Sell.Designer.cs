namespace Stationery_Store.Forms
{
    partial class SellForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            AddBtn = new Button();
            productsGridView = new DataGridView();
            SearchTextBox = new TextBox();
            label1 = new Label();
            SellGridView = new DataGridView();
            SellBtn = new Button();
            TotalPrice = new Label();
            TotalQuantity = new Label();
            RemoveBtn = new Button();
            label2 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)productsGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SellGridView).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // AddBtn
            // 
            AddBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113))))); // Emerald Green
            AddBtn.FlatAppearance.BorderSize = 0;
            AddBtn.FlatStyle = FlatStyle.Flat;
            AddBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBtn.ForeColor = System.Drawing.Color.White;
            AddBtn.Location = new Point(11, 482);
            AddBtn.Name = "AddBtn";
            AddBtn.Size = new Size(250, 50);
            AddBtn.TabIndex = 2;
            AddBtn.Text = "إضافة إلى الفاتورة";
            AddBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            AddBtn.UseVisualStyleBackColor = false;
            AddBtn.Click += AddBtn_Click;
            // 
            // productsGridView
            // 
            productsGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productsGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            productsGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219))))); // Peter River
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            productsGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            productsGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            productsGridView.DefaultCellStyle = dataGridViewCellStyle2;
            productsGridView.Location = new Point(11, 150);
            productsGridView.Name = "productsGridView";
            productsGridView.ReadOnly = true;
            productsGridView.RightToLeft = RightToLeft.Yes;
            productsGridView.RowHeadersWidth = 51;
            productsGridView.RowTemplate.Height = 35;
            productsGridView.Size = new Size(540, 264);
            productsGridView.TabIndex = 3;
            // 
            // SearchTextBox
            // 
            SearchTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            SearchTextBox.BorderStyle = BorderStyle.FixedSingle;
            SearchTextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            SearchTextBox.Location = new Point(11, 100);
            SearchTextBox.Name = "SearchTextBox";
            SearchTextBox.PlaceholderText = "ابحث عن المنتج...";
            SearchTextBox.Size = new Size(540, 30);
            SearchTextBox.TabIndex = 0;
            SearchTextBox.TextAlign = HorizontalAlignment.Right;
            SearchTextBox.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94))))); // Dark blue/gray
            label1.Location = new Point(140, 50);
            label1.Name = "label1";
            label1.Size = new Size(160, 28);
            label1.TabIndex = 1;
            label1.Text = "ابحث بأسم المنتج:";
            // 
            // SellGridView
            // 
            SellGridView.AllowUserToAddRows = false;
            SellGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Right;
            SellGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            SellGridView.BorderStyle = BorderStyle.FixedSingle;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            SellGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            SellGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            SellGridView.DefaultCellStyle = dataGridViewCellStyle2;
            SellGridView.Location = new Point(557, 98);
            SellGridView.Margin = new Padding(3, 4, 3, 4);
            SellGridView.Name = "SellGridView";
            SellGridView.RightToLeft = RightToLeft.Yes;
            SellGridView.RowHeadersWidth = 51;
            SellGridView.RowTemplate.Height = 35;
            SellGridView.Size = new Size(504, 313);
            SellGridView.TabIndex = 7;
            // 
            // SellBtn
            // 
            SellBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SellBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113))))); // Emerald Green
            SellBtn.FlatAppearance.BorderSize = 0;
            SellBtn.FlatStyle = FlatStyle.Flat;
            SellBtn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SellBtn.ForeColor = System.Drawing.Color.White;
            SellBtn.Location = new Point(811, 482);
            SellBtn.Name = "SellBtn";
            SellBtn.Size = new Size(250, 50);
            SellBtn.TabIndex = 4;
            SellBtn.Text = "إتمام البيع";
            SellBtn.TextImageRelation = TextImageRelation.ImageAboveText;
            SellBtn.UseVisualStyleBackColor = false;
            SellBtn.Click += SellBtn_Click;
            // 
            // TotalPrice
            // 
            TotalPrice.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalPrice.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            TotalPrice.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            TotalPrice.Location = new Point(781, 447);
            TotalPrice.Name = "TotalPrice";
            TotalPrice.RightToLeft = RightToLeft.Yes;
            TotalPrice.Size = new Size(280, 23);
            TotalPrice.TabIndex = 6;
            TotalPrice.Text = "الإجمالي: 0.00 جنيه"; // Added label text
            TotalPrice.TextAlign = ContentAlignment.MiddleRight;
            // 
            // TotalQuantity
            // 
            TotalQuantity.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            TotalQuantity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            TotalQuantity.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TotalQuantity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            TotalQuantity.Location = new Point(781, 418);
            TotalQuantity.Name = "TotalQuantity";
            TotalQuantity.RightToLeft = RightToLeft.Yes;
            TotalQuantity.Size = new Size(280, 23);
            TotalQuantity.TabIndex = 8;
            TotalQuantity.Text = "الكمية الإجمالية: 0"; // Added label text
            TotalQuantity.TextAlign = ContentAlignment.MiddleRight;
            // 
            // RemoveBtn
            // 
            RemoveBtn.Anchor = AnchorStyles.Bottom | AnchorStyles.Left; // Anchor to left
            RemoveBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60))))); // Alizarin Red
            RemoveBtn.FlatAppearance.BorderSize = 0;
            RemoveBtn.FlatStyle = FlatStyle.Flat;
            RemoveBtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RemoveBtn.ForeColor = System.Drawing.Color.White;
            RemoveBtn.Location = new Point(270, 482);
            RemoveBtn.Name = "RemoveBtn";
            RemoveBtn.Size = new Size(250, 50);
            RemoveBtn.TabIndex = 9;
            RemoveBtn.Text = "إزالة من الفاتورة";
            RemoveBtn.UseVisualStyleBackColor = false;
            RemoveBtn.Click += RemoveBtn_Click_1;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 19.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(73)))), ((int)(((byte)(94)))));
            label2.Location = new Point(939, 36);
            label2.Name = "label2";
            label2.Size = new Size(122, 45);
            label2.TabIndex = 10;
            label2.Text = "الفاتورة";
            // 
            // panel1
            // 
            panel1.AutoSize = true;
            panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            panel1.Controls.Add(label2);
            panel1.Controls.Add(RemoveBtn);
            panel1.Controls.Add(TotalQuantity);
            panel1.Controls.Add(TotalPrice);
            panel1.Controls.Add(SellBtn);
            panel1.Controls.Add(SellGridView);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(SearchTextBox);
            panel1.Controls.Add(productsGridView);
            panel1.Controls.Add(AddBtn);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(1070, 550); // Adjusted ClientSize
            panel1.TabIndex = 4;
            // 
            // SellForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241))))); // Clouds
            ClientSize = new Size(1070, 550); // Adjusted ClientSize
            ControlBox = false;
            Controls.Add(panel1);
            Name = "SellForm";
            RightToLeftLayout = true;
            SizeGripStyle = SizeGripStyle.Show;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "البيع";
            Load += SellForm_Load;
            ((System.ComponentModel.ISupportInitialize)productsGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)SellGridView).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddBtn;
        private DataGridView productsGridView;
        private TextBox SearchTextBox;
        private Label label1;
        private DataGridView SellGridView;
        private Button SellBtn;
        private Label TotalPrice;
        private Label TotalQuantity;
        private Button RemoveBtn;
        private Label label2;
        private Panel panel1;
    }
}
