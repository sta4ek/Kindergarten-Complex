namespace KindergartenComplex.Manager_Forms.User_Registration
{
    partial class RegistrationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistrationForm));
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPasswordConfirmation = new System.Windows.Forms.TextBox();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordConfirmation = new System.Windows.Forms.Label();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelPasswordsAreNotMatching = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelLoginIsNotAvailable = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(242, 128);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(300, 33);
            this.comboBoxEmployee.TabIndex = 55;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(242, 188);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(300, 33);
            this.textBoxLogin.TabIndex = 56;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(242, 246);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(300, 31);
            this.textBoxPassword.TabIndex = 57;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // textBoxPasswordConfirmation
            // 
            this.textBoxPasswordConfirmation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxPasswordConfirmation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPasswordConfirmation.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPasswordConfirmation.Location = new System.Drawing.Point(242, 304);
            this.textBoxPasswordConfirmation.Name = "textBoxPasswordConfirmation";
            this.textBoxPasswordConfirmation.Size = new System.Drawing.Size(300, 31);
            this.textBoxPasswordConfirmation.TabIndex = 58;
            this.textBoxPasswordConfirmation.UseSystemPasswordChar = true;
            this.textBoxPasswordConfirmation.TextChanged += new System.EventHandler(this.textBoxPasswordConfirmation_TextChanged);
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.Location = new System.Drawing.Point(132, 131);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(104, 25);
            this.labelEmployee.TabIndex = 59;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(63, 190);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(173, 25);
            this.labelLogin.TabIndex = 60;
            this.labelLogin.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(158, 248);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 25);
            this.labelPassword.TabIndex = 61;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordConfirmation
            // 
            this.labelPasswordConfirmation.AutoSize = true;
            this.labelPasswordConfirmation.Location = new System.Drawing.Point(16, 306);
            this.labelPasswordConfirmation.Name = "labelPasswordConfirmation";
            this.labelPasswordConfirmation.Size = new System.Drawing.Size(220, 25);
            this.labelPasswordConfirmation.TabIndex = 62;
            this.labelPasswordConfirmation.Text = "Подтверждение пароля";
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Location = new System.Drawing.Point(412, 373);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(130, 63);
            this.buttonCancel.TabIndex = 63;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Enabled = false;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Location = new System.Drawing.Point(242, 373);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(138, 63);
            this.buttonRegister.TabIndex = 64;
            this.buttonRegister.Text = "Регистрация";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelPasswordsAreNotMatching
            // 
            this.labelPasswordsAreNotMatching.AutoSize = true;
            this.labelPasswordsAreNotMatching.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordsAreNotMatching.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordsAreNotMatching.Location = new System.Drawing.Point(239, 340);
            this.labelPasswordsAreNotMatching.Name = "labelPasswordsAreNotMatching";
            this.labelPasswordsAreNotMatching.Size = new System.Drawing.Size(146, 18);
            this.labelPasswordsAreNotMatching.TabIndex = 65;
            this.labelPasswordsAreNotMatching.Text = "Пароли не совпадают";
            this.labelPasswordsAreNotMatching.Visible = false;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(566, 98);
            this.panelHeader.TabIndex = 66;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(115, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(451, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Регистрация пользователя";
            // 
            // labelLoginIsNotAvailable
            // 
            this.labelLoginIsNotAvailable.AutoSize = true;
            this.labelLoginIsNotAvailable.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLoginIsNotAvailable.ForeColor = System.Drawing.Color.Red;
            this.labelLoginIsNotAvailable.Location = new System.Drawing.Point(239, 221);
            this.labelLoginIsNotAvailable.Name = "labelLoginIsNotAvailable";
            this.labelLoginIsNotAvailable.Size = new System.Drawing.Size(171, 18);
            this.labelLoginIsNotAvailable.TabIndex = 67;
            this.labelLoginIsNotAvailable.Text = "Имя пользователя занято";
            this.labelLoginIsNotAvailable.Visible = false;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(566, 480);
            this.Controls.Add(this.labelLoginIsNotAvailable);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelPasswordsAreNotMatching);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelPasswordConfirmation);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.textBoxPasswordConfirmation);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.comboBoxEmployee);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация пользователя | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxPasswordConfirmation;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordConfirmation;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelPasswordsAreNotMatching;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelLoginIsNotAvailable;
    }
}