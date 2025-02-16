namespace Projekt_w69758_GL01_3IIZ
{
    partial class Vets
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
            DeleteVetButton = new Button();
            AddVetButton = new Button();
            EditVetButton = new Button();
            VetDataGrid = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)VetDataGrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteVetButton
            // 
            DeleteVetButton.Location = new Point(551, 28);
            DeleteVetButton.Name = "DeleteVetButton";
            DeleteVetButton.Size = new Size(131, 47);
            DeleteVetButton.TabIndex = 28;
            DeleteVetButton.Text = "Delete";
            DeleteVetButton.UseVisualStyleBackColor = true;
            DeleteVetButton.Click += DeleteVetButton_Click;
            // 
            // AddVetButton
            // 
            AddVetButton.Location = new Point(173, 28);
            AddVetButton.Name = "AddVetButton";
            AddVetButton.Size = new Size(131, 47);
            AddVetButton.TabIndex = 27;
            AddVetButton.Text = "Add";
            AddVetButton.UseVisualStyleBackColor = true;
            AddVetButton.Click += AddVetButton_Click;
            // 
            // EditVetButton
            // 
            EditVetButton.Location = new Point(359, 28);
            EditVetButton.Name = "EditVetButton";
            EditVetButton.Size = new Size(131, 47);
            EditVetButton.TabIndex = 26;
            EditVetButton.Text = "Edit";
            EditVetButton.UseVisualStyleBackColor = true;
            EditVetButton.Click += EditVetButton_Click;
            // 
            // VetDataGrid
            // 
            VetDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VetDataGrid.Location = new Point(22, 96);
            VetDataGrid.Name = "VetDataGrid";
            VetDataGrid.RowHeadersWidth = 51;
            VetDataGrid.Size = new Size(710, 270);
            VetDataGrid.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(73, 28);
            label1.Name = "label1";
            label1.Size = new Size(48, 28);
            label1.TabIndex = 24;
            label1.Text = "Vets";
            // 
            // Vets
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteVetButton);
            Controls.Add(AddVetButton);
            Controls.Add(EditVetButton);
            Controls.Add(VetDataGrid);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Vets";
            Size = new Size(799, 400);
            Load += Vets_Load;
            ((System.ComponentModel.ISupportInitialize)VetDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteVetButton;
        private Button AddVetButton;
        private Button EditVetButton;
        private DataGridView VetDataGrid;
        private Label label1;
    }
}
