namespace KindergartenComplex.Manager_Forms.Methodical_Work_Reports
{
    partial class MethodicalWorkReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MethodicalWorkReportForm));
            this.comboBoxEmployee = new System.Windows.Forms.ComboBox();
            this.groupBoxEmployee = new System.Windows.Forms.GroupBox();
            this.dateTimePickerWorkMonth = new System.Windows.Forms.DateTimePicker();
            this.groupBoxWorkMonth = new System.Windows.Forms.GroupBox();
            this.dataGridViewMethodicalWork = new System.Windows.Forms.DataGridView();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.labelHint = new System.Windows.Forms.Label();
            this.labelNoRows = new System.Windows.Forms.Label();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.printPreviewDialog = new System.Windows.Forms.PrintPreviewDialog();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.groupBoxEmployee.SuspendLayout();
            this.groupBoxWorkMonth.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMethodicalWork)).BeginInit();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxEmployee
            // 
            this.comboBoxEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.comboBoxEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxEmployee.FormattingEnabled = true;
            this.comboBoxEmployee.Location = new System.Drawing.Point(6, 29);
            this.comboBoxEmployee.Name = "comboBoxEmployee";
            this.comboBoxEmployee.Size = new System.Drawing.Size(302, 33);
            this.comboBoxEmployee.TabIndex = 0;
            // 
            // groupBoxEmployee
            // 
            this.groupBoxEmployee.Controls.Add(this.comboBoxEmployee);
            this.groupBoxEmployee.Location = new System.Drawing.Point(12, 116);
            this.groupBoxEmployee.Name = "groupBoxEmployee";
            this.groupBoxEmployee.Size = new System.Drawing.Size(314, 68);
            this.groupBoxEmployee.TabIndex = 1;
            this.groupBoxEmployee.TabStop = false;
            this.groupBoxEmployee.Text = "Воспитатель";
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
            // groupBoxWorkMonth
            // 
            this.groupBoxWorkMonth.Controls.Add(this.dateTimePickerWorkMonth);
            this.groupBoxWorkMonth.Location = new System.Drawing.Point(347, 116);
            this.groupBoxWorkMonth.Name = "groupBoxWorkMonth";
            this.groupBoxWorkMonth.Size = new System.Drawing.Size(233, 68);
            this.groupBoxWorkMonth.TabIndex = 3;
            this.groupBoxWorkMonth.TabStop = false;
            this.groupBoxWorkMonth.Text = "Месяц";
            // 
            // dataGridViewMethodicalWork
            // 
            this.dataGridViewMethodicalWork.AllowUserToAddRows = false;
            this.dataGridViewMethodicalWork.AllowUserToDeleteRows = false;
            this.dataGridViewMethodicalWork.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewMethodicalWork.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewMethodicalWork.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.dataGridViewMethodicalWork.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewMethodicalWork.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMethodicalWork.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewMethodicalWork.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewMethodicalWork.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewMethodicalWork.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewMethodicalWork.EnableHeadersVisualStyles = false;
            this.dataGridViewMethodicalWork.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(159)))));
            this.dataGridViewMethodicalWork.Location = new System.Drawing.Point(0, 190);
            this.dataGridViewMethodicalWork.Name = "dataGridViewMethodicalWork";
            this.dataGridViewMethodicalWork.ReadOnly = true;
            this.dataGridViewMethodicalWork.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewMethodicalWork.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewMethodicalWork.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewMethodicalWork.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMethodicalWork.Size = new System.Drawing.Size(1086, 554);
            this.dataGridViewMethodicalWork.TabIndex = 4;
            // 
            // buttonSearch
            // 
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(601, 129);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(138, 55);
            this.buttonSearch.TabIndex = 5;
            this.buttonSearch.Text = "Применить";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // labelHint
            // 
            this.labelHint.AutoSize = true;
            this.labelHint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.labelHint.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHint.Location = new System.Drawing.Point(333, 433);
            this.labelHint.Name = "labelHint";
            this.labelHint.Size = new System.Drawing.Size(398, 40);
            this.labelHint.TabIndex = 6;
            this.labelHint.Text = "Выберите сотрудника и дату";
            // 
            // labelNoRows
            // 
            this.labelNoRows.AutoSize = true;
            this.labelNoRows.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.labelNoRows.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNoRows.Location = new System.Drawing.Point(443, 433);
            this.labelNoRows.Name = "labelNoRows";
            this.labelNoRows.Size = new System.Drawing.Size(179, 40);
            this.labelNoRows.TabIndex = 7;
            this.labelNoRows.Text = "Записей нет";
            this.labelNoRows.Visible = false;
            // 
            // buttonPrint
            // 
            this.buttonPrint.Enabled = false;
            this.buttonPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrint.Location = new System.Drawing.Point(936, 129);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(138, 55);
            this.buttonPrint.TabIndex = 8;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.buttonPrint_Click);
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
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1086, 98);
            this.panelHeader.TabIndex = 69;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(571, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(515, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Отчёты о методической работе";
            // 
            // MethodicalWorkReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1086, 744);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.buttonPrint);
            this.Controls.Add(this.labelNoRows);
            this.Controls.Add(this.labelHint);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.dataGridViewMethodicalWork);
            this.Controls.Add(this.groupBoxWorkMonth);
            this.Controls.Add(this.groupBoxEmployee);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "MethodicalWorkReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчёты о методической работе | ";
            this.groupBoxEmployee.ResumeLayout(false);
            this.groupBoxWorkMonth.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMethodicalWork)).EndInit();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxEmployee;
        private System.Windows.Forms.GroupBox groupBoxEmployee;
        private System.Windows.Forms.DateTimePicker dateTimePickerWorkMonth;
        private System.Windows.Forms.GroupBox groupBoxWorkMonth;
        private System.Windows.Forms.DataGridView dataGridViewMethodicalWork;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label labelHint;
        private System.Windows.Forms.Label labelNoRows;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}