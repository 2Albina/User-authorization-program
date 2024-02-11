namespace DP1
{
    partial class Login
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
            this.AttemptLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.b_exit = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.Button();
            this.PasswordInput = new System.Windows.Forms.TextBox();
            this.LoginInput = new System.Windows.Forms.TextBox();
            this.label_pass = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AttemptLabel
            // 
            this.AttemptLabel.AutoSize = true;
            this.AttemptLabel.Location = new System.Drawing.Point(245, 154);
            this.AttemptLabel.Name = "AttemptLabel";
            this.AttemptLabel.Size = new System.Drawing.Size(14, 16);
            this.AttemptLabel.TabIndex = 16;
            this.AttemptLabel.Text = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 16);
            this.label1.TabIndex = 15;
            this.label1.Text = "Кол-во попыток для входа:";
            // 
            // b_exit
            // 
            this.b_exit.Location = new System.Drawing.Point(248, 214);
            this.b_exit.Name = "b_exit";
            this.b_exit.Size = new System.Drawing.Size(103, 43);
            this.b_exit.TabIndex = 14;
            this.b_exit.Text = "Отмена";
            this.b_exit.UseVisualStyleBackColor = true;
            this.b_exit.Click += new System.EventHandler(this.b_exit_Click);
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(85, 214);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(103, 43);
            this.b_login.TabIndex = 13;
            this.b_login.Text = "Войти";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // PasswordInput
            // 
            this.PasswordInput.Location = new System.Drawing.Point(225, 110);
            this.PasswordInput.Name = "PasswordInput";
            this.PasswordInput.PasswordChar = '*';
            this.PasswordInput.Size = new System.Drawing.Size(144, 22);
            this.PasswordInput.TabIndex = 12;
            // 
            // LoginInput
            // 
            this.LoginInput.Location = new System.Drawing.Point(225, 63);
            this.LoginInput.Name = "LoginInput";
            this.LoginInput.Size = new System.Drawing.Size(144, 22);
            this.LoginInput.TabIndex = 11;
            // 
            // label_pass
            // 
            this.label_pass.AutoSize = true;
            this.label_pass.Location = new System.Drawing.Point(56, 113);
            this.label_pass.Name = "label_pass";
            this.label_pass.Size = new System.Drawing.Size(56, 16);
            this.label_pass.TabIndex = 10;
            this.label_pass.Text = "Пароль";
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Location = new System.Drawing.Point(56, 66);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(129, 16);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Имя пользователя";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 308);
            this.Controls.Add(this.AttemptLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_exit);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.PasswordInput);
            this.Controls.Add(this.LoginInput);
            this.Controls.Add(this.label_pass);
            this.Controls.Add(this.label_login);
            this.Name = "Login";
            this.Text = "Вход в программу";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AttemptLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_exit;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.TextBox PasswordInput;
        private System.Windows.Forms.TextBox LoginInput;
        private System.Windows.Forms.Label label_pass;
        private System.Windows.Forms.Label label_login;
    }
}