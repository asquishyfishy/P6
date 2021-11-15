using System.Collections.Generic;

namespace P5
{
    public class FakeIssueRepository : IIssueRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public FakeIssueRepository()
        {
            if (_IssueStatuses.Count == 0)
            {
                // Populate some temporary values to work with
                
            }
        }
        public string Add(Issue issue)
        {
            return null;
        }

        public List<Issue> GetAll(int ProjectId)
        {
            return null;
        }

        public bool Remove(Issue issue)
        {
            return false;
        }

        public string Modify(IssueStatus status)
        {
            return null;
        }

        public int GetTotalNumberOfIssues(int ProjectId)
        {
            return 1;
        }

        public List<string> GetIssuesByMonth(int ProjectId)
        {
            return null;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            return null;
        }

        public Issue GetIssueById(int Id)
        {
            return null;
        }
    }
}
