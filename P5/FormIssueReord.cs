using System;
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
        AppUser _CurrentAppUser;
        public FormIssueReord(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueReord_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            FakeAppUserRepository _fakeAppUserRepository = new FakeAppUserRepository();
            FormSelectProject form = new FormSelectProject(_CurrentAppUser);
            FakeIssueStatusRepository fakeIssueStatusRepository = new FakeIssueStatusRepository();
            Idnum.Text = fakeIssueRepository.GetAll(_CurrentAppUser.currentProjectId).Count().ToString();
            dateTimePicker1.MaxDate = DateTime.Now;
           foreach(AppUser appUser in _fakeAppUserRepository.GetAll())
            {
                DiscovererComboBox.Items.Add(appUser.FirstName);
            }
           foreach(IssueStatus issueStatus in fakeIssueStatusRepository.GetAll())
            {
                StatusComboBox.Items.Add(issueStatus.Value);
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            int check = 0;
            if(string.IsNullOrEmpty(TitleTextBox.Text))
            {
                MessageBox.Show("A title is required", "Attention");
                check = 1;
            }
            if(string.IsNullOrEmpty(DiscovererComboBox.Text))
            {
                MessageBox.Show("Choose a Discoverer", "Attention");
                check = 1;
            }
            if(string.IsNullOrEmpty(StatusComboBox.Text))
            {
                MessageBox.Show("Choose a Status", "Attention");
                check = 1;
            }
            if (check == 0)
            {
                Issue issue = new Issue();
                FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
                FormSelectProject form = new FormSelectProject(_CurrentAppUser);
                issue.Id = fakeIssueRepository.GetAll(form._SelectedProjectId).Count();
                issue.ProjectId = _CurrentAppUser.currentProjectId;
                issue.Title = TitleTextBox.Text.Trim();
                issue.DiscoveryDate = dateTimePicker1.Value;
                issue.Discoverer = DiscovererComboBox.Text.Trim();
                issue.Component = ComponentTextBox.Text.Trim();
                issue.InitialDescription = richTextBox1.Text;
                fakeIssueRepository.Add(issue);
                this.Close();
            }
        }
    }
}
