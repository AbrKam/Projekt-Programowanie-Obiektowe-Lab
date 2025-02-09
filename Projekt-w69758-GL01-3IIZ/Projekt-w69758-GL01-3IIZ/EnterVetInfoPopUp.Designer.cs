namespace Projekt_w69758_GL01_3IIZ
{
    partial class EnterVetInfoPopUp
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
            OwnerEmail = new Label();
            OwnerTelNumber = new Label();
            OwnerLastName = new Label();
            OwnerFirstName = new Label();
            OwnerEmailTextBox = new TextBox();
            OwnerNumberTextBox = new TextBox();
            OwnerLNameTextBox = new TextBox();
            OwnerFNameTextBox = new TextBox();
            button1 = new Button();
            label1 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // OwnerEmail
            // 
            OwnerEmail.AutoSize = true;
            OwnerEmail.Location = new Point(88, 242);
            OwnerEmail.Name = "OwnerEmail";
            OwnerEmail.Size = new Size(110, 20);
            OwnerEmail.TabIndex = 54;
            OwnerEmail.Text = "E-mail address:";
            // 
            // OwnerTelNumber
            // 
            OwnerTelNumber.AutoSize = true;
            OwnerTelNumber.Location = new Point(67, 183);
            OwnerTelNumber.Name = "OwnerTelNumber";
            OwnerTelNumber.Size = new Size(136, 20);
            OwnerTelNumber.TabIndex = 53;
            OwnerTelNumber.Text = "Telephone number:";
            // 
            // OwnerLastName
            // 
            OwnerLastName.AutoSize = true;
            OwnerLastName.Location = new Point(119, 129);
            OwnerLastName.Name = "OwnerLastName";
            OwnerLastName.Size = new Size(79, 20);
            OwnerLastName.TabIndex = 52;
            OwnerLastName.Text = "Last name:";
            // 
            // OwnerFirstName
            // 
            OwnerFirstName.AutoSize = true;
            OwnerFirstName.Location = new Point(118, 74);
            OwnerFirstName.Name = "OwnerFirstName";
            OwnerFirstName.Size = new Size(80, 20);
            OwnerFirstName.TabIndex = 51;
            OwnerFirstName.Text = "First name:";
            // 
            // OwnerEmailTextBox
            // 
            OwnerEmailTextBox.Location = new Point(219, 235);
            OwnerEmailTextBox.Margin = new Padding(3, 4, 3, 4);
            OwnerEmailTextBox.Name = "OwnerEmailTextBox";
            OwnerEmailTextBox.Size = new Size(114, 27);
            OwnerEmailTextBox.TabIndex = 50;
            // 
            // OwnerNumberTextBox
            // 
            OwnerNumberTextBox.Location = new Point(219, 176);
            OwnerNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            OwnerNumberTextBox.Name = "OwnerNumberTextBox";
            OwnerNumberTextBox.Size = new Size(114, 27);
            OwnerNumberTextBox.TabIndex = 49;
            // 
            // OwnerLNameTextBox
            // 
            OwnerLNameTextBox.Location = new Point(219, 122);
            OwnerLNameTextBox.Margin = new Padding(3, 4, 3, 4);
            OwnerLNameTextBox.Name = "OwnerLNameTextBox";
            OwnerLNameTextBox.Size = new Size(114, 27);
            OwnerLNameTextBox.TabIndex = 48;
            // 
            // OwnerFNameTextBox
            // 
            OwnerFNameTextBox.Location = new Point(219, 67);
            OwnerFNameTextBox.Margin = new Padding(3, 4, 3, 4);
            OwnerFNameTextBox.Name = "OwnerFNameTextBox";
            OwnerFNameTextBox.Size = new Size(114, 27);
            OwnerFNameTextBox.TabIndex = 47;
            // 
            // button1
            // 
            button1.Location = new Point(219, 374);
            button1.Name = "button1";
            button1.Size = new Size(280, 105);
            button1.TabIndex = 55;
            button1.Text = "Enter";
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(93, 296);
            label1.Name = "label1";
            label1.Size = new Size(105, 20);
            label1.TabIndex = 57;
            label1.Text = "Specialization:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(219, 289);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 56;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(12, 9);
            label2.Name = "label2";
            label2.Size = new Size(61, 35);
            label2.TabIndex = 58;
            label2.Text = "Vets";
            // 
            // EnterVetInfoPopUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 552);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Controls.Add(OwnerEmail);
            Controls.Add(OwnerTelNumber);
            Controls.Add(OwnerLastName);
            Controls.Add(OwnerFirstName);
            Controls.Add(OwnerEmailTextBox);
            Controls.Add(OwnerNumberTextBox);
            Controls.Add(OwnerLNameTextBox);
            Controls.Add(OwnerFNameTextBox);
            Name = "EnterVetInfoPopUp";
            Text = "EnterVetInfoPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label OwnerEmail;
        private Label OwnerTelNumber;
        private Label OwnerLastName;
        private Label OwnerFirstName;
        private TextBox OwnerEmailTextBox;
        private TextBox OwnerNumberTextBox;
        private TextBox OwnerLNameTextBox;
        private TextBox OwnerFNameTextBox;
        private Button button1;
        private Label label1;
        private TextBox textBox1;
        private Label label2;
    }
}