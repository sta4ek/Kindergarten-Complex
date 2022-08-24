namespace KindergartenComplex.Manager_Forms.SickLeaves
{
    partial class SickLeaveEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SickLeaveEditForm));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSickLeaveEnd = new System.Windows.Forms.Label();
            this.dateTimePickerSickLeaveEnd = new System.Windows.Forms.DateTimePicker();
            this.labelSickLeaveStart = new System.Windows.Forms.Label();
            this.dateTimePickerSickLeaveStart = new System.Windows.Forms.DateTimePicker();
            this.labelEmployee = new System.Windows.Forms.Label();
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(274, 277);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 63);
            this.buttonEdit.TabIndex = 35;
            this.buttonEdit.Text = "Сохранить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(452, 277);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 34;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = false;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelSickLeaveEnd
            // 
            this.labelSickLeaveEnd.AutoSize = true;
            this.labelSickLeaveEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelSickLeaveEnd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSickLeaveEnd.Location = new System.Drawing.Point(15, 221);
            this.labelSickLeaveEnd.Name = "labelSickLeaveEnd";
            this.labelSickLeaveEnd.Size = new System.Drawing.Size(230, 25);
            this.labelSickLeaveEnd.TabIndex = 33;
            this.labelSickLeaveEnd.Text = "Окончание больничного";
            // 
            // dateTimePickerSickLeaveEnd
            // 
            this.dateTimePickerSickLeaveEnd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerSickLeaveEnd.Location = new System.Drawing.Point(251, 215);
            this.dateTimePickerSickLeaveEnd.Name = "dateTimePickerSickLeaveEnd";
            this.dateTimePickerSickLeaveEnd.Size = new System.Drawing.Size(323, 33);
            this.dateTimePickerSickLeaveEnd.TabIndex = 32;
            this.dateTimePickerSickLeaveEnd.CloseUp += new System.EventHandler(this.dateTimePickerSickLeaveEnd_CloseUp);
            // 
            // labelSickLeaveStart
            // 
            this.labelSickLeaveStart.AutoSize = true;
            this.labelSickLeaveStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelSickLeaveStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSickLeaveStart.Location = new System.Drawing.Point(48, 171);
            this.labelSickLeaveStart.Name = "labelSickLeaveStart";
            this.labelSickLeaveStart.Size = new System.Drawing.Size(197, 25);
            this.labelSickLeaveStart.TabIndex = 31;
            this.labelSickLeaveStart.Text = "Начало больничного";
            // 
            // dateTimePickerSickLeaveStart
            // 
            this.dateTimePickerSickLeaveStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerSickLeaveStart.Location = new System.Drawing.Point(251, 165);
            this.dateTimePickerSickLeaveStart.Name = "dateTimePickerSickLeaveStart";
            this.dateTimePickerSickLeaveStart.Size = new System.Drawing.Size(323, 33);
            this.dateTimePickerSickLeaveStart.TabIndex = 30;
            // 
            // labelEmployee
            // 
            this.labelEmployee.AutoSize = true;
            this.labelEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEmployee.Location = new System.Drawing.Point(141, 119);
            this.labelEmployee.Name = "labelEmployee";
            this.labelEmployee.Size = new System.Drawing.Size(104, 25);
            this.labelEmployee.TabIndex = 29;
            this.labelEmployee.Text = "Сотрудник";
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxEmployee.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(251, 116);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(323, 33);
            this.comboBoxEmployee.TabIndex = 28;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(600, 98);
            this.panelHeader.TabIndex = 70;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(102, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(498, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Редактирование больничного";
            // 
            // SickLeaveEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(600, 363);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSickLeaveEnd);
            this.Controls.Add(this.dateTimePickerSickLeaveEnd);
            this.Controls.Add(this.labelSickLeaveStart);
            this.Controls.Add(this.dateTimePickerSickLeaveStart);
            this.Controls.Add(this.labelEmployee);
            this.Controls.Add(this.comboBoxEmployee);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MaximizeBox = false;
            this.Name = "SickLeaveEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации о больничном | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSickLeaveEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerSickLeaveEnd;
        private System.Windows.Forms.Label labelSickLeaveStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerSickLeaveStart;
        private System.Windows.Forms.Label labelEmployee;
        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}