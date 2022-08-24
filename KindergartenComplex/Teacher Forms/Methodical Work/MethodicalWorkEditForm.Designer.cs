namespace KindergartenComplex.Teacher_Forms.Methodical_Work
{
    partial class MethodicalWorkEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodicalWorkEditForm));
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.labelWorkDay = new System.Windows.Forms.Label();
            this.labelWorkSubject = new System.Windows.Forms.Label();
            this.dateTimePickerWorkDay = new System.Windows.Forms.DateTimePicker();
            this.textBoxWorkSubject = new System.Windows.Forms.TextBox();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonEdit
            // 
            this.buttonEdit.Enabled = false;
            this.buttonEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEdit.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonEdit.Location = new System.Drawing.Point(308, 328);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(122, 63);
            this.buttonEdit.TabIndex = 23;
            this.buttonEdit.Text = "Сохранить";
            this.buttonEdit.UseVisualStyleBackColor = true;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(478, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 22;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // labelWorkDay
            // 
            this.labelWorkDay.AutoSize = true;
            this.labelWorkDay.Location = new System.Drawing.Point(157, 276);
            this.labelWorkDay.Name = "labelWorkDay";
            this.labelWorkDay.Size = new System.Drawing.Size(53, 25);
            this.labelWorkDay.TabIndex = 21;
            this.labelWorkDay.Text = "Дата";
            // 
            // labelWorkSubject
            // 
            this.labelWorkSubject.AutoSize = true;
            this.labelWorkSubject.Location = new System.Drawing.Point(110, 170);
            this.labelWorkSubject.Name = "labelWorkSubject";
            this.labelWorkSubject.Size = new System.Drawing.Size(100, 25);
            this.labelWorkSubject.TabIndex = 20;
            this.labelWorkSubject.Text = "Название ";
            // 
            // dateTimePickerWorkDay
            // 
            this.dateTimePickerWorkDay.Location = new System.Drawing.Point(216, 270);
            this.dateTimePickerWorkDay.Name = "dateTimePickerWorkDay";
            this.dateTimePickerWorkDay.Size = new System.Drawing.Size(384, 33);
            this.dateTimePickerWorkDay.TabIndex = 19;
            // 
            // textBoxWorkSubject
            // 
            this.textBoxWorkSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxWorkSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWorkSubject.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWorkSubject.Location = new System.Drawing.Point(216, 115);
            this.textBoxWorkSubject.Multiline = true;
            this.textBoxWorkSubject.Name = "textBoxWorkSubject";
            this.textBoxWorkSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWorkSubject.Size = new System.Drawing.Size(384, 130);
            this.textBoxWorkSubject.TabIndex = 18;
            this.textBoxWorkSubject.TextChanged += new System.EventHandler(this.textBoxWorkSubject_TextChanged);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(647, 98);
            this.panelHeader.TabIndex = 69;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(124, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(523, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Редактирование метод. работы";
            // 
            // MethodicalWorkEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(647, 418);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonEdit);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.labelWorkDay);
            this.Controls.Add(this.labelWorkSubject);
            this.Controls.Add(this.dateTimePickerWorkDay);
            this.Controls.Add(this.textBoxWorkSubject);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MethodicalWorkEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование информации о методической работе | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Label labelWorkDay;
        private System.Windows.Forms.Label labelWorkSubject;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkDay;
        private System.Windows.Forms.TextBox textBoxWorkSubject;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}