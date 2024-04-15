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
            label1 = new Label();
            label2 = new Label();
            surnameText = new TextBox();
            label3 = new Label();
            nameText = new TextBox();
            label4 = new Label();
            lastNameText = new TextBox();
            label5 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(18, 10);
            label1.Name = "label1";
            label1.Size = new Size(58, 21);
            label1.TabIndex = 1;
            label1.Text = "Номер";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(106, 10);
            label2.Name = "label2";
            label2.Size = new Size(75, 21);
            label2.TabIndex = 3;
            label2.Text = "Фамилия";
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
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(271, 10);
            label3.Name = "label3";
            label3.Size = new Size(41, 21);
            label3.TabIndex = 5;
            label3.Text = "Имя";
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
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(401, 10);
            label4.Name = "label4";
            label4.Size = new Size(77, 21);
            label4.TabIndex = 7;
            label4.Text = "Отчество";
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
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(531, 10);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 9;
            label5.Text = "Возраст";
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
            Controls.Add(label5);
            Controls.Add(ageText);
            Controls.Add(label4);
            Controls.Add(lastNameText);
            Controls.Add(label3);
            Controls.Add(nameText);
            Controls.Add(label2);
            Controls.Add(surnameText);
            Controls.Add(label1);
            Controls.Add(idText);
            Margin = new Padding(3, 2, 3, 2);
            Name = "PersonUserControl";
            Size = new Size(737, 83);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idText;
        private Label label1;
        private Label label2;
        private TextBox surnameText;
        private Label label3;
        private TextBox nameText;
        private Label label4;
        private TextBox lastNameText;
        private Label label5;
        private TextBox ageText;
        private Button buttonEdit;
        private Button buttonDel;
    }
}