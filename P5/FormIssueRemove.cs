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
    public partial class FormIssueRemove : Form
    {
        AppUser _CurrentAppUser;
        public FormIssueRemove(AppUser appUser)
        {
            InitializeComponent();
            _CurrentAppUser = appUser;
        }
        private DataGrid dataGrid;
        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIssueModify_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            DataTable datatable = new DataTable();
            datatable.Columns.Add("Id", typeof(int));
            datatable.Columns.Add("Title", typeof(string));
            datatable.Columns.Add("Discovery Date", typeof(DateTime));
            datatable.Columns.Add("Discoverer", typeof(string));
            datatable.Columns.Add("Initial Description", typeof(string));
            datatable.Columns.Add("Component", typeof(string));
            datatable.Columns.Add("Status", typeof(int));

            this.dataGrid = new DataGrid();
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            foreach (Issue issue in fakeIssueRepository.GetAll(_CurrentAppUser.currentProjectId))
            {
                datatable.Rows.Add(issue.Id, issue.Title, issue.DiscoveryDate, issue.Discoverer, issue.InitialDescription, issue.Component, issue.IssueStatusId);
            }
            var bindingSource = new System.Windows.Forms.BindingSource();
            bindingSource.DataSource = datatable;
            dataGridView1.DataSource = bindingSource;
        }

        private void SelectIssuebutton_Click(object sender, EventArgs e)
        {
            if(dataGridView1.CurrentRow.Index > -1)
            {
                FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
                foreach (Issue issue in fakeIssueRepository.GetAll(_CurrentAppUser.currentProjectId))
                {
                   
                    if(issue.Id == Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString()))
                    {
                        fakeIssueRepository.Remove(issue); 
                    }
                }
            }
        }
    }
}
