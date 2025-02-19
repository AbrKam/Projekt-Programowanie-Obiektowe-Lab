namespace Projekt_w69758_GL01_3IIZ
{
    partial class Animals
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            AnimalDataGrid = new DataGridView();
            EditAnimalButton = new Button();
            AddAnimalButton = new Button();
            DeleteAnimalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(22, 10);
            label1.Name = "label1";
            label1.Size = new Size(81, 28);
            label1.TabIndex = 0;
            label1.Text = "Animals";
            // 
            // AnimalDataGrid
            // 
            AnimalDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AnimalDataGrid.Location = new Point(22, 96);
            AnimalDataGrid.Name = "AnimalDataGrid";
            AnimalDataGrid.RowHeadersWidth = 51;
            AnimalDataGrid.Size = new Size(710, 270);
            AnimalDataGrid.TabIndex = 1;
            // 
            // EditAnimalButton
            // 
            EditAnimalButton.Location = new Point(358, 18);
            EditAnimalButton.Name = "EditAnimalButton";
            EditAnimalButton.Size = new Size(131, 47);
            EditAnimalButton.TabIndex = 3;
            EditAnimalButton.Text = "Edit";
            EditAnimalButton.UseVisualStyleBackColor = true;
            EditAnimalButton.Click += EditAnimalButton_Click;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(197, 18);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(131, 47);
            AddAnimalButton.TabIndex = 4;
            AddAnimalButton.Text = "Add";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // DeleteAnimalButton
            // 
            DeleteAnimalButton.Location = new Point(528, 18);
            DeleteAnimalButton.Name = "DeleteAnimalButton";
            DeleteAnimalButton.Size = new Size(131, 47);
            DeleteAnimalButton.TabIndex = 5;
            DeleteAnimalButton.Text = "Delete";
            DeleteAnimalButton.UseVisualStyleBackColor = true;
            DeleteAnimalButton.Click += DeleteAnimalButton_Click;
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteAnimalButton);
            Controls.Add(AddAnimalButton);
            Controls.Add(EditAnimalButton);
            Controls.Add(AnimalDataGrid);
            Controls.Add(label1);
            Name = "Animals";
            Size = new Size(799, 400);
            Load += Animals_Load;
            ((System.ComponentModel.ISupportInitialize)AnimalDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView AnimalDataGrid;
        private Button EditAnimalButton;
        private Button AddAnimalButton;
        private Button DeleteAnimalButton;
    }
}
