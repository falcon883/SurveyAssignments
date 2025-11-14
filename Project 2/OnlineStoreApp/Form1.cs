using System;
using System.Windows.Forms;

namespace OnlineStoreApp
{
    public partial class Form1 : Form
    {
        private OnlineStore store;

        public Form1()
        {
            InitializeComponent();
            store = new OnlineStore();
            LoadCategories();
        }

        private void LoadCategories()
        {
            cmbCategory.Items.Add(Category.SPORTS);
            cmbCategory.Items.Add(Category.BOOKS);
            cmbCategory.Items.Add(Category.ELECTRONICS);
            cmbCategory.SelectedIndex = 0;
        }

        private void btnSearchById_Click(object sender, EventArgs e)
        {
            txtResultById.Clear();

            if (int.TryParse(txtProductId.Text, out int productId))
            {
                Product product = store[productId];

                if (product != null)
                {
                    txtResultById.Text = product.ToString();
                }
                else
                {
                    txtResultById.Text = "Product not found.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a valid Product ID.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchByName_Click(object sender, EventArgs e)
        {
            txtResultByName.Clear();

            if (!string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                Product product = store[txtProductName.Text];

                if (product != null)
                {
                    txtResultByName.Text = product.ToString();
                }
                else
                {
                    txtResultByName.Text = "Product not found.";
                }
            }
            else
            {
                MessageBox.Show("Please enter a Product Name.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchByDescription_Click(object sender, EventArgs e)
        {
            lstResultsByDescription.Items.Clear();

            if (!string.IsNullOrWhiteSpace(txtDescription.Text))
            {
                Product[] products = store[txtDescription.Text, true];

                if (products.Length > 0)
                {
                    foreach (Product product in products)
                    {
                        lstResultsByDescription.Items.Add(product.ToString());
                    }
                }
                else
                {
                    lstResultsByDescription.Items.Add("No products found matching the description.");
                }
            }
            else
            {
                MessageBox.Show("Please enter a search term.", "Invalid Input",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSearchByCategory_Click(object sender, EventArgs e)
        {
            lstResultsByCategory.Items.Clear();

            if (cmbCategory.SelectedItem != null)
            {
                Category selectedCategory = (Category)cmbCategory.SelectedItem;
                Product[] products = store[selectedCategory];

                if (products.Length > 0)
                {
                    foreach (Product product in products)
                    {
                        lstResultsByCategory.Items.Add(product.ToString());
                    }
                }
                else
                {
                    lstResultsByCategory.Items.Add("No products found in this category.");
                }
            }
        }
    }
}