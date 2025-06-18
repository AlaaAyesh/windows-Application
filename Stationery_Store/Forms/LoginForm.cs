using System;
using System.Windows.Forms;
using Stationery_Store.Entities;
using Stationery_Store.Forms;

namespace Stationery_Store.Forms
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
            // Set RightToLeft properties for Arabic UI
            // This.RightToLeft = RightToLeft.Yes; // Handled by BaseForm
            // This.RightToLeftLayout = true; // Handled by BaseForm

            // Add event handlers for hover effect
            Loginbutton.MouseEnter += Loginbutton_MouseEnter;
            Loginbutton.MouseLeave += Loginbutton_MouseLeave;

            // Add event handlers for textbox focus feedback
            UserNametextBox.Enter += TextBox_Enter;
            UserNametextBox.Leave += TextBox_Leave;
            PasswordtextBox.Enter += TextBox_Enter;
            PasswordtextBox.Leave += TextBox_Leave;
        }


        public Role LoggedInUserRole { get; private set; }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            Context context = new Context();

            string user_name = UserNametextBox.Text;
            string password = PasswordtextBox.Text;

            User? user = context.Users.FirstOrDefault(u => u.UserName == user_name);

            if (user == null)
            {
                PassWordMessagelabel.Visible = false;
                UserNameMessagelabel.Text = "اسم المستخدم غير موجود";
                UserNameMessagelabel.Visible = true;
            }
            else
            {
                if (user.Password == password)
                {
                    using (var msgBox = new CustomMessageBoxForm(user.UserRole + " تم تسجيل الدخول بنجاح"))
                    {
                        msgBox.ShowDialog();
                    }

                    LoggedInUserRole = user.UserRole;

                    this.DialogResult = DialogResult.OK;  // إعطاء نتيجة نجاح للنموذج
                    this.Close();                         // إغلاق نافذة تسجيل الدخول
                }
                else
                {
                    UserNameMessagelabel.Visible = false;
                    PassWordMessagelabel.Text = "كلمة المرور غير صحيحة";
                    PassWordMessagelabel.Visible = true;
                }
            }

        }

        private void Loginbutton_MouseEnter(object sender, EventArgs e)
        {
            // Darken the button color on hover
            Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96))))); // A slightly darker green
        }

        private void Loginbutton_MouseLeave(object sender, EventArgs e)
        {
            // Revert to original button color when mouse leaves
            Loginbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113))))); // Original green
        }

        private void TextBox_Enter(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textBox)
            {
                textBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            }
        }
    }
}