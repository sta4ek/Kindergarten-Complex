namespace KindergartenComplex
{
    partial class EditAccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditAccountForm));
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxOldPassword = new System.Windows.Forms.TextBox();
            this.textBoxNewPassword = new System.Windows.Forms.TextBox();
            this.textBoxConfirmationNewPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelOldPassword = new System.Windows.Forms.Label();
            this.labelNewPassword = new System.Windows.Forms.Label();
            this.labelConfirmationNewPassword = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelPasswordsAreNotMatching = new System.Windows.Forms.Label();
            this.labelWrongOldPassword = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelLoginIsNotAvailable = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Location = new System.Drawing.Point(316, 138);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(300, 33);
            this.textBoxLogin.TabIndex = 0;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxOldPassword
            // 
            this.textBoxOldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxOldPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxOldPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxOldPassword.Location = new System.Drawing.Point(316, 220);
            this.textBoxOldPassword.Name = "textBoxOldPassword";
            this.textBoxOldPassword.Size = new System.Drawing.Size(300, 31);
            this.textBoxOldPassword.TabIndex = 1;
            this.textBoxOldPassword.UseSystemPasswordChar = true;
            this.textBoxOldPassword.TextChanged += new System.EventHandler(this.textBoxOldPassword_TextChanged);
            // 
            // textBoxNewPassword
            // 
            this.textBoxNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxNewPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNewPassword.Location = new System.Drawing.Point(316, 276);
            this.textBoxNewPassword.Name = "textBoxNewPassword";
            this.textBoxNewPassword.Size = new System.Drawing.Size(300, 31);
            this.textBoxNewPassword.TabIndex = 2;
            this.textBoxNewPassword.UseSystemPasswordChar = true;
            this.textBoxNewPassword.TextChanged += new System.EventHandler(this.textBoxNewPassword_TextChanged);
            // 
            // textBoxConfirmationNewPassword
            // 
            this.textBoxConfirmationNewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxConfirmationNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxConfirmationNewPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxConfirmationNewPassword.Location = new System.Drawing.Point(316, 329);
            this.textBoxConfirmationNewPassword.Name = "textBoxConfirmationNewPassword";
            this.textBoxConfirmationNewPassword.Size = new System.Drawing.Size(300, 31);
            this.textBoxConfirmationNewPassword.TabIndex = 3;
            this.textBoxConfirmationNewPassword.UseSystemPasswordChar = true;
            this.textBoxConfirmationNewPassword.TextChanged += new System.EventHandler(this.textBoxConfirmationNewPassword_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(137, 140);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(173, 25);
            this.labelLogin.TabIndex = 4;
            this.labelLogin.Text = "Имя пользователя";
            // 
            // labelOldPassword
            // 
            this.labelOldPassword.AutoSize = true;
            this.labelOldPassword.Location = new System.Drawing.Point(165, 222);
            this.labelOldPassword.Name = "labelOldPassword";
            this.labelOldPassword.Size = new System.Drawing.Size(145, 25);
            this.labelOldPassword.TabIndex = 5;
            this.labelOldPassword.Text = "Старый пароль";
            // 
            // labelNewPassword
            // 
            this.labelNewPassword.AutoSize = true;
            this.labelNewPassword.Location = new System.Drawing.Point(172, 278);
            this.labelNewPassword.Name = "labelNewPassword";
            this.labelNewPassword.Size = new System.Drawing.Size(138, 25);
            this.labelNewPassword.TabIndex = 6;
            this.labelNewPassword.Text = "Новый пароль";
            // 
            // labelConfirmationNewPassword
            // 
            this.labelConfirmationNewPassword.AutoSize = true;
            this.labelConfirmationNewPassword.Location = new System.Drawing.Point(24, 331);
            this.labelConfirmationNewPassword.Name = "labelConfirmationNewPassword";
            this.labelConfirmationNewPassword.Size = new System.Drawing.Size(286, 25);
            this.labelConfirmationNewPassword.TabIndex = 7;
            this.labelConfirmationNewPassword.Text = "Подтверждение нового пароля";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(494, 391);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 13;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(316, 391);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(122, 63);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelPasswordsAreNotMatching
            // 
            this.labelPasswordsAreNotMatching.AutoSize = true;
            this.labelPasswordsAreNotMatching.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordsAreNotMatching.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordsAreNotMatching.Location = new System.Drawing.Point(313, 360);
            this.labelPasswordsAreNotMatching.Name = "labelPasswordsAreNotMatching";
            this.labelPasswordsAreNotMatching.Size = new System.Drawing.Size(146, 18);
            this.labelPasswordsAreNotMatching.TabIndex = 66;
            this.labelPasswordsAreNotMatching.Text = "Пароли не совпадают";
            this.labelPasswordsAreNotMatching.Visible = false;
            // 
            // labelWrongOldPassword
            // 
            this.labelWrongOldPassword.AutoSize = true;
            this.labelWrongOldPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWrongOldPassword.ForeColor = System.Drawing.Color.Red;
            this.labelWrongOldPassword.Location = new System.Drawing.Point(313, 251);
            this.labelWrongOldPassword.Name = "labelWrongOldPassword";
            this.labelWrongOldPassword.Size = new System.Drawing.Size(123, 18);
            this.labelWrongOldPassword.TabIndex = 67;
            this.labelWrongOldPassword.Text = "Неверный пароль";
            this.labelWrongOldPassword.Visible = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(639, 98);
            this.panelHeader.TabIndex = 68;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(200, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(440, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Редактирование профиля";
            // 
            // labelLoginIsNotAvailable
            // 
            this.labelLoginIsNotAvailable.AutoSize = true;
            this.labelLoginIsNotAvailable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginIsNotAvailable.ForeColor = System.Drawing.Color.Red;
            this.labelLoginIsNotAvailable.Location = new System.Drawing.Point(313, 171);
            this.labelLoginIsNotAvailable.Name = "labelLoginIsNotAvailable";
            this.labelLoginIsNotAvailable.Size = new System.Drawing.Size(171, 18);
            this.labelLoginIsNotAvailable.TabIndex = 69;
            this.labelLoginIsNotAvailable.Text = "Имя пользователя занято";
            this.labelLoginIsNotAvailable.Visible = false;
            // 
            // EditAccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(639, 479);
            this.Controls.Add(this.labelLoginIsNotAvailable);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelWrongOldPassword);
            this.Controls.Add(this.labelPasswordsAreNotMatching);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelConfirmationNewPassword);
            this.Controls.Add(this.labelNewPassword);
            this.Controls.Add(this.labelOldPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxConfirmationNewPassword);
            this.Controls.Add(this.textBoxNewPassword);
            this.Controls.Add(this.textBoxOldPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "EditAccountForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование профиля | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxOldPassword;
        private System.Windows.Forms.TextBox textBoxNewPassword;
        private System.Windows.Forms.TextBox textBoxConfirmationNewPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelOldPassword;
        private System.Windows.Forms.Label labelNewPassword;
        private System.Windows.Forms.Label labelConfirmationNewPassword;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelPasswordsAreNotMatching;
        private System.Windows.Forms.Label labelWrongOldPassword;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelLoginIsNotAvailable;
    }
}