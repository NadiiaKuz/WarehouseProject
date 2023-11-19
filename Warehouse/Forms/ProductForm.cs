using Warehouse.Logic;
using Warehouse.Models;

namespace Warehouse.Forms
{
    public partial class ProductForm : Form
    {
        private Label labelName, labelPrice, labelCategoryID, labelQuantityInStock, labelDescription;
        private TextBox textBoxName, textBoxPrice, textBoxQuantityInStock, textBoxDescription;
        private Button buttonSave;
        private ComboBox comboBoxCategoryName;

        private readonly WarehouseService _warehouseService;
        private List<Category> _categories;

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
            textBoxName.Text = product.Name;
            textBoxPrice.Text = product.Price.ToString();
            textBoxQuantityInStock.Text = product.QuantityInStock.ToString();
            textBoxDescription.Text = product.Description;
            comboBoxCategoryName.SelectedItem = _categories.First(x => x.CategoryID == product.CategoryID).Name;
        }

        private void PopulateCategory()
        {
            _categories = _warehouseService.GetCategories();
            comboBoxCategoryName.Items.AddRange(_categories.Select(c => c.Name).ToArray());
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            var categoryInputName = comboBoxCategoryName.SelectedItem;

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
                Name = textBoxName.Text,
                Price = Decimal.Parse(textBoxPrice.Text),
                Description = textBoxDescription.Text,
                CategoryID = category.CategoryID,
                Category = category,
                QuantityInStock = Int32.Parse(textBoxQuantityInStock.Text)
            };

            _warehouseService.AddProduct(product);
            
            MessageBox.Show("Product saved successfully!");
            this.Close();
        }
    }
}
