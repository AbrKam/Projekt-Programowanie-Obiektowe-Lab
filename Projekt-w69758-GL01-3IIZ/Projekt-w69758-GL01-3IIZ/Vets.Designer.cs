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
            dataGridView1 = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteVetButton
            // 
            DeleteVetButton.Location = new Point(630, 37);
            DeleteVetButton.Margin = new Padding(3, 4, 3, 4);
            DeleteVetButton.Name = "DeleteVetButton";
            DeleteVetButton.Size = new Size(150, 63);
            DeleteVetButton.TabIndex = 28;
            DeleteVetButton.Text = "Delete";
            DeleteVetButton.UseVisualStyleBackColor = true;
            DeleteVetButton.Click += DeleteVetButton_Click;
            // 
            // AddVetButton
            // 
            AddVetButton.Location = new Point(198, 37);
            AddVetButton.Margin = new Padding(3, 4, 3, 4);
            AddVetButton.Name = "AddVetButton";
            AddVetButton.Size = new Size(150, 63);
            AddVetButton.TabIndex = 27;
            AddVetButton.Text = "Add";
            AddVetButton.UseVisualStyleBackColor = true;
            AddVetButton.Click += AddVetButton_Click;
            // 
            // EditVetButton
            // 
            EditVetButton.Location = new Point(410, 37);
            EditVetButton.Margin = new Padding(3, 4, 3, 4);
            EditVetButton.Name = "EditVetButton";
            EditVetButton.Size = new Size(150, 63);
            EditVetButton.TabIndex = 26;
            EditVetButton.Text = "Edit";
            EditVetButton.UseVisualStyleBackColor = true;
            EditVetButton.Click += EditVetButton_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 128);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(812, 360);
            dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(83, 37);
            label1.Name = "label1";
            label1.Size = new Size(61, 35);
            label1.TabIndex = 24;
            label1.Text = "Vets";
            // 
            // Vets
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteVetButton);
            Controls.Add(AddVetButton);
            Controls.Add(EditVetButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Vets";
            Size = new Size(913, 533);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteVetButton;
        private Button AddVetButton;
        private Button EditVetButton;
        private DataGridView dataGridView1;
        private Label label1;
    }
}
