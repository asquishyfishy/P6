﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueReord : Form
    {
        public FormIssueReord()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueReord_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            Issue issue = new Issue();
            issue.Title = TitleTextBox.Text.Trim();
            issue.DiscoveryDate = dateTimePicker1.Value;
            issue.Discoverer = DiscovererComboBox.Text.Trim();
            issue.Component = ComponentTextBox.Text.Trim();
            issue.InitialDescription = richTextBox1.Text;
        }
    }
}
