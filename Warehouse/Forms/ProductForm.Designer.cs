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

            labelName = new Label();
            labelPrice = new Label();
            labelCategoryID = new Label();
            labelQuantityInStock = new Label();
            labelDescription = new Label();
            textBoxName = new TextBox();
            textBoxPrice = new TextBox();
            textBoxQuantityInStock = new TextBox();
            textBoxDescription = new TextBox();
            buttonSave = new Button();
            comboBoxCategoryName = new ComboBox();

            SuspendLayout();

            // Label Name
            labelName.AutoSize = true;
            labelName.Location = new Point(37, 20);
            labelName.Name = "labelName";
            labelName.Size = new Size(104, 20);
            labelName.Text = "Product Name";

            // TextBox Name
            textBoxName.Location = new Point(37, 40);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(199, 27);

            // Label Price
            labelPrice.AutoSize = true;
            labelPrice.Location = new Point(37, 70);
            labelPrice.Name = "labelPrice";
            labelPrice.Size = new Size(41, 20);
            labelPrice.Text = "Price";

            // TextBox Price
            textBoxPrice.Location = new Point(37, 90);
            textBoxPrice.Name = "textBoxPrice";
            textBoxPrice.Size = new Size(199, 27);

            // Label CategoryID
            labelCategoryID.AutoSize = true;
            labelCategoryID.Location = new Point(37, 120);
            labelCategoryID.Name = "labelCategoryID";
            labelCategoryID.Size = new Size(82, 20);
            labelCategoryID.Text = "Category Name";

            // TextBox CategoryID
            comboBoxCategoryName.Location = new Point(37, 140);
            comboBoxCategoryName.Name = "comboBoxCategoryName";
            comboBoxCategoryName.Size = new Size(199, 27);

            // Label QuantityInStock
            labelQuantityInStock.AutoSize = true;
            labelQuantityInStock.Location = new Point(37, 170);
            labelQuantityInStock.Name = "labelQuantityInStock";
            labelQuantityInStock.Size = new Size(113, 20);
            labelQuantityInStock.Text = "Quantity In Stock";

            // TextBox QuantityInStock
            textBoxQuantityInStock.Location = new Point(37, 190);
            textBoxQuantityInStock.Name = "textBoxQuantityInStock";
            textBoxQuantityInStock.Size = new Size(199, 27);

            // Label Description
            labelDescription.AutoSize = true;
            labelDescription.Location = new Point(37, 220);
            labelDescription.Name = "labelDescription";
            labelDescription.Size = new Size(85, 20);
            labelDescription.Text = "Description";

            // TextBox Description
            textBoxDescription.Location = new Point(37, 240);
            textBoxDescription.Name = "textBoxDescription";
            textBoxDescription.Size = new Size(199, 27);

            // Button Save
            buttonSave.Location = new Point(37, 270);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 29);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new EventHandler(buttonSave_Click);

            // FormAddProduct
            Controls.Add(labelName);
            Controls.Add(textBoxName);
            Controls.Add(labelPrice);
            Controls.Add(textBoxPrice);
            Controls.Add(labelCategoryID);
            Controls.Add(comboBoxCategoryName);
            Controls.Add(labelQuantityInStock);
            Controls.Add(textBoxQuantityInStock);
            Controls.Add(labelDescription);
            Controls.Add(textBoxDescription);
            Controls.Add(buttonSave);
            Name = "FormAddProduct";
            Text = "Add/Edit Product";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}