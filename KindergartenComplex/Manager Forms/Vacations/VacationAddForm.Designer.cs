namespace KindergartenComplex.Manager_Forms.Vacations
{
    partial class VacationAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VacationAddForm));
            this.labelEmployee = new System.Windows.Forms.Label();
            this.labelVacationStart = new System.Windows.Forms.Label();
            this.dateTimePickerVacationStart = new System.Windows.Forms.DateTimePicker();
            this.labelVacationEnd = new System.Windows.Forms.Label();
            this.dateTimePickerVacationEnd = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.Location = new System.Drawing.Point(101, 123);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(104, 25);
            this.labelEmployee.TabIndex = 13;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // labelVacationStart
            // 
            this.labelVacationStart.AutoSize = true;
            this.labelVacationStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelVacationStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVacationStart.Location = new System.Drawing.Point(56, 175);
            this.labelVacationStart.Name = "labelVacationStart";
            this.labelVacationStart.Size = new System.Drawing.Size(149, 25);
            this.labelVacationStart.TabIndex = 15;
            this.labelVacationStart.Text = "Начало отпуска";
            // 
            // dateTimePickerVacationStart
            // 
            this.dateTimePickerVacationStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerVacationStart.Location = new System.Drawing.Point(211, 169);
            this.dateTimePickerVacationStart.Name = "dateTimePickerVacationStart";
            this.dateTimePickerVacationStart.Size = new System.Drawing.Size(339, 33);
            this.dateTimePickerVacationStart.TabIndex = 14;
            // 
            // labelVacationEnd
            // 
            this.labelVacationEnd.AutoSize = true;
            this.labelVacationEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelVacationEnd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelVacationEnd.Location = new System.Drawing.Point(23, 225);
            this.labelVacationEnd.Name = "labelVacationEnd";
            this.labelVacationEnd.Size = new System.Drawing.Size(182, 25);
            this.labelVacationEnd.TabIndex = 17;
            this.labelVacationEnd.Text = "Окончание отпуска";
            // 
            // dateTimePickerVacationEnd
            // 
            this.dateTimePickerVacationEnd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerVacationEnd.Location = new System.Drawing.Point(211, 219);
            this.dateTimePickerVacationEnd.Name = "dateTimePickerVacationEnd";
            this.dateTimePickerVacationEnd.Size = new System.Drawing.Size(339, 33);
            this.dateTimePickerVacationEnd.TabIndex = 16;
            this.dateTimePickerVacationEnd.CloseUp += new System.EventHandler(this.dateTimePickerVacationEnd_CloseUp);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(250, 276);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 63);
            this.buttonAdd.TabIndex = 19;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(428, 276);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 18;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(584, 98);
            this.panelHeader.TabIndex = 70;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(233, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(351, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Добавление отпуска";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(211, 120);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(339, 33);
            this.comboBoxEmployee.TabIndex = 21;
            // 
            // VacationAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(584, 367);
            this.Controls.Add(this.comboBoxEmployee);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelVacationEnd);
            this.Controls.Add(this.dateTimePickerVacationEnd);
            this.Controls.Add(this.labelVacationStart);
            this.Controls.Add(this.dateTimePickerVacationStart);
            this.Controls.Add(this.labelEmployee);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "VacationAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление отпуска | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.Label labelVacationStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerVacationStart;
        private System.Windows.Forms.Label labelVacationEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerVacationEnd;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
    }
}