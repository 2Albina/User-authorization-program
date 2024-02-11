namespace DP1
{
    partial class Check
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
            this.LoginOutput = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.PasswordRestrictionCheckBox = new System.Windows.Forms.CheckBox();
            this.IsBlockedCheckBox = new System.Windows.Forms.CheckBox();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrevButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginOutput
            // 
            this.LoginOutput.Location = new System.Drawing.Point(224, 56);
            this.LoginOutput.Name = "LoginOutput";
            this.LoginOutput.Size = new System.Drawing.Size(144, 22);
            this.LoginOutput.TabIndex = 13;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(55, 59);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(129, 16);
            this.label_login.TabIndex = 12;
            this.label_login.Text = "Имя пользователя";
            // 
            // PasswordRestrictionCheckBox
            // 
            this.PasswordRestrictionCheckBox.Location = new System.Drawing.Point(224, 138);
            this.PasswordRestrictionCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordRestrictionCheckBox.Name = "PasswordRestrictionCheckBox";
            this.PasswordRestrictionCheckBox.Size = new System.Drawing.Size(208, 30);
            this.PasswordRestrictionCheckBox.TabIndex = 15;
            this.PasswordRestrictionCheckBox.Text = "Ограничения на пароль";
            this.PasswordRestrictionCheckBox.UseVisualStyleBackColor = true;
            // 
            // IsBlockedCheckBox
            // 
            this.IsBlockedCheckBox.Location = new System.Drawing.Point(224, 100);
            this.IsBlockedCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.IsBlockedCheckBox.Name = "IsBlockedCheckBox";
            this.IsBlockedCheckBox.Size = new System.Drawing.Size(160, 30);
            this.IsBlockedCheckBox.TabIndex = 14;
            this.IsBlockedCheckBox.Text = "Заблокировать";
            this.IsBlockedCheckBox.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(334, 191);
            this.NextButton.Margin = new System.Windows.Forms.Padding(4);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 28);
            this.NextButton.TabIndex = 18;
            this.NextButton.Text = "Следующий";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // PrevButton
            // 
            this.PrevButton.Location = new System.Drawing.Point(58, 191);
            this.PrevButton.Margin = new System.Windows.Forms.Padding(4);
            this.PrevButton.Name = "PrevButton";
            this.PrevButton.Size = new System.Drawing.Size(100, 28);
            this.PrevButton.TabIndex = 17;
            this.PrevButton.Text = "Предыдущий";
            this.PrevButton.UseVisualStyleBackColor = true;
            this.PrevButton.Click += new System.EventHandler(this.PrevButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(166, 191);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(4);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(160, 28);
            this.SaveButton.TabIndex = 16;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 255);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 47);
            this.button1.TabIndex = 19;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Check
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 354);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PrevButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.PasswordRestrictionCheckBox);
            this.Controls.Add(this.IsBlockedCheckBox);
            this.Controls.Add(this.LoginOutput);
            this.Controls.Add(this.label_login);
            this.Name = "Check";
            this.Text = "Список пользователей";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LoginOutput;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.CheckBox PasswordRestrictionCheckBox;
        private System.Windows.Forms.CheckBox IsBlockedCheckBox;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrevButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
    }
}