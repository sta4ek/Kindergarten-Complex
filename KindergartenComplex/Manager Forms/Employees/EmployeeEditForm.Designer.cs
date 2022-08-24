namespace KindergartenComplex.Manager_Forms.Employees
{
    partial class EmployeeEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeEditForm));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelphoneNumber = new System.Windows.Forms.Label();
            this.labelEducation = new System.Windows.Forms.Label();
            this.labelEmploymentDate = new System.Windows.Forms.Label();
            this.labelPosition = new System.Windows.Forms.Label();
            this.labelFullname = new System.Windows.Forms.Label();
            this.textBoxPhoneNumber = new System.Windows.Forms.TextBox();
            this.textBoxQualification = new System.Windows.Forms.TextBox();
            this.textBoxEducation = new System.Windows.Forms.TextBox();
            this.dateTimePickerEmploymentDate = new System.Windows.Forms.DateTimePicker();
            this.comboBoxPosition = new System.Windows.Forms.ComboBox();
            this.textBoxFullName = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.labelQualification = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(252, 528);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 63);
            this.buttonEdit.TabIndex = 27;
            this.buttonEdit.Text = "Сохранить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(430, 528);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 26;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelphoneNumber
            // 
            this.labelphoneNumber.AutoSize = true;
            this.labelphoneNumber.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelphoneNumber.Location = new System.Drawing.Point(88, 472);
            this.labelphoneNumber.Name = "labelphoneNumber";
            this.labelphoneNumber.Size = new System.Drawing.Size(158, 25);
            this.labelphoneNumber.TabIndex = 25;
            this.labelphoneNumber.Text = "Номер телефона";
            // 
            // labelEducation
            // 
            this.labelEducation.AutoSize = true;
            this.labelEducation.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEducation.Location = new System.Drawing.Point(117, 356);
            this.labelEducation.Name = "labelEducation";
            this.labelEducation.Size = new System.Drawing.Size(129, 25);
            this.labelEducation.TabIndex = 23;
            this.labelEducation.Text = "Образование";
            // 
            // labelEmploymentDate
            // 
            this.labelEmploymentDate.AutoSize = true;
            this.labelEmploymentDate.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmploymentDate.Location = new System.Drawing.Point(31, 302);
            this.labelEmploymentDate.Name = "labelEmploymentDate";
            this.labelEmploymentDate.Size = new System.Drawing.Size(215, 25);
            this.labelEmploymentDate.TabIndex = 22;
            this.labelEmploymentDate.Text = "Дата приема на работу";
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPosition.Location = new System.Drawing.Point(137, 244);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(109, 25);
            this.labelPosition.TabIndex = 21;
            this.labelPosition.Text = "Должность";
            // 
            // labelFullname
            // 
            this.labelFullname.AutoSize = true;
            this.labelFullname.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFullname.Location = new System.Drawing.Point(192, 186);
            this.labelFullname.Name = "labelFullname";
            this.labelFullname.Size = new System.Drawing.Size(54, 25);
            this.labelFullname.TabIndex = 20;
            this.labelFullname.Text = "ФИО";
            // 
            // textBoxPhoneNumber
            // 
            this.textBoxPhoneNumber.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxPhoneNumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxPhoneNumber.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPhoneNumber.Location = new System.Drawing.Point(252, 470);
            this.textBoxPhoneNumber.Name = "textBoxPhoneNumber";
            this.textBoxPhoneNumber.Size = new System.Drawing.Size(300, 33);
            this.textBoxPhoneNumber.TabIndex = 19;
            this.textBoxPhoneNumber.TextChanged += new System.EventHandler(this.textBoxPhoneNumber_TextChanged);
            // 
            // textBoxQualification
            // 
            this.textBoxQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxQualification.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxQualification.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxQualification.Location = new System.Drawing.Point(252, 410);
            this.textBoxQualification.Name = "textBoxQualification";
            this.textBoxQualification.Size = new System.Drawing.Size(300, 33);
            this.textBoxQualification.TabIndex = 18;
            this.textBoxQualification.TextChanged += new System.EventHandler(this.textBoxQualification_TextChanged);
            // 
            // textBoxEducation
            // 
            this.textBoxEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxEducation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxEducation.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxEducation.Location = new System.Drawing.Point(252, 354);
            this.textBoxEducation.Name = "textBoxEducation";
            this.textBoxEducation.Size = new System.Drawing.Size(300, 33);
            this.textBoxEducation.TabIndex = 17;
            this.textBoxEducation.TextChanged += new System.EventHandler(this.textBoxEducation_TextChanged);
            // 
            // dateTimePickerEmploymentDate
            // 
            this.dateTimePickerEmploymentDate.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerEmploymentDate.Location = new System.Drawing.Point(252, 296);
            this.dateTimePickerEmploymentDate.Name = "dateTimePickerEmploymentDate";
            this.dateTimePickerEmploymentDate.Size = new System.Drawing.Size(300, 33);
            this.dateTimePickerEmploymentDate.TabIndex = 16;
            // 
            // comboBoxPosition
            // 
            this.comboBoxPosition.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPosition.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxPosition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPosition.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPosition.FormattingEnabled = true;
            this.comboBoxPosition.Location = new System.Drawing.Point(252, 241);
            this.comboBoxPosition.Name = "comboBoxPosition";
            this.comboBoxPosition.Size = new System.Drawing.Size(300, 33);
            this.comboBoxPosition.TabIndex = 15;
            // 
            // textBoxFullName
            // 
            this.textBoxFullName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxFullName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxFullName.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxFullName.Location = new System.Drawing.Point(252, 184);
            this.textBoxFullName.Name = "textBoxFullName";
            this.textBoxFullName.Size = new System.Drawing.Size(300, 33);
            this.textBoxFullName.TabIndex = 14;
            this.textBoxFullName.TextChanged += new System.EventHandler(this.textBoxFullName_TextChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(604, 148);
            this.panelHeader.TabIndex = 67;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(144, 14);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(448, 116);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Редактирование \r\nинформации о сотруднике";
            // 
            // labelQualification
            // 
            this.labelQualification.AutoSize = true;
            this.labelQualification.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelQualification.Location = new System.Drawing.Point(64, 401);
            this.labelQualification.Name = "labelQualification";
            this.labelQualification.Size = new System.Drawing.Size(182, 50);
            this.labelQualification.TabIndex = 14;
            this.labelQualification.Text = "Квалификационная\r\nкатегоря";
            this.labelQualification.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // EmployeeEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(604, 616);
            this.Controls.Add(this.labelQualification);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelphoneNumber);
            this.Controls.Add(this.labelEducation);
            this.Controls.Add(this.labelEmploymentDate);
            this.Controls.Add(this.labelPosition);
            this.Controls.Add(this.labelFullname);
            this.Controls.Add(this.textBoxPhoneNumber);
            this.Controls.Add(this.textBoxQualification);
            this.Controls.Add(this.textBoxEducation);
            this.Controls.Add(this.dateTimePickerEmploymentDate);
            this.Controls.Add(this.comboBoxPosition);
            this.Controls.Add(this.textBoxFullName);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "EmployeeEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации о сотруднике | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelphoneNumber;
        private System.Windows.Forms.Label labelEducation;
        private System.Windows.Forms.Label labelEmploymentDate;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.Label labelFullname;
        private System.Windows.Forms.TextBox textBoxPhoneNumber;
        private System.Windows.Forms.TextBox textBoxQualification;
        private System.Windows.Forms.TextBox textBoxEducation;
        private System.Windows.Forms.DateTimePicker dateTimePickerEmploymentDate;
        private System.Windows.Forms.ComboBox comboBoxPosition;
        private System.Windows.Forms.TextBox textBoxFullName;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.Label labelQualification;
    }
}