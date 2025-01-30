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
            AnimalAge = new Label();
            AnimalBreed = new Label();
            AnimalSpecies = new Label();
            AnimalName = new Label();
            label2 = new Label();
            AnimalAgeTextBox = new TextBox();
            VisitDescriptionTextBox = new TextBox();
            AnimalNameTextBox = new TextBox();
            button3 = new Button();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            VetChooseComboBox = new ComboBox();
            ChooseAnimalVisitButton = new Button();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AnimalAge
            // 
            AnimalAge.AutoSize = true;
            AnimalAge.Location = new Point(357, 117);
            AnimalAge.Name = "AnimalAge";
            AnimalAge.Size = new Size(48, 15);
            AnimalAge.TabIndex = 42;
            AnimalAge.Text = "Animal:";
            // 
            // AnimalBreed
            // 
            AnimalBreed.AutoSize = true;
            AnimalBreed.Location = new Point(357, 81);
            AnimalBreed.Name = "AnimalBreed";
            AnimalBreed.Size = new Size(26, 15);
            AnimalBreed.TabIndex = 41;
            AnimalBreed.Text = "Vet:";
            // 
            // AnimalSpecies
            // 
            AnimalSpecies.AutoSize = true;
            AnimalSpecies.Location = new Point(35, 149);
            AnimalSpecies.Name = "AnimalSpecies";
            AnimalSpecies.Size = new Size(70, 15);
            AnimalSpecies.TabIndex = 40;
            AnimalSpecies.Text = "Description:";
            // 
            // AnimalName
            // 
            AnimalName.AutoSize = true;
            AnimalName.Location = new Point(31, 98);
            AnimalName.Name = "AnimalName";
            AnimalName.Size = new Size(53, 15);
            AnimalName.TabIndex = 39;
            AnimalName.Text = "Purpose:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15F);
            label2.Location = new Point(382, 32);
            label2.Name = "label2";
            label2.Size = new Size(112, 28);
            label2.TabIndex = 33;
            label2.Text = "Animal info";
            // 
            // AnimalAgeTextBox
            // 
            AnimalAgeTextBox.Location = new Point(411, 109);
            AnimalAgeTextBox.Name = "AnimalAgeTextBox";
            AnimalAgeTextBox.Size = new Size(137, 23);
            AnimalAgeTextBox.TabIndex = 32;
            // 
            // VisitDescriptionTextBox
            // 
            VisitDescriptionTextBox.Location = new Point(35, 167);
            VisitDescriptionTextBox.Multiline = true;
            VisitDescriptionTextBox.Name = "VisitDescriptionTextBox";
            VisitDescriptionTextBox.Size = new Size(297, 128);
            VisitDescriptionTextBox.TabIndex = 30;
            VisitDescriptionTextBox.TextChanged += AnimalSepciesTextBox_TextChanged;
            // 
            // AnimalNameTextBox
            // 
            AnimalNameTextBox.Location = new Point(90, 95);
            AnimalNameTextBox.Name = "AnimalNameTextBox";
            AnimalNameTextBox.Size = new Size(100, 23);
            AnimalNameTextBox.TabIndex = 29;
            // 
            // button3
            // 
            button3.Location = new Point(713, 248);
            button3.Name = "button3";
            button3.Size = new Size(131, 47);
            button3.TabIndex = 28;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(382, 248);
            button1.Name = "button1";
            button1.Size = new Size(131, 47);
            button1.TabIndex = 27;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Location = new Point(543, 248);
            button2.Name = "button2";
            button2.Size = new Size(131, 47);
            button2.TabIndex = 26;
            button2.Text = "Edit";
            button2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(34, 316);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(908, 261);
            dataGridView1.TabIndex = 25;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(34, 32);
            label1.Name = "label1";
            label1.Size = new Size(57, 28);
            label1.TabIndex = 24;
            label1.Text = "Visits";
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(61, 4);
            // 
            // VetChooseComboBox
            // 
            VetChooseComboBox.FormattingEnabled = true;
            VetChooseComboBox.Location = new Point(389, 76);
            VetChooseComboBox.Name = "VetChooseComboBox";
            VetChooseComboBox.Size = new Size(204, 23);
            VetChooseComboBox.TabIndex = 49;
            // 
            // ChooseAnimalVisitButton
            // 
            ChooseAnimalVisitButton.Location = new Point(554, 109);
            ChooseAnimalVisitButton.Name = "ChooseAnimalVisitButton";
            ChooseAnimalVisitButton.Size = new Size(76, 23);
            ChooseAnimalVisitButton.TabIndex = 50;
            ChooseAnimalVisitButton.Text = "Choose";
            ChooseAnimalVisitButton.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(687, 76);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 51;
            label3.Text = "Procedure:";
            // 
            // Visits
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(ChooseAnimalVisitButton);
            Controls.Add(VetChooseComboBox);
            Controls.Add(AnimalAge);
            Controls.Add(AnimalBreed);
            Controls.Add(AnimalSpecies);
            Controls.Add(AnimalName);
            Controls.Add(label2);
            Controls.Add(AnimalAgeTextBox);
            Controls.Add(VisitDescriptionTextBox);
            Controls.Add(AnimalNameTextBox);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(label1);
            Name = "Visits";
            Size = new Size(977, 608);
            Load += Visits_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label AnimalAge;
        private Label AnimalBreed;
        private Label AnimalSpecies;
        private Label AnimalName;
        private Label label2;
        private TextBox AnimalAgeTextBox;
        private TextBox VisitDescriptionTextBox;
        private TextBox AnimalNameTextBox;
        private Button button3;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private Label label1;
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ComboBox VetChooseComboBox;
        private Button ChooseAnimalVisitButton;
        private Label label3;
    }
}
