namespace KindergartenComplex
{
    partial class DetailsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DetailsForm));
            this.richTextBoxDetails = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // richTextBoxDetails
            // 
            this.richTextBoxDetails.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBoxDetails.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxDetails.Location = new System.Drawing.Point(0, 0);
            this.richTextBoxDetails.Name = "richTextBoxDetails";
            this.richTextBoxDetails.ReadOnly = true;
            this.richTextBoxDetails.Size = new System.Drawing.Size(610, 541);
            this.richTextBoxDetails.TabIndex = 0;
            this.richTextBoxDetails.Text = "";
            // 
            // DetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 541);
            this.Controls.Add(this.richTextBoxDetails);
            this.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "DetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подробно | ";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxDetails;
    }
}