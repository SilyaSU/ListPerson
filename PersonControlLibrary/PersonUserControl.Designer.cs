namespace PersonControlLib
{
    partial class PersonUserControl
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
            idText = new TextBox();
            IDLabel = new Label();
            SurnameLabel = new Label();
            surnameText = new TextBox();
            NameLabel = new Label();
            nameText = new TextBox();
            LastNameLabel = new Label();
            lastNameText = new TextBox();
            AgeLabel = new Label();
            ageText = new TextBox();
            buttonEdit = new Button();
            buttonDel = new Button();
            SuspendLayout();
            // 
            // idText
            // 
            idText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            idText.Location = new Point(28, 40);
            idText.Margin = new Padding(3, 2, 3, 2);
            idText.Name = "idText";
            idText.ReadOnly = true;
            idText.Size = new Size(47, 29);
            idText.TabIndex = 0;
            // 
            // IDLabel
            // 
            IDLabel.AutoSize = true;
            IDLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            IDLabel.Location = new Point(28, 10);
            IDLabel.Name = "IDLabel";
            IDLabel.Size = new Size(25, 21);
            IDLabel.TabIndex = 1;
            IDLabel.Text = "ID";
            // 
            // SurnameLabel
            // 
            SurnameLabel.AutoSize = true;
            SurnameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            SurnameLabel.Location = new Point(106, 10);
            SurnameLabel.Name = "SurnameLabel";
            SurnameLabel.Size = new Size(75, 21);
            SurnameLabel.TabIndex = 3;
            SurnameLabel.Text = "Фамилия";
            // 
            // surnameText
            // 
            surnameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            surnameText.Location = new Point(88, 40);
            surnameText.Margin = new Padding(3, 2, 3, 2);
            surnameText.Name = "surnameText";
            surnameText.ReadOnly = true;
            surnameText.Size = new Size(132, 29);
            surnameText.TabIndex = 2;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            NameLabel.Location = new Point(271, 10);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(41, 21);
            NameLabel.TabIndex = 5;
            NameLabel.Text = "Имя";
            // 
            // nameText
            // 
            nameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            nameText.Location = new Point(233, 40);
            nameText.Margin = new Padding(3, 2, 3, 2);
            nameText.Name = "nameText";
            nameText.ReadOnly = true;
            nameText.Size = new Size(132, 29);
            nameText.TabIndex = 4;
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            LastNameLabel.Location = new Point(401, 10);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(77, 21);
            LastNameLabel.TabIndex = 7;
            LastNameLabel.Text = "Отчество";
            // 
            // lastNameText
            // 
            lastNameText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lastNameText.Location = new Point(378, 40);
            lastNameText.Margin = new Padding(3, 2, 3, 2);
            lastNameText.Name = "lastNameText";
            lastNameText.ReadOnly = true;
            lastNameText.Size = new Size(132, 29);
            lastNameText.TabIndex = 6;
            // 
            // AgeLabel
            // 
            AgeLabel.AutoSize = true;
            AgeLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            AgeLabel.Location = new Point(531, 10);
            AgeLabel.Name = "AgeLabel";
            AgeLabel.Size = new Size(66, 21);
            AgeLabel.TabIndex = 9;
            AgeLabel.Text = "Возраст";
            // 
            // ageText
            // 
            ageText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            ageText.Location = new Point(522, 40);
            ageText.Margin = new Padding(3, 2, 3, 2);
            ageText.Name = "ageText";
            ageText.ReadOnly = true;
            ageText.Size = new Size(82, 29);
            ageText.TabIndex = 8;
            // 
            // buttonEdit
            // 
            buttonEdit.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEdit.Location = new Point(623, 14);
            buttonEdit.Margin = new Padding(3, 2, 3, 2);
            buttonEdit.Name = "buttonEdit";
            buttonEdit.Size = new Size(104, 28);
            buttonEdit.TabIndex = 10;
            buttonEdit.Text = "Изменить";
            buttonEdit.UseVisualStyleBackColor = true;
            // 
            // buttonDel
            // 
            buttonDel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDel.Location = new Point(623, 46);
            buttonDel.Margin = new Padding(3, 2, 3, 2);
            buttonDel.Name = "buttonDel";
            buttonDel.Size = new Size(104, 28);
            buttonDel.TabIndex = 11;
            buttonDel.Text = "Удалить";
            buttonDel.UseVisualStyleBackColor = true;
            // 
            // PersonUserControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(buttonDel);
            Controls.Add(buttonEdit);
            Controls.Add(AgeLabel);
            Controls.Add(ageText);
            Controls.Add(LastNameLabel);
            Controls.Add(lastNameText);
            Controls.Add(NameLabel);
            Controls.Add(nameText);
            Controls.Add(SurnameLabel);
            Controls.Add(surnameText);
            Controls.Add(IDLabel);
            Controls.Add(idText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonUserControl";
            Size = new Size(737, 83);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private Label IDLabel;
        private Label SurnameLabel;
        private TextBox surnameText;
        private Label NameLabel;
        private TextBox nameText;
        private Label LastNameLabel;
        private TextBox lastNameText;
        private Label AgeLabel;
        private TextBox ageText;
        private Button buttonEdit;
        private Button buttonDel;
    }
}