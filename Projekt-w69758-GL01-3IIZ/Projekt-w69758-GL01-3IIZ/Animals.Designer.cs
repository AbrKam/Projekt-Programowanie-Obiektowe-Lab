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
            dataGridView1 = new DataGridView();
            EditAnimalButton = new Button();
            AddAnimalButton = new Button();
            DeleteAnimalButton = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(25, 13);
            label1.Name = "label1";
            label1.Size = new Size(103, 35);
            label1.TabIndex = 0;
            label1.Text = "Animals";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(25, 128);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(812, 360);
            dataGridView1.TabIndex = 1;
            // 
            // EditAnimalButton
            // 
            EditAnimalButton.Location = new Point(409, 24);
            EditAnimalButton.Margin = new Padding(3, 4, 3, 4);
            EditAnimalButton.Name = "EditAnimalButton";
            EditAnimalButton.Size = new Size(150, 63);
            EditAnimalButton.TabIndex = 3;
            EditAnimalButton.Text = "Edit";
            EditAnimalButton.UseVisualStyleBackColor = true;
            EditAnimalButton.Click += EditAnimalButton_Click;
            // 
            // AddAnimalButton
            // 
            AddAnimalButton.Location = new Point(225, 24);
            AddAnimalButton.Margin = new Padding(3, 4, 3, 4);
            AddAnimalButton.Name = "AddAnimalButton";
            AddAnimalButton.Size = new Size(150, 63);
            AddAnimalButton.TabIndex = 4;
            AddAnimalButton.Text = "Add";
            AddAnimalButton.UseVisualStyleBackColor = true;
            AddAnimalButton.Click += AddAnimalButton_Click;
            // 
            // DeleteAnimalButton
            // 
            DeleteAnimalButton.Location = new Point(603, 24);
            DeleteAnimalButton.Margin = new Padding(3, 4, 3, 4);
            DeleteAnimalButton.Name = "DeleteAnimalButton";
            DeleteAnimalButton.Size = new Size(150, 63);
            DeleteAnimalButton.TabIndex = 5;
            DeleteAnimalButton.Text = "Delete";
            DeleteAnimalButton.UseVisualStyleBackColor = true;
            DeleteAnimalButton.Click += DeleteAnimalButton_Click;
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteAnimalButton);
            Controls.Add(AddAnimalButton);
            Controls.Add(EditAnimalButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Animals";
            Size = new Size(913, 533);
            Load += Animals_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dataGridView1;
        private Button EditAnimalButton;
        private Button AddAnimalButton;
        private Button DeleteAnimalButton;
    }
}
