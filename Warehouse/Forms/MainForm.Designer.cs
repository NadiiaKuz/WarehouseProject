namespace Warehouse
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 900);
            this.Text = "MainForm";
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

            Label lblProducts = new Label();
            lblProducts.Text = "Товари";
            lblProducts.Location = new System.Drawing.Point(20, 0);

            _dgvProducts = new DataGridView();
            _dgvProducts.Location = new System.Drawing.Point(lblProducts.Left, lblProducts.Bottom + 5);
            _dgvProducts.Size = new System.Drawing.Size(ClientSize.Width - 60, ClientSize.Height - 120);
            _dgvProducts.DoubleClick += new EventHandler(dgvProducts_DoubleClick);

            _btnAddProduct = new Button();
            _btnAddProduct.Click += new EventHandler(btnAddProduct_Click);
            _btnAddProduct.Text = "Додати Товар";
            _btnAddProduct.Location = new System.Drawing.Point(_dgvProducts.Left, _dgvProducts.Bottom + 10);
            _btnAddProduct.Size = new System.Drawing.Size(120, 70);

            _btnFilterProduct = new Button();
            _btnFilterProduct.Text = "Фільтр Товарів";
            _btnFilterProduct.Location = new System.Drawing.Point(_btnAddProduct.Right + 20, _dgvProducts.Bottom + 10);
            _btnFilterProduct.Size = new System.Drawing.Size(120, 70);
            _btnFilterProduct.Click += new EventHandler(btnFilterProduct_Click);

            _textBoxFilter = new TextBox();
            _textBoxFilter.Location = new System.Drawing.Point(_btnFilterProduct.Right + 20, _dgvProducts.Bottom + 10);
            _textBoxFilter.Size = new System.Drawing.Size(120, 40);

            this.Controls.Add(lblProducts);
            this.Controls.Add(_dgvProducts);
            this.Controls.Add(_btnAddProduct);
            this.Controls.Add(_btnFilterProduct);
            this.Controls.Add(_textBoxFilter);
        }

        #endregion
    }
}