
namespace P5
{
    partial class FormIssueReord
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
            this.IdLabel = new System.Windows.Forms.Label();
            this.Idnum = new System.Windows.Forms.Label();
            this.TitleLabel = new System.Windows.Forms.Label();
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.DDlabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DiscovererLabel = new System.Windows.Forms.Label();
            this.ComponentTextBox = new System.Windows.Forms.TextBox();
            this.ComponentLabel = new System.Windows.Forms.Label();
            this.DiscovererComboBox = new System.Windows.Forms.ComboBox();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.StatusComboBox = new System.Windows.Forms.ComboBox();
            this.InitialDLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ConfirmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IdLabel
            // 
            this.IdLabel.AutoSize = true;
            this.IdLabel.Location = new System.Drawing.Point(92, 30);
            this.IdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.IdLabel.Name = "IdLabel";
            this.IdLabel.Size = new System.Drawing.Size(19, 13);
            this.IdLabel.TabIndex = 0;
            this.IdLabel.Text = "Id:";
            // 
            // Idnum
            // 
            this.Idnum.AutoSize = true;
            this.Idnum.Location = new System.Drawing.Point(117, 30);
            this.Idnum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Idnum.Name = "Idnum";
            this.Idnum.Size = new System.Drawing.Size(35, 13);
            this.Idnum.TabIndex = 1;
            this.Idnum.Text = "label1";
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Location = new System.Drawing.Point(80, 53);
            this.TitleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(30, 13);
            this.TitleLabel.TabIndex = 2;
            this.TitleLabel.Text = "Title:";
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(119, 53);
            this.TitleTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(166, 20);
            this.TitleTextBox.TabIndex = 3;
            // 
            // DDlabel
            // 
            this.DDlabel.AutoSize = true;
            this.DDlabel.Location = new System.Drawing.Point(28, 80);
            this.DDlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DDlabel.Name = "DDlabel";
            this.DDlabel.Size = new System.Drawing.Size(83, 13);
            this.DDlabel.TabIndex = 4;
            this.DDlabel.Text = "Discovery Date:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(119, 80);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dateTimePicker1.MaxDate = new System.DateTime(2021, 11, 16, 19, 16, 47, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(166, 20);
            this.dateTimePicker1.TabIndex = 5;
            this.dateTimePicker1.Value = new System.DateTime(2021, 11, 16, 0, 0, 0, 0);
            // 
            // DiscovererLabel
            // 
            this.DiscovererLabel.AutoSize = true;
            this.DiscovererLabel.Location = new System.Drawing.Point(49, 107);
            this.DiscovererLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.DiscovererLabel.Name = "DiscovererLabel";
            this.DiscovererLabel.Size = new System.Drawing.Size(61, 13);
            this.DiscovererLabel.TabIndex = 6;
            this.DiscovererLabel.Text = "Discoverer:";
            // 
            // ComponentTextBox
            // 
            this.ComponentTextBox.Location = new System.Drawing.Point(119, 136);
            this.ComponentTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ComponentTextBox.Name = "ComponentTextBox";
            this.ComponentTextBox.Size = new System.Drawing.Size(166, 20);
            this.ComponentTextBox.TabIndex = 7;
            // 
            // ComponentLabel
            // 
            this.ComponentLabel.AutoSize = true;
            this.ComponentLabel.Location = new System.Drawing.Point(46, 136);
            this.ComponentLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ComponentLabel.Name = "ComponentLabel";
            this.ComponentLabel.Size = new System.Drawing.Size(64, 13);
            this.ComponentLabel.TabIndex = 8;
            this.ComponentLabel.Text = "Component:";
            // 
            // DiscovererComboBox
            // 
            this.DiscovererComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DiscovererComboBox.FormattingEnabled = true;
            this.DiscovererComboBox.Location = new System.Drawing.Point(119, 107);
            this.DiscovererComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.DiscovererComboBox.Name = "DiscovererComboBox";
            this.DiscovererComboBox.Size = new System.Drawing.Size(166, 21);
            this.DiscovererComboBox.TabIndex = 9;
            // 
            // StatusLabel
            // 
            this.StatusLabel.AutoSize = true;
            this.StatusLabel.Location = new System.Drawing.Point(70, 164);
            this.StatusLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(40, 13);
            this.StatusLabel.TabIndex = 10;
            this.StatusLabel.Text = "Status:";
            // 
            // StatusComboBox
            // 
            this.StatusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.StatusComboBox.FormattingEnabled = true;
            this.StatusComboBox.Location = new System.Drawing.Point(119, 164);
            this.StatusComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StatusComboBox.Name = "StatusComboBox";
            this.StatusComboBox.Size = new System.Drawing.Size(166, 21);
            this.StatusComboBox.TabIndex = 11;
            // 
            // InitialDLabel
            // 
            this.InitialDLabel.AutoSize = true;
            this.InitialDLabel.Location = new System.Drawing.Point(70, 196);
            this.InitialDLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.InitialDLabel.Name = "InitialDLabel";
            this.InitialDLabel.Size = new System.Drawing.Size(90, 13);
            this.InitialDLabel.TabIndex = 12;
            this.InitialDLabel.Text = "Initial Description:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(94, 227);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(192, 151);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(9, 414);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(70, 19);
            this.CancelButton.TabIndex = 14;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ConfirmButton
            // 
            this.ConfirmButton.Location = new System.Drawing.Point(273, 414);
            this.ConfirmButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ConfirmButton.Name = "ConfirmButton";
            this.ConfirmButton.Size = new System.Drawing.Size(81, 19);
            this.ConfirmButton.TabIndex = 15;
            this.ConfirmButton.Text = "Create Issue";
            this.ConfirmButton.UseVisualStyleBackColor = true;
            this.ConfirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // FormIssueReord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 443);
            this.Controls.Add(this.ConfirmButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.InitialDLabel);
            this.Controls.Add(this.StatusComboBox);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.DiscovererComboBox);
            this.Controls.Add(this.ComponentLabel);
            this.Controls.Add(this.ComponentTextBox);
            this.Controls.Add(this.DiscovererLabel);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.DDlabel);
            this.Controls.Add(this.TitleTextBox);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.Idnum);
            this.Controls.Add(this.IdLabel);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormIssueReord";
            this.Text = "Record Issue";
            this.Load += new System.EventHandler(this.FormIssueReord_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IdLabel;
        private System.Windows.Forms.Label Idnum;
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.Label DDlabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label DiscovererLabel;
        private System.Windows.Forms.TextBox ComponentTextBox;
        private System.Windows.Forms.Label ComponentLabel;
        private System.Windows.Forms.ComboBox DiscovererComboBox;
        private System.Windows.Forms.Label StatusLabel;
        private System.Windows.Forms.ComboBox StatusComboBox;
        private System.Windows.Forms.Label InitialDLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ConfirmButton;
    }
}