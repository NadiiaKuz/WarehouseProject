namespace Warehouse.Forms
{
    partial class CategoryForm
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
            this.Text = "CategoryForm";

            SuspendLayout();

            _labelCategoryName = new Label();
            _textBoxCategoryName = new TextBox();
            _'labelCategoryDescription = new Label();
            _textBoxCategoryDescription = new TextBox();
            _buttonSave = new Button();

            _labelCategoryName.AutoSize = true;
            _labelCategoryName.Location = new Point(20, 20);
            _labelCategoryName.Name = "labelCategoryName";
            _labelCategoryName.Size = new Size(100, 20);
            _labelCategoryName.Text = "Category Name";

            _textBoxCategoryName.Location = new Point(20, 45);
            _textBoxCategoryName.Name = "textBoxCategoryName";
            _textBoxCategoryName.Size = new Size(200, 27);

            _'labelCategoryDescription.AutoSize = true;
            _'labelCategoryDescription.Location = new Point(_textBoxCategoryName.Left, _textBoxCategoryName.Bottom + 20);
            _'labelCategoryDescription.Name = "labelCategoryDescription";
            _'labelCategoryDescription.Size = new Size(100, 20);
            _'labelCategoryDescription.Text = "Category Description";

            _textBoxCategoryDescription.Location = new Point(_'labelCategoryDescription.Left, _'_labelCategoryDescription.Bottom + 10);
            _textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            _textBoxCategoryDescription.Size = new Size(200, 27);

            _buttonSave.Location = new Point(_textBoxCategoryDescription.Left, _textBoxCategoryDescription.Bottom + 20);
            _buttonSave.Name = "buttonSave";
            _buttonSave.Size = new Size(75, 23);
            _buttonSave.Text = "Save";
            _buttonSave.UseVisualStyleBackColor = true;
            _buttonSave.Click += new EventHandler(ButtonSave_Click);

            Controls.Add(_labelCategoryName);
            Controls.Add(_textBoxCategoryName);
            Controls.Add(_'labelCategoryDescription);
            Controls.Add(_textBoxCategoryDescription);
            Controls.Add(_buttonSave);
            Name = "AddCategoryForm";
            Text = "Add New Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}