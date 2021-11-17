namespace P5
{
    partial class FormSelectIssue
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
            this.buttonSelectIssue = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.gridViewIssues = new System.Windows.Forms.DataGridView();
            this.fakeIssueRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIssues)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonSelectIssue
            // 
            this.buttonSelectIssue.Location = new System.Drawing.Point(304, 258);
            this.buttonSelectIssue.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSelectIssue.Name = "buttonSelectIssue";
            this.buttonSelectIssue.Size = new System.Drawing.Size(120, 30);
            this.buttonSelectIssue.TabIndex = 1;
            this.buttonSelectIssue.Text = "Select Issue";
            this.buttonSelectIssue.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(141, 258);
            this.buttonCancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(120, 30);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // gridViewIssues
            // 
            this.gridViewIssues.AllowUserToAddRows = false;
            this.gridViewIssues.AllowUserToDeleteRows = false;
            this.gridViewIssues.AutoGenerateColumns = false;
            this.gridViewIssues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridViewIssues.DataSource = this.fakeIssueRepositoryBindingSource;
            this.gridViewIssues.Location = new System.Drawing.Point(12, 12);
            this.gridViewIssues.Name = "gridViewIssues";
            this.gridViewIssues.ReadOnly = true;
            this.gridViewIssues.Size = new System.Drawing.Size(412, 229);
            this.gridViewIssues.TabIndex = 3;
            // 
            // fakeIssueRepositoryBindingSource
            // 
            this.fakeIssueRepositoryBindingSource.DataSource = typeof(P5.FakeIssueRepository);
            // 
            // FormSelectIssue
            // 
            this.AcceptButton = this.buttonSelectIssue;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(454, 311);
            this.Controls.Add(this.gridViewIssues);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSelectIssue);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSelectIssue";
            this.Text = "Select Project";
            this.Load += new System.EventHandler(this.PreferenceSelectIssue_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridViewIssues)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);


        }

        #endregion
        private System.Windows.Forms.Button buttonSelectIssue;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.DataGridView gridViewIssues;
        private System.Windows.Forms.BindingSource fakeIssueRepositoryBindingSource;
    }
}