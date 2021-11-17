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
        public FormIssueModify()
        {
            InitializeComponent();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            int ProjectId = 1;
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            //FakeAppUserRepository fakeAppUserRepository = new FakeAppUserRepository();
            foreach (Issue issue in fakeIssueRepository.GetAll(ProjectId))
            {
                dataGridView1.
            }
        }
    }
}
