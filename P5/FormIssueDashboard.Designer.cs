
namespace P5
{
    partial class FormIssueDashboard
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
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.discoverListBox = new System.Windows.Forms.ListBox();
            this.closebutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NumberOfIssues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.Location = new System.Drawing.Point(69, 145);
            this.monthListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(289, 82);
            this.monthListBox.TabIndex = 0;
            // 
            // discoverListBox
            // 
            this.discoverListBox.FormattingEnabled = true;
            this.discoverListBox.Location = new System.Drawing.Point(69, 277);
            this.discoverListBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.discoverListBox.Name = "discoverListBox";
            this.discoverListBox.Size = new System.Drawing.Size(289, 82);
            this.discoverListBox.TabIndex = 1;
            // 
            // closebutton
            // 
            this.closebutton.Location = new System.Drawing.Point(367, 415);
            this.closebutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(69, 20);
            this.closebutton.TabIndex = 2;
            this.closebutton.Text = "Close";
            this.closebutton.UseVisualStyleBackColor = true;
            this.closebutton.Click += new System.EventHandler(this.closebutton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Number of Issues:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issues by Month";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Issues by Discoverer";
            // 
            // NumberOfIssues
            // 
            this.NumberOfIssues.AutoSize = true;
            this.NumberOfIssues.Location = new System.Drawing.Point(191, 73);
            this.NumberOfIssues.Name = "NumberOfIssues";
            this.NumberOfIssues.Size = new System.Drawing.Size(107, 13);
            this.NumberOfIssues.TabIndex = 6;
            this.NumberOfIssues.Text = "NUMBEROFISSUES";
            // 
            // FormIssueDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 445);
            this.Controls.Add(this.NumberOfIssues);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.discoverListBox);
            this.Controls.Add(this.monthListBox);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIssueDashboard";
            this.Text = "Issue Dashboard";
            this.Load += new System.EventHandler(this.FormIssueDashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.ListBox discoverListBox;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NumberOfIssues;
    }
}