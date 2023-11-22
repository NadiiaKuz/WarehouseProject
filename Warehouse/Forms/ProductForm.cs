using Warehouse.Logic;
using Warehouse.Models;

namespace Warehouse.Forms
{
    public partial class ProductForm : Form
    {
        private readonly WarehouseService _warehouseService;
        private List<Category> _categories;

        private Label _labelName, _labelPrice, _labelCategoryID, _labelQuantityInStock, _labelDescription;
        private TextBox _textBoxName, _textBoxPrice, _textBoxQuantityInStock, _textBoxDescription;
        private Button _buttonSave;
        private ComboBox _comboBoxCategoryName;

        private int _productId;

        public ProductForm(WarehouseService warehouseService, Product? product = null)
        {
            InitializeComponent();

            _warehouseService = warehouseService;

            PopulateCategory();

            if(product is not null )
                PopulateForm(product);

            _productId = product?.ProductId ?? 0;
        }

        private void PopulateForm(Product product)
        {
            _textBoxName.Text = product.Name;
            _textBoxPrice.Text = product.Price.ToString();
            _textBoxQuantityInStock.Text = product.QuantityInStock.ToString();
            _textBoxDescription.Text = product.Description;
            _comboBoxCategoryName.SelectedItem = _categories.First(x => x.CategoryID == product.CategoryID).Name;
        }

        private void PopulateCategory()
        {
            _categories = _warehouseService.GetCategories();
            _comboBoxCategoryName.Items.AddRange(_categories.Select(c => c.Name).ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var categoryInputName = _comboBoxCategoryName.SelectedItem;

            Category? category = new();

            if (categoryInputName is null)
            {
                using CategoryForm addForm = new CategoryForm();
                
                if (addForm.ShowDialog() == DialogResult.OK)
                    category = addForm.NewCategory;
                else
                    return;
            }
            else
            {
                category = _categories.FirstOrDefault(x => x.Name == categoryInputName);

                if (category is null)
                {
                    MessageBox.Show("Wrong category");
                    return;
                }
            }

            Product product = new Product
            {
                ProductId = _productId,
                Name = _textBoxName.Text,
                Price = Decimal.Parse(_textBoxPrice.Text),
                Description = _textBoxDescription.Text,
                CategoryID = category.CategoryID,
                Category = category,
                QuantityInStock = Int32.Parse(_textBoxQuantityInStock.Text)
            };

            _warehouseService.AddProduct(product);
            
            MessageBox.Show("Product saved successfully!");
            this.Close();
        }
    }
}
