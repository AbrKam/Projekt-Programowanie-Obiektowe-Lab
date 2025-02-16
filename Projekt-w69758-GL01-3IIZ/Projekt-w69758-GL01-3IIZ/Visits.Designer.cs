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
            VisitDataGrid = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            ((System.ComponentModel.ISupportInitialize)VisitDataGrid).BeginInit();
            SuspendLayout();
            // 
            // DeleteVisitButton
            // 
            DeleteVisitButton.Location = new Point(529, 26);
            DeleteVisitButton.Name = "DeleteVisitButton";
            DeleteVisitButton.Size = new Size(131, 47);
            DeleteVisitButton.TabIndex = 28;
            DeleteVisitButton.Text = "Delete";
            DeleteVisitButton.UseVisualStyleBackColor = true;
            DeleteVisitButton.Click += DeleteVisitButton_Click;
            // 
            // AddVisitButton
            // 
            AddVisitButton.Location = new Point(199, 26);
            AddVisitButton.Name = "AddVisitButton";
            AddVisitButton.Size = new Size(131, 47);
            AddVisitButton.TabIndex = 27;
            AddVisitButton.Text = "Add";
            AddVisitButton.UseVisualStyleBackColor = true;
            AddVisitButton.Click += AddVisitButton_Click;
            // 
            // EditVisitButton
            // 
            EditVisitButton.Location = new Point(360, 26);
            EditVisitButton.Name = "EditVisitButton";
            EditVisitButton.Size = new Size(131, 47);
            EditVisitButton.TabIndex = 26;
            EditVisitButton.Text = "Edit";
            EditVisitButton.UseVisualStyleBackColor = true;
            EditVisitButton.Click += EditVisitButton_Click;
            // 
            // VisitDataGrid
            // 
            VisitDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            VisitDataGrid.Location = new Point(22, 96);
            VisitDataGrid.Name = "VisitDataGrid";
            VisitDataGrid.RowHeadersWidth = 51;
            VisitDataGrid.Size = new Size(710, 270);
            VisitDataGrid.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(21, 19);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(DeleteVisitButton);
            Controls.Add(AddVisitButton);
            Controls.Add(EditVisitButton);
            Controls.Add(VisitDataGrid);
            Controls.Add(label1);
            Name = "Visits";
            Size = new Size(799, 400);
            Load += Visits_Load;
            ((System.ComponentModel.ISupportInitialize)VisitDataGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button DeleteVisitButton;
        private Button AddVisitButton;
        private Button EditVisitButton;
        private DataGridView VisitDataGrid;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
    }
}
