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
    public partial class FormIssueModify : Form
    {
        AppUser _CurrentAppUser;
        public FormIssueModify(AppUser appUser)
        {
            InitializeComponent();
            DataGrid dataGrid;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.dataGridView1 = new DataGrid();
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            foreach (Issue issue in fakeIssueRepository.GetAll(_CurrentAppUser.currentProjectId))
            {
               
            }
        }
    }
}
