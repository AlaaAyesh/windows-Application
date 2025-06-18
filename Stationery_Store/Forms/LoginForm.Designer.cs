namespace Stationery_Store.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            UserNamelabel = new Label();
            PassWordlabel = new Label();
            UserNametextBox = new TextBox();
            PasswordtextBox = new TextBox();
            Loginbutton = new Button();
            UserNameMessagelabel = new Label();
            PassWordMessagelabel = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // UserNamelabel
            // 
            UserNamelabel.AutoSize = true;
            UserNamelabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            UserNamelabel.ForeColor = Color.FromArgb(52, 73, 94);
            UserNamelabel.Location = new Point(164, 218);
            UserNamelabel.Name = "UserNamelabel";
            UserNamelabel.Size = new Size(139, 28);
            UserNamelabel.TabIndex = 0;
            UserNamelabel.Text = "اسم المستخدم:";
            // 
            // PassWordlabel
            // 
            PassWordlabel.AutoSize = true;
            PassWordlabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PassWordlabel.ForeColor = Color.FromArgb(52, 73, 94);
            PassWordlabel.Location = new Point(164, 277);
            PassWordlabel.Name = "PassWordlabel";
            PassWordlabel.Size = new Size(97, 28);
            PassWordlabel.TabIndex = 1;
            PassWordlabel.Text = "كلمة السر:";
            // 
            // UserNametextBox
            // 
            UserNametextBox.BorderStyle = BorderStyle.FixedSingle;
            UserNametextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNametextBox.Location = new Point(320, 221);
            UserNametextBox.Name = "UserNametextBox";
            UserNametextBox.Size = new Size(271, 30);
            UserNametextBox.TabIndex = 2;
            UserNametextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // PasswordtextBox
            // 
            PasswordtextBox.BorderStyle = BorderStyle.FixedSingle;
            PasswordtextBox.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PasswordtextBox.Location = new Point(320, 280);
            PasswordtextBox.Name = "PasswordtextBox";
            PasswordtextBox.PasswordChar = '*';
            PasswordtextBox.Size = new Size(271, 30);
            PasswordtextBox.TabIndex = 3;
            PasswordtextBox.TextAlign = HorizontalAlignment.Right;
            // 
            // Loginbutton
            // 
            Loginbutton.BackColor = Color.FromArgb(46, 204, 113);
            Loginbutton.FlatAppearance.BorderSize = 0;
            Loginbutton.FlatStyle = FlatStyle.Flat;
            Loginbutton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Loginbutton.ForeColor = Color.White;
            Loginbutton.Location = new Point(286, 356);
            Loginbutton.Name = "Loginbutton";
            Loginbutton.Size = new Size(176, 53);
            Loginbutton.TabIndex = 4;
            Loginbutton.Text = "تسجيل الدخول";
            Loginbutton.UseVisualStyleBackColor = false;
            Loginbutton.Click += Loginbutton_Click;
            // 
            // UserNameMessagelabel
            // 
            UserNameMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            UserNameMessagelabel.ForeColor = Color.FromArgb(231, 76, 60);
            UserNameMessagelabel.Location = new Point(25, 111);
            UserNameMessagelabel.Name = "UserNameMessagelabel";
            UserNameMessagelabel.RightToLeft = RightToLeft.Yes;
            UserNameMessagelabel.Size = new Size(186, 35);
            UserNameMessagelabel.TabIndex = 5;
            UserNameMessagelabel.TextAlign = ContentAlignment.MiddleRight;
            UserNameMessagelabel.Visible = false;
            // 
            // PassWordMessagelabel
            // 
            PassWordMessagelabel.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            PassWordMessagelabel.ForeColor = Color.FromArgb(231, 76, 60);
            PassWordMessagelabel.Location = new Point(71, 356);
            PassWordMessagelabel.Name = "PassWordMessagelabel";
            PassWordMessagelabel.RightToLeft = RightToLeft.Yes;
            PassWordMessagelabel.Size = new Size(186, 35);
            PassWordMessagelabel.TabIndex = 6;
            PassWordMessagelabel.TextAlign = ContentAlignment.MiddleRight;
            PassWordMessagelabel.Visible = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(289, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 162);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(120, 218);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(38, 30);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(120, 275);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(38, 30);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 9;
            pictureBox3.TabStop = false;
            // 
            // LoginForm
            // 
            AcceptButton = Loginbutton;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(236, 240, 241);
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(749, 441);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(PassWordMessagelabel);
            Controls.Add(UserNameMessagelabel);
            Controls.Add(Loginbutton);
            Controls.Add(PasswordtextBox);
            Controls.Add(UserNametextBox);
            Controls.Add(PassWordlabel);
            Controls.Add(UserNamelabel);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "LoginForm";
            RightToLeft = RightToLeft.Yes;
            RightToLeftLayout = true;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "تسجيل الدخول";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label UserNamelabel;
        private Label PassWordlabel;
        private TextBox UserNametextBox;
        private TextBox PasswordtextBox;
        private Button Loginbutton;
        private Label UserNameMessagelabel;
        private Label PassWordMessagelabel;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
