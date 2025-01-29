namespace Projekt_w69758_GL01_3IIZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            mainPanel = new Panel();
            visits1 = new Visits();
            vets1 = new Vets();
            animals1 = new Animals();
            mainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 399);
            button1.Name = "button1";
            button1.Size = new Size(163, 29);
            button1.TabIndex = 0;
            button1.Text = "Visits";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(312, 398);
            button2.Name = "button2";
            button2.Size = new Size(163, 30);
            button2.TabIndex = 1;
            button2.Text = "Animals";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(591, 398);
            button3.Name = "button3";
            button3.Size = new Size(163, 30);
            button3.TabIndex = 2;
            button3.Text = "Vets";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 64F);
            label1.Location = new Point(49, 83);
            label1.MaximumSize = new Size(250, 250);
            label1.MinimumSize = new Size(650, 100);
            label1.Name = "label1";
            label1.Size = new Size(650, 114);
            label1.TabIndex = 3;
            label1.Text = "VetManager v.1";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // mainPanel
            // 
            mainPanel.Controls.Add(visits1);
            mainPanel.Controls.Add(vets1);
            mainPanel.Controls.Add(animals1);
            mainPanel.Controls.Add(label1);
            mainPanel.Location = new Point(12, 12);
            mainPanel.Name = "mainPanel";
            mainPanel.Size = new Size(776, 380);
            mainPanel.TabIndex = 4;
            // 
            // visits1
            // 
            visits1.Location = new Point(0, 4);
            visits1.Name = "visits1";
            visits1.Size = new Size(773, 377);
            visits1.TabIndex = 6;
            // 
            // vets1
            // 
            vets1.Location = new Point(3, 9);
            vets1.Name = "vets1";
            vets1.Size = new Size(773, 368);
            vets1.TabIndex = 5;
            // 
            // animals1
            // 
            animals1.Location = new Point(0, 0);
            animals1.Name = "animals1";
            animals1.Size = new Size(776, 380);
            animals1.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainPanel);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "VetManager";
            Load += Form1_Load;
            mainPanel.ResumeLayout(false);
            mainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private Panel mainPanel;
        private Visits visits1;
        private Vets vets1;
        private Animals animals1;
    }
}
