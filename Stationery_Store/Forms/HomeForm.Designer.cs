namespace Stationery_Store.Forms
{
    partial class HomeForm
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            label1 = new Label();
            btnHome = new PictureBox();
            sidebar = new FlowLayoutPanel();
            panel2 = new Panel();
            buttonHome = new Button();
            panel3 = new Panel();
            buttonSell = new Button();
            panel4 = new Panel();
            buttonCategories = new Button();
            panel5 = new Panel();
            buttonProducts = new Button();
            panel6 = new Panel();
            buttonReports = new Button();
            panel7 = new Panel();
            buttonUsers = new Button();
            BackupBtn = new Button();
            sidebarTransition = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).BeginInit();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnHome);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.RightToLeft = RightToLeft.Yes;
            panel1.Size = new Size(925, 50);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(719, 9);
            label1.Name = "label1";
            label1.Size = new Size(131, 31);
            label1.TabIndex = 3;
            label1.Text = "إدارة المكتبة";
            // 
            // btnHome
            // 
            btnHome.Location = new Point(0, 0);
            btnHome.Name = "btnHome";
            btnHome.Size = new Size(66, 50);
            btnHome.SizeMode = PictureBoxSizeMode.StretchImage;
            btnHome.TabIndex = 1;
            btnHome.TabStop = false;
            btnHome.Click += btnHome_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.FromArgb(52, 73, 94);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(panel4);
            sidebar.Controls.Add(panel5);
            sidebar.Controls.Add(panel6);
            sidebar.Controls.Add(panel7);
            sidebar.Controls.Add(BackupBtn);
            sidebar.Dock = DockStyle.Left;
            sidebar.FlowDirection = FlowDirection.TopDown;
            sidebar.Location = new Point(0, 50);
            sidebar.Name = "sidebar";
            sidebar.Padding = new Padding(0, 30, 0, 0);
            sidebar.Size = new Size(191, 507);
            sidebar.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(buttonHome);
            panel2.Location = new Point(4, 33);
            panel2.Name = "panel2";
            panel2.Size = new Size(184, 60);
            panel2.TabIndex = 3;
            // 
            // buttonHome
            // 
            buttonHome.BackColor = Color.FromArgb(52, 73, 94);
            buttonHome.FlatAppearance.BorderSize = 0;
            buttonHome.FlatStyle = FlatStyle.Flat;
            buttonHome.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonHome.ForeColor = Color.White;
            buttonHome.ImageAlign = ContentAlignment.MiddleRight;
            buttonHome.Location = new Point(0, 0);
            buttonHome.Name = "buttonHome";
            buttonHome.Padding = new Padding(10, 0, 0, 0);
            buttonHome.Size = new Size(184, 60);
            buttonHome.TabIndex = 2;
            buttonHome.Text = "الصفحة الرئيسية";
            buttonHome.UseVisualStyleBackColor = false;
            buttonHome.Click += buttonHome_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(buttonSell);
            panel3.Location = new Point(4, 99);
            panel3.Name = "panel3";
            panel3.Size = new Size(184, 60);
            panel3.TabIndex = 4;
            // 
            // buttonSell
            // 
            buttonSell.BackColor = Color.FromArgb(52, 73, 94);
            buttonSell.FlatAppearance.BorderSize = 0;
            buttonSell.FlatStyle = FlatStyle.Flat;
            buttonSell.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSell.ForeColor = Color.White;
            buttonSell.ImageAlign = ContentAlignment.MiddleRight;
            buttonSell.Location = new Point(0, 0);
            buttonSell.Name = "buttonSell";
            buttonSell.Padding = new Padding(10, 0, 0, 0);
            buttonSell.Size = new Size(184, 60);
            buttonSell.TabIndex = 2;
            buttonSell.Text = "البيع";
            buttonSell.UseVisualStyleBackColor = false;
            buttonSell.Click += buttonSell_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(buttonCategories);
            panel4.Location = new Point(4, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(184, 60);
            panel4.TabIndex = 4;
            // 
            // buttonCategories
            // 
            buttonCategories.BackColor = Color.FromArgb(52, 73, 94);
            buttonCategories.FlatAppearance.BorderSize = 0;
            buttonCategories.FlatStyle = FlatStyle.Flat;
            buttonCategories.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonCategories.ForeColor = Color.White;
            buttonCategories.ImageAlign = ContentAlignment.MiddleRight;
            buttonCategories.Location = new Point(0, 0);
            buttonCategories.Name = "buttonCategories";
            buttonCategories.Padding = new Padding(10, 0, 0, 0);
            buttonCategories.Size = new Size(184, 60);
            buttonCategories.TabIndex = 2;
            buttonCategories.Text = "الفئات";
            buttonCategories.UseVisualStyleBackColor = false;
            buttonCategories.Click += buttonCategories_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(buttonProducts);
            panel5.Location = new Point(4, 231);
            panel5.Name = "panel5";
            panel5.Size = new Size(184, 60);
            panel5.TabIndex = 4;
            // 
            // buttonProducts
            // 
            buttonProducts.BackColor = Color.FromArgb(52, 73, 94);
            buttonProducts.FlatAppearance.BorderSize = 0;
            buttonProducts.FlatStyle = FlatStyle.Flat;
            buttonProducts.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonProducts.ForeColor = Color.White;
            buttonProducts.ImageAlign = ContentAlignment.MiddleRight;
            buttonProducts.Location = new Point(0, 0);
            buttonProducts.Name = "buttonProducts";
            buttonProducts.Padding = new Padding(10, 0, 0, 0);
            buttonProducts.Size = new Size(184, 60);
            buttonProducts.TabIndex = 2;
            buttonProducts.Text = "المنتجات";
            buttonProducts.UseVisualStyleBackColor = false;
            buttonProducts.Click += buttonProducts_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(buttonReports);
            panel6.Location = new Point(4, 297);
            panel6.Name = "panel6";
            panel6.Size = new Size(184, 60);
            panel6.TabIndex = 5;
            // 
            // buttonReports
            // 
            buttonReports.BackColor = Color.FromArgb(52, 73, 94);
            buttonReports.FlatAppearance.BorderSize = 0;
            buttonReports.FlatStyle = FlatStyle.Flat;
            buttonReports.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonReports.ForeColor = Color.White;
            buttonReports.ImageAlign = ContentAlignment.MiddleRight;
            buttonReports.Location = new Point(0, 0);
            buttonReports.Name = "buttonReports";
            buttonReports.Padding = new Padding(10, 0, 0, 0);
            buttonReports.Size = new Size(184, 60);
            buttonReports.TabIndex = 2;
            buttonReports.Text = "التقارير";
            buttonReports.UseVisualStyleBackColor = false;
            buttonReports.Click += buttonReports_Click;
            // 
            // panel7
            // 
            panel7.Controls.Add(buttonUsers);
            panel7.Location = new Point(4, 363);
            panel7.Name = "panel7";
            panel7.Size = new Size(184, 60);
            panel7.TabIndex = 6;
            // 
            // buttonUsers
            // 
            buttonUsers.BackColor = Color.FromArgb(52, 73, 94);
            buttonUsers.FlatAppearance.BorderSize = 0;
            buttonUsers.FlatStyle = FlatStyle.Flat;
            buttonUsers.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonUsers.ForeColor = Color.White;
            buttonUsers.ImageAlign = ContentAlignment.MiddleRight;
            buttonUsers.Location = new Point(0, 0);
            buttonUsers.Name = "buttonUsers";
            buttonUsers.Padding = new Padding(10, 0, 0, 0);
            buttonUsers.Size = new Size(184, 60);
            buttonUsers.TabIndex = 2;
            buttonUsers.Text = "المستخدمين";
            buttonUsers.UseVisualStyleBackColor = false;
            buttonUsers.Click += buttonUsers_Click;
            // 
            // BackupBtn
            // 
            BackupBtn.BackColor = Color.FromArgb(52, 73, 94);
            BackupBtn.FlatAppearance.BorderSize = 0;
            BackupBtn.FlatStyle = FlatStyle.Flat;
            BackupBtn.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BackupBtn.ForeColor = Color.White;
            BackupBtn.ImageAlign = ContentAlignment.MiddleRight;
            BackupBtn.Location = new Point(4, 429);
            BackupBtn.Name = "BackupBtn";
            BackupBtn.Padding = new Padding(10, 0, 0, 0);
            BackupBtn.Size = new Size(184, 60);
            BackupBtn.TabIndex = 6;
            BackupBtn.Text = "النسخ الاحتياطي";
            BackupBtn.UseVisualStyleBackColor = false;
            BackupBtn.Click += BackupBtn_Click;
            // 
            // sidebarTransition
            // 
            sidebarTransition.Interval = 10;
            sidebarTransition.Tick += sidebarTransition_Tick;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            ClientSize = new Size(925, 557);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            IsMdiContainer = true;
            Name = "HomeForm";
            Text = "إدارة المكتبة";
            FormClosed += HomeForm_FormClosed;
            Resize += HomeForm_Resize;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnHome).EndInit();
            sidebar.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox btnHome;
        private Label label1;
        private FlowLayoutPanel sidebar;
        private Button buttonHome;
        private Panel panel2;
        private Panel panel3;
        private Button buttonCategories;
        private Panel panel4;
        private Button buttonProducts;
        private Panel panel5;
        private Button buttonSell;
        private Panel panel6;
        private Button buttonReports;
        private System.Windows.Forms.Timer sidebarTransition;
        private Panel panel7;
        private Button buttonUsers;
        private Button BackupBtn;
    }
}