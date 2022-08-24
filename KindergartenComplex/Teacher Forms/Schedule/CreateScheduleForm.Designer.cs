namespace KindergartenComplex.Teacher_Forms.Schedule
{
    partial class CreateScheduleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateScheduleForm));
            this.listBoxSubjects = new System.Windows.Forms.ListBox();
            this.listBoxMonday = new System.Windows.Forms.ListBox();
            this.buttonMoveToWeek = new System.Windows.Forms.Button();
            this.listBoxThuesday = new System.Windows.Forms.ListBox();
            this.listBoxWednesday = new System.Windows.Forms.ListBox();
            this.listBoxThursday = new System.Windows.Forms.ListBox();
            this.listBoxFriday = new System.Windows.Forms.ListBox();
            this.labelDayOfWeek = new System.Windows.Forms.Label();
            this.buttonNextDayOfWeek = new System.Windows.Forms.Button();
            this.buttonPrevDayOfWeek = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonMoveToSubjects = new System.Windows.Forms.Button();
            this.labelSubjects = new System.Windows.Forms.Label();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.labelHeader = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxSubjects
            // 
            this.listBoxSubjects.AllowDrop = true;
            this.listBoxSubjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxSubjects.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxSubjects.FormattingEnabled = true;
            this.listBoxSubjects.ItemHeight = 25;
            this.listBoxSubjects.Location = new System.Drawing.Point(78, 157);
            this.listBoxSubjects.Name = "listBoxSubjects";
            this.listBoxSubjects.Size = new System.Drawing.Size(284, 352);
            this.listBoxSubjects.TabIndex = 4;
            this.listBoxSubjects.SelectedIndexChanged += new System.EventHandler(this.listBoxSubjects_SelectedIndexChanged);
            // 
            // listBoxMonday
            // 
            this.listBoxMonday.AllowDrop = true;
            this.listBoxMonday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxMonday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxMonday.FormattingEnabled = true;
            this.listBoxMonday.ItemHeight = 25;
            this.listBoxMonday.Location = new System.Drawing.Point(464, 157);
            this.listBoxMonday.Name = "listBoxMonday";
            this.listBoxMonday.Size = new System.Drawing.Size(284, 352);
            this.listBoxMonday.TabIndex = 5;
            // 
            // buttonMoveToWeek
            // 
            this.buttonMoveToWeek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoveToWeek.BackgroundImage")));
            this.buttonMoveToWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMoveToWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveToWeek.Location = new System.Drawing.Point(393, 283);
            this.buttonMoveToWeek.Name = "buttonMoveToWeek";
            this.buttonMoveToWeek.Size = new System.Drawing.Size(40, 40);
            this.buttonMoveToWeek.TabIndex = 6;
            this.buttonMoveToWeek.UseVisualStyleBackColor = true;
            this.buttonMoveToWeek.Click += new System.EventHandler(this.buttonMoveToWeek_Click);
            // 
            // listBoxThuesday
            // 
            this.listBoxThuesday.AllowDrop = true;
            this.listBoxThuesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxThuesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxThuesday.FormattingEnabled = true;
            this.listBoxThuesday.ItemHeight = 25;
            this.listBoxThuesday.Location = new System.Drawing.Point(464, 157);
            this.listBoxThuesday.Name = "listBoxThuesday";
            this.listBoxThuesday.Size = new System.Drawing.Size(284, 352);
            this.listBoxThuesday.TabIndex = 8;
            this.listBoxThuesday.Visible = false;
            // 
            // listBoxWednesday
            // 
            this.listBoxWednesday.AllowDrop = true;
            this.listBoxWednesday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxWednesday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxWednesday.FormattingEnabled = true;
            this.listBoxWednesday.ItemHeight = 25;
            this.listBoxWednesday.Location = new System.Drawing.Point(464, 157);
            this.listBoxWednesday.Name = "listBoxWednesday";
            this.listBoxWednesday.Size = new System.Drawing.Size(284, 352);
            this.listBoxWednesday.TabIndex = 9;
            this.listBoxWednesday.Visible = false;
            // 
            // listBoxThursday
            // 
            this.listBoxThursday.AllowDrop = true;
            this.listBoxThursday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxThursday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxThursday.FormattingEnabled = true;
            this.listBoxThursday.ItemHeight = 25;
            this.listBoxThursday.Location = new System.Drawing.Point(464, 157);
            this.listBoxThursday.Name = "listBoxThursday";
            this.listBoxThursday.Size = new System.Drawing.Size(284, 352);
            this.listBoxThursday.TabIndex = 10;
            this.listBoxThursday.Visible = false;
            // 
            // listBoxFriday
            // 
            this.listBoxFriday.AllowDrop = true;
            this.listBoxFriday.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.listBoxFriday.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxFriday.FormattingEnabled = true;
            this.listBoxFriday.ItemHeight = 25;
            this.listBoxFriday.Location = new System.Drawing.Point(464, 157);
            this.listBoxFriday.Name = "listBoxFriday";
            this.listBoxFriday.Size = new System.Drawing.Size(284, 352);
            this.listBoxFriday.TabIndex = 11;
            this.listBoxFriday.Visible = false;
            // 
            // labelDayOfWeek
            // 
            this.labelDayOfWeek.AutoSize = true;
            this.labelDayOfWeek.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDayOfWeek.Location = new System.Drawing.Point(459, 124);
            this.labelDayOfWeek.Name = "labelDayOfWeek";
            this.labelDayOfWeek.Size = new System.Drawing.Size(141, 30);
            this.labelDayOfWeek.TabIndex = 12;
            this.labelDayOfWeek.Text = "Понедельник";
            // 
            // buttonNextDayOfWeek
            // 
            this.buttonNextDayOfWeek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonNextDayOfWeek.BackgroundImage")));
            this.buttonNextDayOfWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonNextDayOfWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNextDayOfWeek.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNextDayOfWeek.Location = new System.Drawing.Point(698, 129);
            this.buttonNextDayOfWeek.Name = "buttonNextDayOfWeek";
            this.buttonNextDayOfWeek.Size = new System.Drawing.Size(50, 22);
            this.buttonNextDayOfWeek.TabIndex = 13;
            this.buttonNextDayOfWeek.UseVisualStyleBackColor = true;
            this.buttonNextDayOfWeek.Click += new System.EventHandler(this.buttonNextDayOfWeek_Click);
            // 
            // buttonPrevDayOfWeek
            // 
            this.buttonPrevDayOfWeek.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonPrevDayOfWeek.BackgroundImage")));
            this.buttonPrevDayOfWeek.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrevDayOfWeek.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevDayOfWeek.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrevDayOfWeek.Location = new System.Drawing.Point(642, 129);
            this.buttonPrevDayOfWeek.Name = "buttonPrevDayOfWeek";
            this.buttonPrevDayOfWeek.Size = new System.Drawing.Size(50, 22);
            this.buttonPrevDayOfWeek.TabIndex = 14;
            this.buttonPrevDayOfWeek.UseVisualStyleBackColor = true;
            this.buttonPrevDayOfWeek.Click += new System.EventHandler(this.buttonPrevDayOfWeek_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.Enabled = false;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Location = new System.Drawing.Point(685, 548);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(139, 50);
            this.buttonNext.TabIndex = 15;
            this.buttonNext.Text = "Далее";
            this.buttonNext.UseVisualStyleBackColor = true;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonMoveToSubjects
            // 
            this.buttonMoveToSubjects.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMoveToSubjects.BackgroundImage")));
            this.buttonMoveToSubjects.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMoveToSubjects.Enabled = false;
            this.buttonMoveToSubjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMoveToSubjects.Location = new System.Drawing.Point(393, 329);
            this.buttonMoveToSubjects.Name = "buttonMoveToSubjects";
            this.buttonMoveToSubjects.Size = new System.Drawing.Size(40, 40);
            this.buttonMoveToSubjects.TabIndex = 16;
            this.buttonMoveToSubjects.UseVisualStyleBackColor = true;
            this.buttonMoveToSubjects.Click += new System.EventHandler(this.buttonMoveToSubjects_Click_1);
            // 
            // labelSubjects
            // 
            this.labelSubjects.AutoSize = true;
            this.labelSubjects.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubjects.Location = new System.Drawing.Point(73, 124);
            this.labelSubjects.Name = "labelSubjects";
            this.labelSubjects.Size = new System.Drawing.Size(192, 30);
            this.labelSubjects.TabIndex = 17;
            this.labelSubjects.Text = "Список предметов";
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.panelHeader.Controls.Add(this.labelHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(836, 98);
            this.panelHeader.TabIndex = 71;
            // 
            // labelHeader
            // 
            this.labelHeader.AutoSize = true;
            this.labelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(108)))), ((int)(((byte)(108)))), ((int)(((byte)(189)))));
            this.labelHeader.Font = new System.Drawing.Font("Bahnschrift Condensed", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHeader.Location = new System.Drawing.Point(408, 19);
            this.labelHeader.Name = "labelHeader";
            this.labelHeader.Size = new System.Drawing.Size(428, 58);
            this.labelHeader.TabIndex = 13;
            this.labelHeader.Text = "Составление расписания";
            // 
            // CreateScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(222)))));
            this.ClientSize = new System.Drawing.Size(836, 610);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.labelSubjects);
            this.Controls.Add(this.buttonMoveToSubjects);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.buttonPrevDayOfWeek);
            this.Controls.Add(this.buttonNextDayOfWeek);
            this.Controls.Add(this.labelDayOfWeek);
            this.Controls.Add(this.buttonMoveToWeek);
            this.Controls.Add(this.listBoxMonday);
            this.Controls.Add(this.listBoxSubjects);
            this.Controls.Add(this.listBoxThuesday);
            this.Controls.Add(this.listBoxWednesday);
            this.Controls.Add(this.listBoxThursday);
            this.Controls.Add(this.listBoxFriday);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "CreateScheduleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Составление расписания | ";
            this.panelHeader.ResumeLayout(false);
            this.panelHeader.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxSubjects;
        private System.Windows.Forms.ListBox listBoxMonday;
        private System.Windows.Forms.Button buttonMoveToWeek;
        private System.Windows.Forms.ListBox listBoxThuesday;
        private System.Windows.Forms.ListBox listBoxWednesday;
        private System.Windows.Forms.ListBox listBoxThursday;
        private System.Windows.Forms.ListBox listBoxFriday;
        private System.Windows.Forms.Label labelDayOfWeek;
        private System.Windows.Forms.Button buttonNextDayOfWeek;
        private System.Windows.Forms.Button buttonPrevDayOfWeek;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonMoveToSubjects;
        private System.Windows.Forms.Label labelSubjects;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label labelHeader;
    }
}