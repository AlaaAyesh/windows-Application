using Stationery_Store.Entities;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Stationery_Store.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private Context context; // Use a local context instance
        private Product currentProduct; // To hold the product being edited

        // Constructor for adding a new product
        public ProductDetailsForm()
        {
            InitializeComponent();
            // Set RightToLeft properties for Arabic UI
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            btnCancel.CausesValidation = false; // Prevent validation on cancel
            context = new Context(); // Initialize context
            LoadCategories();
            this.Text = "إضافة منتج جديد";
        }

        // Constructor for editing an existing product
        public ProductDetailsForm(int productID)
        {
            InitializeComponent();
            // Set RightToLeft properties for Arabic UI
            this.RightToLeft = RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.AcceptButton = btnSave;
            this.CancelButton = btnCancel;
            btnCancel.CausesValidation = false; // Prevent validation on cancel
            context = new Context(); // Initialize context
            LoadCategories();
            this.Text = "تعديل المنتج";
            
            // Fetch the product within this form's context
            this.currentProduct = context.Products.Find(productID);

            if (this.currentProduct != null)
            {
                LoadProductDetails(this.currentProduct);
            }
            else
            {
                using (var msgBox = new CustomMessageBoxForm("المنتج غير موجود."))
                {
                    msgBox.ShowDialog();
                }
                this.DialogResult = DialogResult.Cancel;
                this.Close();
            }
        }

        private void LoadCategories()
        {
            var categories = context.Categories.ToList();
            categoryComboBox.DataSource = categories;
            categoryComboBox.DisplayMember = "Name";
            categoryComboBox.ValueMember = "ID";
        }

        private void LoadProductDetails(Product product)
        {
            txtName.Text = product.Name;
            txtDescription.Text = product.Description;
            txtPrice.Text = product.Price.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            categoryComboBox.SelectedValue = product.CategoryId;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false; // Disable the button immediately
            try
            {
                if (ValidateInputs())
                {
                    if (currentProduct == null)
                    {
                        var newProduct = new Product
                        {
                            Name = txtName.Text,
                            Description = txtDescription.Text,
                            Price = double.Parse(txtPrice.Text),
                            Quantity = int.Parse(txtQuantity.Text),
                            CategoryId = (int)categoryComboBox.SelectedValue
                        };
                        context.Products.Add(newProduct);
                    }
                    else
                    {
                        currentProduct.Name = txtName.Text;
                        currentProduct.Description = txtDescription.Text;
                        currentProduct.Price = double.Parse(txtPrice.Text);
                        currentProduct.Quantity = int.Parse(txtQuantity.Text);
                        currentProduct.CategoryId = (int)categoryComboBox.SelectedValue;
                    }

                    context.SaveChanges();
                    this.DialogResult = DialogResult.OK; // Set result before closing
                    this.Close();
                }
            }
            finally
            {
                btnSave.Enabled = true; // Re-enable the button
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel; // Ensure dialog result is set
            this.Close();
        }

        private bool ValidateInputs()
        {
            // Basic validation (can be expanded)
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                using (var msgBox = new CustomMessageBoxForm("الرجاء إدخال اسم المنتج."))
                {
                    msgBox.ShowDialog();
                }
                txtName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text) || !double.TryParse(txtPrice.Text, out _))
            {
                using (var msgBox = new CustomMessageBoxForm("الرجاء إدخال سعر صالح للمنتج."))
                {
                    msgBox.ShowDialog();
                }
                txtPrice.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text) || !int.TryParse(txtQuantity.Text, out _))
            {
                using (var msgBox = new CustomMessageBoxForm("الرجاء إدخال كمية صالحة للمنتج."))
                {
                    msgBox.ShowDialog();
                }
                txtQuantity.Focus();
                return false;
            }
             if (categoryComboBox.SelectedValue == null || (int)categoryComboBox.SelectedValue == 0)
            {
                using (var msgBox = new CustomMessageBoxForm("الرجاء تحديد صنف للمنتج."))
                {
                    msgBox.ShowDialog();
                }
                categoryComboBox.Focus();
                return false;
            }

            return true;
        }

       

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                context?.Dispose(); // Dispose the context when the form is disposed
            }
            base.Dispose(disposing);
        }
    }
} 