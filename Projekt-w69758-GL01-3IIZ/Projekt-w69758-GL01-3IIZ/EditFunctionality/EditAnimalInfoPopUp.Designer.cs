namespace Projekt_w69758_GL01_3IIZ.EditFunctionality
{
    partial class EditAnimalInfoPopUp
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
            UpdateAnimalInfo = new Button();
            OwnerEmail = new Label();
            OwnerTelNumber = new Label();
            OwnerLastName = new Label();
            OwnerFirstName = new Label();
            AnimalAge = new Label();
            AnimalBreed = new Label();
            AnimalSpecies = new Label();
            AnimalName = new Label();
            OwnerEmailTextBox = new TextBox();
            OwnerNumberTextBox = new TextBox();
            OwnerLNameTextBox = new TextBox();
            OwnerFNameTextBox = new TextBox();
            label3 = new Label();
            label2 = new Label();
            AnimalAgeTextBox = new TextBox();
            AnimalBreedTextBox = new TextBox();
            AnimalSepciesTextBox = new TextBox();
            AnimalNameTextBox = new TextBox();
            SuspendLayout();
            // 
            // UpdateAnimalInfo
            // 
            UpdateAnimalInfo.Location = new Point(218, 289);
            UpdateAnimalInfo.Margin = new Padding(3, 2, 3, 2);
            UpdateAnimalInfo.Name = "UpdateAnimalInfo";
            UpdateAnimalInfo.Size = new Size(251, 91);
            UpdateAnimalInfo.TabIndex = 61;
            UpdateAnimalInfo.Text = "Update";
            UpdateAnimalInfo.UseVisualStyleBackColor = true;
            UpdateAnimalInfo.Click += UpdateAnimalInfo_Click;
            // 
            // OwnerEmail
            // 
            OwnerEmail.AutoSize = true;
            OwnerEmail.Location = new Point(356, 214);
            OwnerEmail.Name = "OwnerEmail";
            OwnerEmail.Size = new Size(87, 15);
            OwnerEmail.TabIndex = 60;
            OwnerEmail.Text = "E-mail address:";
            // 
            // OwnerTelNumber
            // 
            OwnerTelNumber.AutoSize = true;
            OwnerTelNumber.Location = new Point(333, 170);
            OwnerTelNumber.Name = "OwnerTelNumber";
            OwnerTelNumber.Size = new Size(109, 15);
            OwnerTelNumber.TabIndex = 59;
            OwnerTelNumber.Text = "Telephone number:";
            // 
            // OwnerLastName
            // 
            OwnerLastName.AutoSize = true;
            OwnerLastName.Location = new Point(383, 127);
            OwnerLastName.Name = "OwnerLastName";
            OwnerLastName.Size = new Size(64, 15);
            OwnerLastName.TabIndex = 58;
            OwnerLastName.Text = "Last name:";
            // 
            // OwnerFirstName
            // 
            OwnerFirstName.AutoSize = true;
            OwnerFirstName.Location = new Point(383, 88);
            OwnerFirstName.Name = "OwnerFirstName";
            OwnerFirstName.Size = new Size(65, 15);
            OwnerFirstName.TabIndex = 57;
            OwnerFirstName.Text = "First name:";
            // 
            // AnimalAge
            // 
            AnimalAge.AutoSize = true;
            AnimalAge.Location = new Point(88, 214);
            AnimalAge.Name = "AnimalAge";
            AnimalAge.Size = new Size(31, 15);
            AnimalAge.TabIndex = 56;
            AnimalAge.Text = "Age:";
            // 
            // AnimalBreed
            // 
            AnimalBreed.AutoSize = true;
            AnimalBreed.Location = new Point(77, 170);
            AnimalBreed.Name = "AnimalBreed";
            AnimalBreed.Size = new Size(40, 15);
            AnimalBreed.TabIndex = 55;
            AnimalBreed.Text = "Breed:";
            // 
            // AnimalSpecies
            // 
            AnimalSpecies.AutoSize = true;
            AnimalSpecies.Location = new Point(68, 129);
            AnimalSpecies.Name = "AnimalSpecies";
            AnimalSpecies.Size = new Size(49, 15);
            AnimalSpecies.TabIndex = 54;
            AnimalSpecies.Text = "Species:";
            // 
            // AnimalName
            // 
            AnimalName.AutoSize = true;
            AnimalName.Location = new Point(76, 88);
            AnimalName.Name = "AnimalName";
            AnimalName.Size = new Size(42, 15);
            AnimalName.TabIndex = 53;
            AnimalName.Text = "Name:";
            // 
            // OwnerEmailTextBox
            // 
            OwnerEmailTextBox.Location = new Point(462, 209);
            OwnerEmailTextBox.Name = "OwnerEmailTextBox";
            OwnerEmailTextBox.Size = new Size(100, 23);
            OwnerEmailTextBox.TabIndex = 52;
            // 
            // OwnerNumberTextBox
            // 
            OwnerNumberTextBox.Location = new Point(462, 164);
            OwnerNumberTextBox.Name = "OwnerNumberTextBox";
            OwnerNumberTextBox.Size = new Size(100, 23);
            OwnerNumberTextBox.TabIndex = 51;
            // 
            // OwnerLNameTextBox
            // 
            OwnerLNameTextBox.Location = new Point(462, 124);
            OwnerLNameTextBox.Name = "OwnerLNameTextBox";
            OwnerLNameTextBox.Size = new Size(100, 23);
            OwnerLNameTextBox.TabIndex = 50;
            // 
            // OwnerFNameTextBox
            // 
            OwnerFNameTextBox.Location = new Point(462, 83);
            OwnerFNameTextBox.Name = "OwnerFNameTextBox";
            OwnerFNameTextBox.Size = new Size(100, 23);
            OwnerFNameTextBox.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F);
            label3.Location = new Point(446, 42);
            label3.Name = "label3";
            label3.Size = new Size(108, 28);
            label3.TabIndex = 48;
            label3.Text = "Owner info";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(115, 42);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 47;
            label2.Text = "Animal info";
            // 
            // AnimalAgeTextBox
            // 
            AnimalAgeTextBox.Location = new Point(127, 209);
            AnimalAgeTextBox.Name = "AnimalAgeTextBox";
            AnimalAgeTextBox.Size = new Size(100, 23);
            AnimalAgeTextBox.TabIndex = 46;
            // 
            // AnimalBreedTextBox
            // 
            AnimalBreedTextBox.Location = new Point(127, 164);
            AnimalBreedTextBox.Name = "AnimalBreedTextBox";
            AnimalBreedTextBox.Size = new Size(100, 23);
            AnimalBreedTextBox.TabIndex = 45;
            // 
            // AnimalSepciesTextBox
            // 
            AnimalSepciesTextBox.Location = new Point(127, 124);
            AnimalSepciesTextBox.Name = "AnimalSepciesTextBox";
            AnimalSepciesTextBox.Size = new Size(100, 23);
            AnimalSepciesTextBox.TabIndex = 44;
            // 
            // AnimalNameTextBox
            // 
            AnimalNameTextBox.Location = new Point(127, 83);
            AnimalNameTextBox.Name = "AnimalNameTextBox";
            AnimalNameTextBox.Size = new Size(100, 23);
            AnimalNameTextBox.TabIndex = 43;
            // 
            // EditAnimalInfoPopUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 414);
            Controls.Add(UpdateAnimalInfo);
            Controls.Add(OwnerEmail);
            Controls.Add(OwnerTelNumber);
            Controls.Add(OwnerLastName);
            Controls.Add(OwnerFirstName);
            Controls.Add(AnimalAge);
            Controls.Add(AnimalBreed);
            Controls.Add(AnimalSpecies);
            Controls.Add(AnimalName);
            Controls.Add(OwnerEmailTextBox);
            Controls.Add(OwnerNumberTextBox);
            Controls.Add(OwnerLNameTextBox);
            Controls.Add(OwnerFNameTextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AnimalAgeTextBox);
            Controls.Add(AnimalBreedTextBox);
            Controls.Add(AnimalSepciesTextBox);
            Controls.Add(AnimalNameTextBox);
            Name = "EditAnimalInfoPopUp";
            Text = "EditAnimalInfoPopUp";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button UpdateAnimalInfo;
        private Label OwnerEmail;
        private Label OwnerTelNumber;
        private Label OwnerLastName;
        private Label OwnerFirstName;
        private Label AnimalAge;
        private Label AnimalBreed;
        private Label AnimalSpecies;
        private Label AnimalName;
        private TextBox OwnerEmailTextBox;
        private TextBox OwnerNumberTextBox;
        private TextBox OwnerLNameTextBox;
        private TextBox OwnerFNameTextBox;
        private Label label3;
        private Label label2;
        private TextBox AnimalAgeTextBox;
        private TextBox AnimalBreedTextBox;
        private TextBox AnimalSepciesTextBox;
        private TextBox AnimalNameTextBox;
    }
}