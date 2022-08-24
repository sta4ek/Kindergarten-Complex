namespace KindergartenComplex.Teacher_Forms.Pupils_SickLeaves
{
    partial class PupilSickLeaveAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PupilSickLeaveAddForm));
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelSickLeaveEnd = new System.Windows.Forms.Label();
            this.dateTimePickerSickLeaveEnd = new System.Windows.Forms.DateTimePicker();
            this.labelSickLeaveStart = new System.Windows.Forms.Label();
            this.dateTimePickerSickLeaveStart = new System.Windows.Forms.DateTimePicker();
            this.labelPupil = new System.Windows.Forms.Label();
            this.comboBoxPupil = new System.Windows.Forms.ComboBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(252, 282);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 63);
            this.buttonAdd.TabIndex = 35;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(430, 282);
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
            this.labelSickLeaveEnd.Location = new System.Drawing.Point(16, 226);
            this.labelSickLeaveEnd.Name = "labelSickLeaveEnd";
            this.labelSickLeaveEnd.Size = new System.Drawing.Size(230, 25);
            this.labelSickLeaveEnd.TabIndex = 33;
            this.labelSickLeaveEnd.Text = "Окончание больничного";
            // 
            // dateTimePickerSickLeaveEnd
            // 
            this.dateTimePickerSickLeaveEnd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerSickLeaveEnd.Location = new System.Drawing.Point(252, 220);
            this.dateTimePickerSickLeaveEnd.Name = "dateTimePickerSickLeaveEnd";
            this.dateTimePickerSickLeaveEnd.Size = new System.Drawing.Size(300, 33);
            this.dateTimePickerSickLeaveEnd.TabIndex = 32;
            this.dateTimePickerSickLeaveEnd.CloseUp += new System.EventHandler(this.dateTimePickerSickLeaveEnd_CloseUp);
            // 
            // labelSickLeaveStart
            // 
            this.labelSickLeaveStart.AutoSize = true;
            this.labelSickLeaveStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelSickLeaveStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSickLeaveStart.Location = new System.Drawing.Point(49, 176);
            this.labelSickLeaveStart.Name = "labelSickLeaveStart";
            this.labelSickLeaveStart.Size = new System.Drawing.Size(197, 25);
            this.labelSickLeaveStart.TabIndex = 31;
            this.labelSickLeaveStart.Text = "Начало больничного";
            // 
            // dateTimePickerSickLeaveStart
            // 
            this.dateTimePickerSickLeaveStart.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.dateTimePickerSickLeaveStart.Location = new System.Drawing.Point(252, 170);
            this.dateTimePickerSickLeaveStart.Name = "dateTimePickerSickLeaveStart";
            this.dateTimePickerSickLeaveStart.Size = new System.Drawing.Size(300, 33);
            this.dateTimePickerSickLeaveStart.TabIndex = 30;
            // 
            // labelPupil
            // 
            this.labelPupil.AutoSize = true;
            this.labelPupil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.labelPupil.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPupil.Location = new System.Drawing.Point(121, 124);
            this.labelPupil.Name = "labelPupil";
            this.labelPupil.Size = new System.Drawing.Size(125, 25);
            this.labelPupil.TabIndex = 29;
            this.labelPupil.Text = "Воспитанник";
            // 
            // comboBoxPupil
            // 
            this.comboBoxPupil.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBoxPupil.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBoxPupil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxPupil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxPupil.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBoxPupil.FormattingEnabled = true;
            this.comboBoxPupil.Location = new System.Drawing.Point(252, 121);
            this.comboBoxPupil.Name = "comboBoxPupil";
            this.comboBoxPupil.Size = new System.Drawing.Size(300, 33);
            this.comboBoxPupil.TabIndex = 28;
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(575, 98);
            this.panelHeader.TabIndex = 69;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(149, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(426, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Добавление больничного";
            // 
            // PupilSickLeaveAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(575, 365);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelSickLeaveEnd);
            this.Controls.Add(this.dateTimePickerSickLeaveEnd);
            this.Controls.Add(this.labelSickLeaveStart);
            this.Controls.Add(this.dateTimePickerSickLeaveStart);
            this.Controls.Add(this.labelPupil);
            this.Controls.Add(this.comboBoxPupil);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "PupilSickLeaveAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление больничного | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelSickLeaveEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerSickLeaveEnd;
        private System.Windows.Forms.Label labelSickLeaveStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerSickLeaveStart;
        private System.Windows.Forms.Label labelPupil;
        private System.Windows.Forms.ComboBox comboBoxPupil;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}