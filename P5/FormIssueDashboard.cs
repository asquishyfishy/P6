using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormIssueDashboard : Form
    {

        public FormIssueDashboard(AppUser appUser)
        {
            InitializeComponent();

            FakeIssueStatusRepository _IssueStatuses = new FakeIssueStatusRepository();
            NumberOfIssues.Text = _IssueStatuses.GetAll().Count.ToString();
        }

        private void FormIssueDashboard_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void closebutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
