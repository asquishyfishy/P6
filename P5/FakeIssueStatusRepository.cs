using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static Dictionary<string, IssueStatus> _IssueStatuses;
        private static List<IssueStatus> _IssueStatus = new List<IssueStatus>();
        public FakeIssueStatusRepository()
        {
            if (_IssueStatus.Count == 0)
            {
                // Populate some temporary values to work with
                
            }
            _IssueStatuses = new Dictionary<string, IssueStatus>();
            _IssueStatuses.Add("Open", new IssueStatus
            {
                Id = 1,
                Value = "Open"
            }); ;
            _IssueStatuses.Add("Assigned", new IssueStatus
            {
                Id = 2,
                Value = "Assigned"
            });
            _IssueStatuses.Add("Fixed", new IssueStatus
            {
                Id = 3,
                Value = "Fixed"
            });
            _IssueStatuses.Add("Closed-Won't fix", new IssueStatus
            {
                Id = 4,
                Value = "Closed - Won't Fix"
            });
            _IssueStatuses.Add("Closed-Fixed", new IssueStatus
            {
                Id = 5,
                Value = "Closed - Fixed"
            });
            _IssueStatuses.Add("Closed-By Design", new IssueStatus
            {
                Id = 6,
                Value = "Closed - By Design"
            });

        }
        public void Add(int Id, string value)
        {
            
        }
        public List<IssueStatus> GetAll()
        {
            List<IssueStatus> issueStatuses = new List<IssueStatus>();
            foreach(IssueStatus issueStatus in _IssueStatuses.Values)
            {
                issueStatuses.Add(issueStatus);
            }
            return issueStatuses;
        }
        public int GetIdByStatus(string value)
        {
            return 1;
        }
        public string GetValueById(int Id)
        {
            return "string";
        }
    }
}
