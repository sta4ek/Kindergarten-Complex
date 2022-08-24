namespace KindergartenComplex
{
    partial class AuthForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthForm));
            this.buttonLogIn = new System.Windows.Forms.Button();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPasswordWarning = new System.Windows.Forms.Label();
            this.panelName = new System.Windows.Forms.Panel();
            this.labelName = new System.Windows.Forms.Label();
            this.panelPic = new System.Windows.Forms.Panel();
            this.panelName.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.Enabled = false;
            this.buttonLogIn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(222)))));
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.Black;
            this.buttonLogIn.Location = new System.Drawing.Point(144, 321);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.Size = new System.Drawing.Size(183, 51);
            this.buttonLogIn.TabIndex = 0;
            this.buttonLogIn.Text = "Войти";
            this.buttonLogIn.UseVisualStyleBackColor = true;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxLogin.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxLogin.Location = new System.Drawing.Point(196, 185);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(233, 33);
            this.textBoxLogin.TabIndex = 1;
            this.textBoxLogin.TextChanged += new System.EventHandler(this.textBoxLogin_TextChanged);
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPassword.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPassword.Location = new System.Drawing.Point(196, 253);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(233, 31);
            this.textBoxPassword.TabIndex = 2;
            this.textBoxPassword.UseSystemPasswordChar = true;
            this.textBoxPassword.TextChanged += new System.EventHandler(this.textBoxPassword_TextChanged);
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelLogin.Location = new System.Drawing.Point(17, 187);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(173, 25);
            this.labelLogin.TabIndex = 3;
            this.labelLogin.Text = "Имя пользователя";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPassword.Location = new System.Drawing.Point(112, 253);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(78, 25);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // labelPasswordWarning
            // 
            this.labelPasswordWarning.AutoSize = true;
            this.labelPasswordWarning.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPasswordWarning.ForeColor = System.Drawing.Color.Red;
            this.labelPasswordWarning.Location = new System.Drawing.Point(193, 287);
            this.labelPasswordWarning.Name = "labelPasswordWarning";
            this.labelPasswordWarning.Size = new System.Drawing.Size(145, 15);
            this.labelPasswordWarning.TabIndex = 5;
            this.labelPasswordWarning.Text = "Неверный логин/пароль";
            this.labelPasswordWarning.Visible = false;
            // 
            // panelName
            // 
            this.panelName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelName.Controls.Add(this.labelName);
            this.panelName.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelName.Location = new System.Drawing.Point(0, 0);
            this.panelName.Name = "panelName";
            this.panelName.Size = new System.Drawing.Size(709, 106);
            this.panelName.TabIndex = 6;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(491, 58);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "ГУО \"Ясли-сад №3 г.Мозыря\"";
            // 
            // panelPic
            // 
            this.panelPic.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(222)))));
            this.panelPic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelPic.BackgroundImage")));
            this.panelPic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panelPic.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelPic.Location = new System.Drawing.Point(455, 106);
            this.panelPic.Name = "panelPic";
            this.panelPic.Size = new System.Drawing.Size(254, 343);
            this.panelPic.TabIndex = 7;
            // 
            // AuthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(709, 449);
            this.Controls.Add(this.panelPic);
            this.Controls.Add(this.panelName);
            this.Controls.Add(this.labelPasswordWarning);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.buttonLogIn);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "AuthForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация | ";
            this.Load += new System.EventHandler(this.AuthForm_Load);
            this.VisibleChanged += new System.EventHandler(this.AuthForm_VisibleChanged);
            this.panelName.ResumeLayout(false);
            this.panelName.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonLogIn;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelPasswordWarning;
        private System.Windows.Forms.Panel panelName;
        private System.Windows.Forms.Panel panelPic;
        private System.Windows.Forms.Label labelName;
    }
}

