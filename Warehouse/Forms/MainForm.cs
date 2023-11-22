using Warehouse.Forms;
using Warehouse.Logic;
using Warehouse.Models;

namespace Warehouse
{
    public partial class MainForm : Form
    {
        private readonly WarehouseService _warehouseService;

        private DataGridView _dgvProducts = null!;
        private Button _btnAddProduct = null!;
        private Button _btnFilterProduct = null!;
        private TextBox _textBoxFilter = null!;

        public MainForm()
        {
            InitializeComponent();

            _warehouseService = new WarehouseService();

            ShowProducts();
        }

        private void ShowProducts()
        {
            try
            {
                var products = _warehouseService.GetProducts();

                _dgvProducts.DataSource = products;
                _dgvProducts.Columns["Category"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvProducts_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (_dgvProducts.CurrentRow.Index != -1)
                {
                    int productId = Convert.ToInt32(_dgvProducts.CurrentRow.Cells["ProductID"].Value);

                    var product = ((List<Product>)_dgvProducts.DataSource)
                        .First(x => x.ProductId == productId);

                    ProductForm editForm = new ProductForm(_warehouseService, product);
                    editForm.ShowDialog();
                }

                ShowProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error editing product: " + ex.Message);
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            try
            {
                ProductForm editForm = new ProductForm(_warehouseService);
                editForm.ShowDialog();

                ShowProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding new product: " + ex.Message);
            }
        }

        private void btnFilterProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var filter = _textBoxFilter.Text;

                if (String.IsNullOrEmpty(filter))
                {
                    ShowProducts();
                    return;
                }

                _dgvProducts.DataSource = _warehouseService.GetProductsByNameLike(filter);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error filtering products: " + ex.Message);
            }
        }
    }
}
