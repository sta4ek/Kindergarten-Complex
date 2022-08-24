namespace KindergartenComplex.Teacher_Forms.Methodical_Work
{
    partial class MethodicalWorkAddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodicalWorkAddForm));
            this.textBoxWorkSubject = new System.Windows.Forms.TextBox();
            this.dateTimePickerWorkDay = new System.Windows.Forms.DateTimePicker();
            this.labelWorkSubject = new System.Windows.Forms.Label();
            this.labelWorkDay = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxWorkSubject
            // 
            this.textBoxWorkSubject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.textBoxWorkSubject.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxWorkSubject.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxWorkSubject.Location = new System.Drawing.Point(169, 115);
            this.textBoxWorkSubject.Multiline = true;
            this.textBoxWorkSubject.Name = "textBoxWorkSubject";
            this.textBoxWorkSubject.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWorkSubject.Size = new System.Drawing.Size(384, 130);
            this.textBoxWorkSubject.TabIndex = 1;
            this.textBoxWorkSubject.TextChanged += new System.EventHandler(this.textBoxWorkSubject_TextChanged);
            // 
            // dateTimePickerWorkDay
            // 
            this.dateTimePickerWorkDay.Location = new System.Drawing.Point(169, 270);
            this.dateTimePickerWorkDay.Name = "dateTimePickerWorkDay";
            this.dateTimePickerWorkDay.Size = new System.Drawing.Size(384, 33);
            this.dateTimePickerWorkDay.TabIndex = 2;
            // 
            // labelWorkSubject
            // 
            this.labelWorkSubject.AutoSize = true;
            this.labelWorkSubject.Location = new System.Drawing.Point(63, 170);
            this.labelWorkSubject.Name = "labelWorkSubject";
            this.labelWorkSubject.Size = new System.Drawing.Size(100, 25);
            this.labelWorkSubject.TabIndex = 3;
            this.labelWorkSubject.Text = "Название ";
            // 
            // labelWorkDay
            // 
            this.labelWorkDay.AutoSize = true;
            this.labelWorkDay.Location = new System.Drawing.Point(110, 276);
            this.labelWorkDay.Name = "labelWorkDay";
            this.labelWorkDay.Size = new System.Drawing.Size(53, 25);
            this.labelWorkDay.TabIndex = 4;
            this.labelWorkDay.Text = "Дата";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Enabled = false;
            this.buttonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdd.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(261, 328);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(122, 63);
            this.buttonAdd.TabIndex = 17;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCancel.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(431, 328);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(122, 63);
            this.buttonCancel.TabIndex = 16;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(580, 98);
            this.panelHeader.TabIndex = 70;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(129, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(451, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Добавление метод. работы";
            // 
            // MethodicalWorkAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(580, 414);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonAdd);
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
            this.Name = "MethodicalWorkAddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление методической работы | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxWorkSubject;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkDay;
        private System.Windows.Forms.Label labelWorkSubject;
        private System.Windows.Forms.Label labelWorkDay;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}