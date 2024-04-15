namespace ListPersonApp
{
    partial class MainForm
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
            AddButton = new Button();
            label1 = new Label();
            usersAmount = new TextBox();
            PanelUsers = new FlowLayoutPanel();
            ageSum = new TextBox();
            label2 = new Label();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Location = new Point(65, 31);
            AddButton.Margin = new Padding(2);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(83, 22);
            AddButton.TabIndex = 0;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += Add_button;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(196, 31);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 1;
            label1.Text = "Количество записей";
            // 
            // usersAmount
            // 
            usersAmount.Location = new Point(349, 31);
            usersAmount.Margin = new Padding(2);
            usersAmount.Name = "usersAmount";
            usersAmount.ReadOnly = true;
            usersAmount.Size = new Size(110, 23);
            usersAmount.TabIndex = 2;
            // 
            // PanelUsers
            // 
            PanelUsers.AutoScroll = true;
            PanelUsers.BackColor = Color.White;
            PanelUsers.Location = new Point(22, 95);
            PanelUsers.Margin = new Padding(2);
            PanelUsers.MaximumSize = new Size(771, 355);
            PanelUsers.Name = "PanelUsers";
            PanelUsers.Size = new Size(771, 355);
            PanelUsers.TabIndex = 3;
            // 
            // ageSum
            // 
            ageSum.Location = new Point(631, 31);
            ageSum.Margin = new Padding(2);
            ageSum.Name = "ageSum";
            ageSum.ReadOnly = true;
            ageSum.Size = new Size(110, 23);
            ageSum.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(517, 34);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 15);
            label2.TabIndex = 4;
            label2.Text = "Количество лет";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(816, 461);
            Controls.Add(ageSum);
            Controls.Add(label2);
            Controls.Add(PanelUsers);
            Controls.Add(usersAmount);
            Controls.Add(label1);
            Controls.Add(AddButton);
            Margin = new Padding(2);
            Name = "MainForm";
            Text = "Список пользователей";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddButton;
        private Label label1;
        private TextBox usersAmount;
        private FlowLayoutPanel PanelUsers;
        private TextBox ageSum;
        private Label label2;
    }
}