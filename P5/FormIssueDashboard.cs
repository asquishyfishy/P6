﻿using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueDashboard : Form
    {

        public FormIssueDashboard(AppUser appUser)
        {
            InitializeComponent();
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            FakeIssueRepository _Issues = new FakeIssueRepository();
            NumberOfIssues.Text = _Issues.GetAll(1).Count.ToString();
        }
    }
}
