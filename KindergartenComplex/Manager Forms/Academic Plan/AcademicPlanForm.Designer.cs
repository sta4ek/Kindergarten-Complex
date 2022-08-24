namespace KindergartenComplex.Manager_Forms.Academic_Plan
{
    partial class AcademicPlanForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AcademicPlanForm));
            this.buttonSave = new System.Windows.Forms.Button();
            this.groupBoxStudyLoad = new System.Windows.Forms.GroupBox();
            this.labelSeniorValue = new System.Windows.Forms.Label();
            this.labelMiddleValue = new System.Windows.Forms.Label();
            this.labelSecondYoungValue = new System.Windows.Forms.Label();
            this.labelFirstYoungValue = new System.Windows.Forms.Label();
            this.labelSenior = new System.Windows.Forms.Label();
            this.labelMiddle = new System.Windows.Forms.Label();
            this.labelSecondYoung = new System.Windows.Forms.Label();
            this.labelFirstYoung = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьВWordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.печатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridViewAcademicPlan = new System.Windows.Forms.DataGridView();
            this.groupBoxStudyLoad.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademicPlan)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSave
            // 
            this.buttonSave.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.buttonSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.buttonSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(222)))));
            this.buttonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSave.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(12, 656);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(190, 78);
            this.buttonSave.TabIndex = 19;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // groupBoxStudyLoad
            // 
            this.groupBoxStudyLoad.Controls.Add(this.labelSeniorValue);
            this.groupBoxStudyLoad.Controls.Add(this.labelMiddleValue);
            this.groupBoxStudyLoad.Controls.Add(this.labelSecondYoungValue);
            this.groupBoxStudyLoad.Controls.Add(this.labelFirstYoungValue);
            this.groupBoxStudyLoad.Controls.Add(this.labelSenior);
            this.groupBoxStudyLoad.Controls.Add(this.labelMiddle);
            this.groupBoxStudyLoad.Controls.Add(this.labelSecondYoung);
            this.groupBoxStudyLoad.Controls.Add(this.labelFirstYoung);
            this.groupBoxStudyLoad.Location = new System.Drawing.Point(208, 656);
            this.groupBoxStudyLoad.Name = "groupBoxStudyLoad";
            this.groupBoxStudyLoad.Size = new System.Drawing.Size(400, 78);
            this.groupBoxStudyLoad.TabIndex = 20;
            this.groupBoxStudyLoad.TabStop = false;
            this.groupBoxStudyLoad.Text = "Текущая учебная нагрузка";
            // 
            // labelSeniorValue
            // 
            this.labelSeniorValue.AutoSize = true;
            this.labelSeniorValue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSeniorValue.Location = new System.Drawing.Point(311, 50);
            this.labelSeniorValue.Name = "labelSeniorValue";
            this.labelSeniorValue.Size = new System.Drawing.Size(19, 21);
            this.labelSeniorValue.TabIndex = 28;
            this.labelSeniorValue.Text = "0";
            // 
            // labelMiddleValue
            // 
            this.labelMiddleValue.AutoSize = true;
            this.labelMiddleValue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddleValue.Location = new System.Drawing.Point(311, 29);
            this.labelMiddleValue.Name = "labelMiddleValue";
            this.labelMiddleValue.Size = new System.Drawing.Size(19, 21);
            this.labelMiddleValue.TabIndex = 27;
            this.labelMiddleValue.Text = "0";
            // 
            // labelSecondYoungValue
            // 
            this.labelSecondYoungValue.AutoSize = true;
            this.labelSecondYoungValue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondYoungValue.Location = new System.Drawing.Point(144, 50);
            this.labelSecondYoungValue.Name = "labelSecondYoungValue";
            this.labelSecondYoungValue.Size = new System.Drawing.Size(19, 21);
            this.labelSecondYoungValue.TabIndex = 26;
            this.labelSecondYoungValue.Text = "0";
            // 
            // labelFirstYoungValue
            // 
            this.labelFirstYoungValue.AutoSize = true;
            this.labelFirstYoungValue.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstYoungValue.Location = new System.Drawing.Point(144, 29);
            this.labelFirstYoungValue.Name = "labelFirstYoungValue";
            this.labelFirstYoungValue.Size = new System.Drawing.Size(19, 21);
            this.labelFirstYoungValue.TabIndex = 25;
            this.labelFirstYoungValue.Text = "0";
            // 
            // labelSenior
            // 
            this.labelSenior.AutoSize = true;
            this.labelSenior.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSenior.Location = new System.Drawing.Point(231, 50);
            this.labelSenior.Name = "labelSenior";
            this.labelSenior.Size = new System.Drawing.Size(76, 21);
            this.labelSenior.TabIndex = 24;
            this.labelSenior.Text = "Старшая:";
            // 
            // labelMiddle
            // 
            this.labelMiddle.AutoSize = true;
            this.labelMiddle.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMiddle.Location = new System.Drawing.Point(231, 29);
            this.labelMiddle.Name = "labelMiddle";
            this.labelMiddle.Size = new System.Drawing.Size(74, 21);
            this.labelMiddle.TabIndex = 23;
            this.labelMiddle.Text = "Средняя:";
            // 
            // labelSecondYoung
            // 
            this.labelSecondYoung.AutoSize = true;
            this.labelSecondYoung.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSecondYoung.Location = new System.Drawing.Point(6, 50);
            this.labelSecondYoung.Name = "labelSecondYoung";
            this.labelSecondYoung.Size = new System.Drawing.Size(132, 21);
            this.labelSecondYoung.TabIndex = 22;
            this.labelSecondYoung.Text = "Вторая младшая:";
            // 
            // labelFirstYoung
            // 
            this.labelFirstYoung.AutoSize = true;
            this.labelFirstYoung.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFirstYoung.Location = new System.Drawing.Point(6, 29);
            this.labelFirstYoung.Name = "labelFirstYoung";
            this.labelFirstYoung.Size = new System.Drawing.Size(138, 21);
            this.labelFirstYoung.TabIndex = 21;
            this.labelFirstYoung.Text = "Первая младшая: ";
            // 
            // timer
            // 
            this.timer.Interval = 1;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // progressBar
            // 
            this.progressBar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.progressBar.Location = new System.Drawing.Point(614, 679);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(297, 39);
            this.progressBar.Step = 12;
            this.progressBar.TabIndex = 22;
            this.progressBar.UseWaitCursor = true;
            this.progressBar.Visible = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.Font = new System.Drawing.Font("Yu Gothic UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSuccess.ForeColor = System.Drawing.Color.Green;
            this.labelSuccess.Location = new System.Drawing.Point(990, 736);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(163, 40);
            this.labelSuccess.TabIndex = 23;
            this.labelSuccess.Text = "Сохранено";
            this.labelSuccess.Visible = false;
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "DOC files(*.docx)|*.docx|All files(*.*)|*.*";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1195, 98);
            this.panelHeader.TabIndex = 69;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(944, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(251, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Учебный план";
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 98);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip.TabIndex = 71;
            this.menuStrip.Text = "menuStrip";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьВWordToolStripMenuItem,
            this.печатьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьВWordToolStripMenuItem
            // 
            this.сохранитьВWordToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.сохранитьВWordToolStripMenuItem.Name = "сохранитьВWordToolStripMenuItem";
            this.сохранитьВWordToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.сохранитьВWordToolStripMenuItem.Text = "Сохранить в Word";
            this.сохранитьВWordToolStripMenuItem.Click += new System.EventHandler(this.сохранитьВWordToolStripMenuItem_Click);
            // 
            // печатьToolStripMenuItem
            // 
            this.печатьToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.печатьToolStripMenuItem.Name = "печатьToolStripMenuItem";
            this.печатьToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.печатьToolStripMenuItem.Text = "Печать";
            this.печатьToolStripMenuItem.Click += new System.EventHandler(this.печатьToolStripMenuItem_Click);
            // 
            // dataGridViewAcademicPlan
            // 
            this.dataGridViewAcademicPlan.AllowUserToAddRows = false;
            this.dataGridViewAcademicPlan.AllowUserToDeleteRows = false;
            this.dataGridViewAcademicPlan.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAcademicPlan.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewAcademicPlan.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            this.dataGridViewAcademicPlan.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewAcademicPlan.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(171)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAcademicPlan.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewAcademicPlan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(223)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewAcademicPlan.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewAcademicPlan.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewAcademicPlan.EnableHeadersVisualStyles = false;
            this.dataGridViewAcademicPlan.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(159)))));
            this.dataGridViewAcademicPlan.Location = new System.Drawing.Point(0, 122);
            this.dataGridViewAcademicPlan.MultiSelect = false;
            this.dataGridViewAcademicPlan.Name = "dataGridViewAcademicPlan";
            this.dataGridViewAcademicPlan.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewAcademicPlan.RowHeadersVisible = false;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(243)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(140)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewAcademicPlan.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewAcademicPlan.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAcademicPlan.Size = new System.Drawing.Size(1195, 528);
            this.dataGridViewAcademicPlan.TabIndex = 72;
            this.dataGridViewAcademicPlan.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAcademicPlan_CellValueChanged);
            this.dataGridViewAcademicPlan.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridViewAcademicPlan_DataError);
            // 
            // AcademicPlanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(1195, 745);
            this.Controls.Add(this.dataGridViewAcademicPlan);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelSuccess);
            this.Controls.Add(this.groupBoxStudyLoad);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.progressBar);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "AcademicPlanForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Учебный план | ";
            this.groupBoxStudyLoad.ResumeLayout(false);
            this.groupBoxStudyLoad.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAcademicPlan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.GroupBox groupBoxStudyLoad;
        private System.Windows.Forms.Label labelSecondYoung;
        private System.Windows.Forms.Label labelFirstYoung;
        private System.Windows.Forms.Label labelSeniorValue;
        private System.Windows.Forms.Label labelMiddleValue;
        private System.Windows.Forms.Label labelSecondYoungValue;
        private System.Windows.Forms.Label labelFirstYoungValue;
        private System.Windows.Forms.Label labelSenior;
        private System.Windows.Forms.Label labelMiddle;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьВWordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem печатьToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridViewAcademicPlan;
    }
}