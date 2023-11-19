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

            labelCategoryName = new Label();
            textBoxCategoryName = new TextBox();
            labelCategoryDescription = new Label();
            textBoxCategoryDescription = new TextBox();
            buttonSave = new Button();

            labelCategoryName.AutoSize = true;
            labelCategoryName.Location = new Point(20, 20);
            labelCategoryName.Name = "labelCategoryName";
            labelCategoryName.Size = new Size(100, 20);
            labelCategoryName.Text = "Category Name";

            textBoxCategoryName.Location = new Point(20, 45);
            textBoxCategoryName.Name = "textBoxCategoryName";
            textBoxCategoryName.Size = new Size(200, 27);

            labelCategoryDescription.AutoSize = true;
            labelCategoryDescription.Location = new Point(textBoxCategoryName.Left, textBoxCategoryName.Bottom + 20);
            labelCategoryDescription.Name = "labelCategoryDescription";
            labelCategoryDescription.Size = new Size(100, 20);
            labelCategoryDescription.Text = "Category Description";

            textBoxCategoryDescription.Location = new Point(labelCategoryDescription.Left, labelCategoryDescription.Bottom + 10);
            textBoxCategoryDescription.Name = "textBoxCategoryDescription";
            textBoxCategoryDescription.Size = new Size(200, 27);

            buttonSave.Location = new Point(textBoxCategoryDescription.Left, textBoxCategoryDescription.Bottom + 20);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += new EventHandler(ButtonSave_Click);

            Controls.Add(labelCategoryName);
            Controls.Add(textBoxCategoryName);
            Controls.Add(labelCategoryDescription);
            Controls.Add(textBoxCategoryDescription);
            Controls.Add(buttonSave);
            Name = "AddCategoryForm";
            Text = "Add New Category";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}