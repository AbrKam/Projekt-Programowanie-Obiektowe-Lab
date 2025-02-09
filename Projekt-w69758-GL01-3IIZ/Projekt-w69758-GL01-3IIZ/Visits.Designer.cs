namespace Projekt_w69758_GL01_3IIZ
{
    partial class Visits
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
            components = new System.ComponentModel.Container();
            DeleteVisitButton = new Button();
            AddVisitButton = new Button();
            EditVisitButton = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // DeleteVisitButton
            // 
            DeleteVisitButton.Location = new Point(605, 34);
            DeleteVisitButton.Margin = new Padding(3, 4, 3, 4);
            DeleteVisitButton.Name = "DeleteVisitButton";
            DeleteVisitButton.Size = new Size(150, 63);
            DeleteVisitButton.TabIndex = 28;
            DeleteVisitButton.Text = "Delete";
            DeleteVisitButton.UseVisualStyleBackColor = true;
            DeleteVisitButton.Click += DeleteVisitButton_Click;
            // 
            // AddVisitButton
            // 
            AddVisitButton.Location = new Point(227, 34);
            AddVisitButton.Margin = new Padding(3, 4, 3, 4);
            AddVisitButton.Name = "AddVisitButton";
            AddVisitButton.Size = new Size(150, 63);
            AddVisitButton.TabIndex = 27;
            AddVisitButton.Text = "Add";
            AddVisitButton.UseVisualStyleBackColor = true;
            AddVisitButton.Click += AddVisitButton_Click;
            // 
            // EditVisitButton
            // 
            EditVisitButton.Location = new Point(411, 34);
            EditVisitButton.Margin = new Padding(3, 4, 3, 4);
            EditVisitButton.Name = "EditVisitButton";
            EditVisitButton.Size = new Size(150, 63);
            EditVisitButton.TabIndex = 26;
            EditVisitButton.Text = "Edit";
            EditVisitButton.UseVisualStyleBackColor = true;
            EditVisitButton.Click += EditVisitButton_Click;
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
            label1.Location = new Point(24, 25);
            label1.Name = "label1";
            label1.Size = new Size(73, 35);
            label1.TabIndex = 24;
            label1.Text = "Visits";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // Visits
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteVisitButton);
            Controls.Add(AddVisitButton);
            Controls.Add(EditVisitButton);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Visits";
            Size = new Size(913, 533);
            Load += Visits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteVisitButton;
        private Button AddVisitButton;
        private Button EditVisitButton;
        private DataGridView dataGridView1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
    }
}
