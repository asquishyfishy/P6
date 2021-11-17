
namespace P5
{
    partial class FormIssueModify
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DiscoveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discoverer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InitialDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Component = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CancelButton = new System.Windows.Forms.Button();
            this.SelectIssuebutton = new System.Windows.Forms.Button();
            this.fakeIssueRepositoryBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fakeIssueRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fakeIssueRepositoryBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Title,
            this.DiscoveryDate,
            this.Discoverer,
            this.InitialDescription,
            this.Component,
            this.Status});
            this.dataGridView1.DataSource = this.fakeIssueRepositoryBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(12, 24);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(946, 311);
            this.dataGridView1.TabIndex = 0;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 40;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.MinimumWidth = 6;
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            this.Title.Width = 175;
            // 
            // DiscoveryDate
            // 
            this.DiscoveryDate.HeaderText = "Discovery Date";
            this.DiscoveryDate.MinimumWidth = 6;
            this.DiscoveryDate.Name = "DiscoveryDate";
            this.DiscoveryDate.ReadOnly = true;
            this.DiscoveryDate.Width = 150;
            // 
            // Discoverer
            // 
            this.Discoverer.HeaderText = "Discoverer";
            this.Discoverer.MinimumWidth = 6;
            this.Discoverer.Name = "Discoverer";
            this.Discoverer.ReadOnly = true;
            this.Discoverer.Width = 125;
            // 
            // InitialDescription
            // 
            this.InitialDescription.HeaderText = "Initial Description";
            this.InitialDescription.MinimumWidth = 6;
            this.InitialDescription.Name = "InitialDescription";
            this.InitialDescription.ReadOnly = true;
            this.InitialDescription.Width = 150;
            // 
            // Component
            // 
            this.Component.HeaderText = "Componenet";
            this.Component.MinimumWidth = 6;
            this.Component.Name = "Component";
            this.Component.ReadOnly = true;
            this.Component.Width = 125;
            // 
            // Status
            // 
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            this.Status.Width = 130;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(627, 404);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(122, 34);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // SelectIssuebutton
            // 
            this.SelectIssuebutton.Location = new System.Drawing.Point(836, 404);
            this.SelectIssuebutton.Name = "SelectIssuebutton";
            this.SelectIssuebutton.Size = new System.Drawing.Size(122, 34);
            this.SelectIssuebutton.TabIndex = 2;
            this.SelectIssuebutton.Text = "Select Issue";
            this.SelectIssuebutton.UseVisualStyleBackColor = true;
            // 
            // fakeIssueRepositoryBindingSource2
            // 
            this.fakeIssueRepositoryBindingSource2.DataSource = typeof(P5.FakeIssueRepository);
            // 
            // fakeIssueRepositoryBindingSource
            // 
            this.fakeIssueRepositoryBindingSource.DataSource = typeof(P5.FakeIssueRepository);
            // 
            // fakeIssueRepositoryBindingSource1
            // 
            this.fakeIssueRepositoryBindingSource1.DataSource = typeof(P5.FakeIssueRepository);
            // 
            // FormIssueModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 450);
            this.Controls.Add(this.SelectIssuebutton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormIssueModify";
            this.Text = "Select Issue";
            this.Load += new System.EventHandler(this.FormIssueModify_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fakeIssueRepositoryBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn DiscoveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discoverer;
        private System.Windows.Forms.DataGridViewTextBoxColumn InitialDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Component;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button SelectIssuebutton;
        private System.Windows.Forms.BindingSource fakeIssueRepositoryBindingSource;
        private System.Windows.Forms.BindingSource fakeIssueRepositoryBindingSource1;
        private System.Windows.Forms.BindingSource fakeIssueRepositoryBindingSource2;
    }
}