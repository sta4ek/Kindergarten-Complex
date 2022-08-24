namespace KindergartenComplex.Manager_Forms.Attendance_Reports
{
    partial class AttendanceReportForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AttendanceReportForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.dataGridViewAttendanceReport = new System.Windows.Forms.DataGridView();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.groupBoxWorkMonth = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWorkMonth = new System.Windows.Forms.DateTimePicker();
            this.groupBoxGroup = new System.Windows.Forms.GroupBox();
            this.comboBoxGroup = new System.Windows.Forms.ComboBox();
            this.labelNoRows = new System.Windows.Forms.Label();
            this.labelHint = new System.Windows.Forms.Label();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceReport)).BeginInit();
            this.groupBoxWorkMonth.SuspendLayout();
            this.groupBoxGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1086, 98);
            this.panelHeader.TabIndex = 71;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(678, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(406, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Отчёты о посещаемости";
            // 
            // dataGridViewAttendanceReport
            // 
            this.dataGridViewAttendanceReport.AllowUserToAddRows = false;
            this.dataGridViewAttendanceReport.AllowUserToDeleteRows = false;
            this.dataGridViewAttendanceReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAttendanceReport.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAttendanceReport.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.dataGridViewAttendanceReport.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAttendanceReport.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendanceReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAttendanceReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAttendanceReport.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAttendanceReport.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewAttendanceReport.EnableHeadersVisualStyles = false;
            this.dataGridViewAttendanceReport.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(159)))));
            this.dataGridViewAttendanceReport.Location = new System.Drawing.Point(0, 190);
            this.dataGridViewAttendanceReport.Name = "dataGridViewAttendanceReport";
            this.dataGridViewAttendanceReport.ReadOnly = true;
            this.dataGridViewAttendanceReport.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAttendanceReport.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAttendanceReport.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAttendanceReport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAttendanceReport.Size = new System.Drawing.Size(1086, 554);
            this.dataGridViewAttendanceReport.TabIndex = 72;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(936, 129);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(138, 55);
            this.buttonPrint.TabIndex = 79;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(601, 129);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 55);
            this.buttonSearch.TabIndex = 78;
            this.buttonSearch.Text = "Применить";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // groupBoxWorkMonth
            // 
            this.groupBoxWorkMonth.Controls.Add(this.dateTimePickerWorkMonth);
            this.groupBoxWorkMonth.Location = new System.Drawing.Point(347, 116);
            this.groupBoxWorkMonth.Name = "groupBoxWorkMonth";
            this.groupBoxWorkMonth.Size = new System.Drawing.Size(233, 68);
            this.groupBoxWorkMonth.TabIndex = 77;
            this.groupBoxWorkMonth.TabStop = false;
            this.groupBoxWorkMonth.Text = "Месяц";
            // 
            // dateTimePickerWorkMonth
            // 
            this.dateTimePickerWorkMonth.CustomFormat = "MMMM yyyy";
            this.dateTimePickerWorkMonth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerWorkMonth.Location = new System.Drawing.Point(6, 29);
            this.dateTimePickerWorkMonth.Name = "dateTimePickerWorkMonth";
            this.dateTimePickerWorkMonth.Size = new System.Drawing.Size(221, 33);
            this.dateTimePickerWorkMonth.TabIndex = 2;
            // 
            // groupBoxGroup
            // 
            this.groupBoxGroup.Controls.Add(this.comboBoxGroup);
            this.groupBoxGroup.Location = new System.Drawing.Point(12, 116);
            this.groupBoxGroup.Name = "groupBoxGroup";
            this.groupBoxGroup.Size = new System.Drawing.Size(314, 68);
            this.groupBoxGroup.TabIndex = 76;
            this.groupBoxGroup.TabStop = false;
            this.groupBoxGroup.Text = "Группа";
            // 
            // comboBoxGroup
            // 
            this.comboBoxGroup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxGroup.FormattingEnabled = true;
            this.comboBoxGroup.Location = new System.Drawing.Point(6, 29);
            this.comboBoxGroup.Name = "comboBoxGroup";
            this.comboBoxGroup.Size = new System.Drawing.Size(302, 33);
            this.comboBoxGroup.TabIndex = 0;
            // 
            // labelNoRows
            // 
            this.labelNoRows.AutoSize = true;
            this.labelNoRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.labelNoRows.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoRows.Location = new System.Drawing.Point(443, 433);
            this.labelNoRows.Name = "labelNoRows";
            this.labelNoRows.Size = new System.Drawing.Size(179, 40);
            this.labelNoRows.TabIndex = 81;
            this.labelNoRows.Text = "Записей нет";
            this.labelNoRows.Visible = false;
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.labelHint.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(364, 433);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(336, 40);
            this.labelHint.TabIndex = 80;
            this.labelHint.Text = "Выберите группу и дату";
            // 
            // printPreviewDialog
            // 
            this.printPreviewDialog.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog.Enabled = true;
            this.printPreviewDialog.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog.Icon")));
            this.printPreviewDialog.Name = "printPreviewDialog";
            this.printPreviewDialog.Visible = false;
            // 
            // AttendanceReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1086, 744);
            this.Controls.Add(this.labelNoRows);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.groupBoxWorkMonth);
            this.Controls.Add(this.groupBoxGroup);
            this.Controls.Add(this.dataGridViewAttendanceReport);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AttendanceReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты о посещаемости | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAttendanceReport)).EndInit();
            this.groupBoxWorkMonth.ResumeLayout(false);
            this.groupBoxGroup.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.DataGridView dataGridViewAttendanceReport;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBoxWorkMonth;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkMonth;
        private System.Windows.Forms.GroupBox groupBoxGroup;
        private System.Windows.Forms.ComboBox comboBoxGroup;
        private System.Windows.Forms.Label labelNoRows;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
    }
}