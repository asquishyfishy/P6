using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueDashboard : Form
    {
        AppUser _CurrentAppUser;
        public FormIssueDashboard(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser; 
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            FakeIssueRepository _Issues = new FakeIssueRepository();
            FormSelectProject form = new FormSelectProject(_CurrentAppUser);

            NumberOfIssues.Text = _Issues.GetAll(_CurrentAppUser.currentProjectId).Count.ToString();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
