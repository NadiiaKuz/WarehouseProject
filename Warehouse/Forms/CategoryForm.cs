using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.Models;

namespace Warehouse.Forms
{
    public partial class CategoryForm : Form
    {
        private Label labelCategoryName;
        private TextBox textBoxCategoryName;
        private Label labelCategoryDescription;
        private TextBox textBoxCategoryDescription;
        private Button buttonSave;

        public Category NewCategory { get; private set; }

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string categoryName = textBoxCategoryName.Text.Trim();
            string categoryDescription = textBoxCategoryDescription.Text.Trim();

            if (string.IsNullOrEmpty(categoryName))
            {
                MessageBox.Show("Please enter a category name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            NewCategory = new Category { Name = categoryName, Description = categoryDescription};

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
