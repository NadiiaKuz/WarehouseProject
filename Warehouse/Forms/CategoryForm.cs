using Warehouse.Models;

namespace Warehouse.Forms
{
    public partial class CategoryForm : Form
    {
        private Label _labelCategoryName;
        private TextBox _textBoxCategoryName;
        private Label _labelCategoryDescription;
        private TextBox _textBoxCategoryDescription;
        private Button _buttonSave;

        public Category NewCategory { get; private set; }

        public CategoryForm()
        {
            InitializeComponent();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            string categoryName = _textBoxCategoryName.Text.Trim();
            string categoryDescription = _textBoxCategoryDescription.Text.Trim();

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
