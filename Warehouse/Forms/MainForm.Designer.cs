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

            dgvProducts = new DataGridView();
            dgvProducts.Location = new System.Drawing.Point(lblProducts.Left, lblProducts.Bottom + 5);
            dgvProducts.Size = new System.Drawing.Size(ClientSize.Width - 60, ClientSize.Height - 120);
            dgvProducts.DoubleClick += new EventHandler(dgvProducts_DoubleClick);

            btnAddProduct = new Button();
            btnAddProduct.Click += new EventHandler(btnAddProduct_Click);
            btnAddProduct.Text = "Додати Товар";
            btnAddProduct.Location = new System.Drawing.Point(dgvProducts.Left, dgvProducts.Bottom + 10);
            btnAddProduct.Size = new System.Drawing.Size(120, 70);

            btnFilterProduct = new Button();
            btnFilterProduct.Text = "Фільтр Товарів";
            btnFilterProduct.Location = new System.Drawing.Point(btnAddProduct.Right + 20, dgvProducts.Bottom + 10);
            btnFilterProduct.Size = new System.Drawing.Size(120, 70);
            btnFilterProduct.Click += new EventHandler(btnFilterProduct_Click);

            textBoxFilter = new TextBox();
            textBoxFilter.Location = new System.Drawing.Point(btnFilterProduct.Right + 20, dgvProducts.Bottom + 10);
            textBoxFilter.Size = new System.Drawing.Size(120, 40);

            this.Controls.Add(lblProducts);
            this.Controls.Add(dgvProducts);
            this.Controls.Add(btnAddProduct);
            this.Controls.Add(btnFilterProduct);
            this.Controls.Add(textBoxFilter);
        }

        #endregion
    }
}