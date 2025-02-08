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
            button2 = new Button();
            AnimalAddButton = new Button();
            button3 = new Button();
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
            // button2
            // 
            button2.Location = new Point(409, 24);
            button2.Margin = new Padding(3, 4, 3, 4);
            button2.Name = "button2";
            button2.Size = new Size(150, 63);
            button2.TabIndex = 3;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // AnimalAddButton
            // 
            AnimalAddButton.Location = new Point(225, 24);
            AnimalAddButton.Margin = new Padding(3, 4, 3, 4);
            AnimalAddButton.Name = "AnimalAddButton";
            AnimalAddButton.Size = new Size(150, 63);
            AnimalAddButton.TabIndex = 4;
            AnimalAddButton.Text = "Add";
            AnimalAddButton.UseVisualStyleBackColor = true;
            AnimalAddButton.Click += button1_Click;
            // 
            // button3
            // 
            button3.Location = new Point(603, 24);
            button3.Margin = new Padding(3, 4, 3, 4);
            button3.Name = "button3";
            button3.Size = new Size(150, 63);
            button3.TabIndex = 5;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // Animals
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button3);
            Controls.Add(AnimalAddButton);
            Controls.Add(button2);
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
        private Button button2;
        private Button AnimalAddButton;
        private Button button3;
    }
}
