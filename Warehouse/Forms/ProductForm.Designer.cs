namespace Warehouse.Forms
{
    partial class ProductForm
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
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "ProductForm";

            _labelName = new Label();
            _labelPrice = new Label();
            _labelCategoryID = new Label();
            _labelQuantityInStock = new Label();
            _labelDescription = new Label();
            _textBoxName = new TextBox();
            _textBoxPrice = new TextBox();
            _textBoxQuantityInStock = new TextBox();
            _textBoxDescription = new TextBox();
            _buttonSave = new Button();
            _comboBoxCategoryName = new ComboBox();

            SuspendLayout();

            // Label Name
            _labelName.AutoSize = true;
            _labelName.Location = new Point(37, 20);
            _labelName.Name = "labelName";
            _labelName.Size = new Size(104, 20);
            _labelName.Text = "Product Name";

            // TextBox Name
            _textBoxName.Location = new Point(37, 40);
            _textBoxName.Name = "textBoxName";
            _textBoxName.Size = new Size(199, 27);

            // Label Price
            _labelPrice.AutoSize = true;
            _labelPrice.Location = new Point(37, 70);
            _labelPrice.Name = "labelPrice";
            _labelPrice.Size = new Size(41, 20);
            _labelPrice.Text = "Price";

            // TextBox Price
            _textBoxPrice.Location = new Point(37, 90);
            _textBoxPrice.Name = "textBoxPrice";
            _textBoxPrice.Size = new Size(199, 27);

            // Label CategoryID
            _labelCategoryID.AutoSize = true;
            _labelCategoryID.Location = new Point(37, 120);
            _labelCategoryID.Name = "labelCategoryID";
            _labelCategoryID.Size = new Size(82, 20);
            _labelCategoryID.Text = "Category Name";

            // TextBox CategoryID
            _comboBoxCategoryName.Location = new Point(37, 140);
            _comboBoxCategoryName.Name = "comboBoxCategoryName";
            _comboBoxCategoryName.Size = new Size(199, 27);

            // Label QuantityInStock
            _labelQuantityInStock.AutoSize = true;
            _labelQuantityInStock.Location = new Point(37, 170);
            _labelQuantityInStock.Name = "labelQuantityInStock";
            _labelQuantityInStock.Size = new Size(113, 20);
            _labelQuantityInStock.Text = "Quantity In Stock";

            // TextBox QuantityInStock
            _textBoxQuantityInStock.Location = new Point(37, 190);
            _textBoxQuantityInStock.Name = "textBoxQuantityInStock";
            _textBoxQuantityInStock.Size = new Size(199, 27);

            // Label Description
            _labelDescription.AutoSize = true;
            _labelDescription.Location = new Point(37, 220);
            _labelDescription.Name = "labelDescription";
            _labelDescription.Size = new Size(85, 20);
            _labelDescription.Text = "Description";

            // TextBox Description
            _textBoxDescription.Location = new Point(37, 240);
            _textBoxDescription.Name = "textBoxDescription";
            _textBoxDescription.Size = new Size(199, 27);

            // Button Save
            _buttonSave.Location = new Point(37, 270);
            _buttonSave.Name = "buttonSave";
            _buttonSave.Size = new Size(94, 29);
            _buttonSave.Text = "Save";
            _buttonSave.UseVisualStyleBackColor = true;
            _buttonSave.Click += new EventHandler(buttonSave_Click);

            // FormAddProduct
            Controls.Add(_labelName);
            Controls.Add(_textBoxName);
            Controls.Add(_labelPrice);
            Controls.Add(_textBoxPrice);
            Controls.Add(_labelCategoryID);
            Controls.Add(_comboBoxCategoryName);
            Controls.Add(_labelQuantityInStock);
            Controls.Add(_textBoxQuantityInStock);
            Controls.Add(_labelDescription);
            Controls.Add(_textBoxDescription);
            Controls.Add(_buttonSave);
            Name = "FormAddProduct";
            Text = "Add/Edit Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}