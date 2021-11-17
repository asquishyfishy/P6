using System;
using System.Windows.Forms;

namespace P5
{
    public partial class FormSelectIssue : Form
    {
        public int _SelectedProjectId = -1;
        public string _SelectedProjectName = "";
        FakeProjectRepository _ProjectRepository = new FakeProjectRepository();

        public FormSelectIssue()
        {
            InitializeComponent();
        }

        private void PreferenceSelectIssue_Load(object sender, EventArgs e)
        {
            this.CenterToParent();
            foreach (Project project in _ProjectRepository.GetAll())
            {
                
            }

        }

        private void buttonSelectProject_Click(object sender, EventArgs e)
        {

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
