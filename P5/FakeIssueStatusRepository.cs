using System.Collections.Generic;

namespace P5
{
    public class FakeIssueStatustRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public FakeIssueStatustRepository()
        {
            if (_IssueStatuses.Count == 0)
            {
                int idToIgnore;
                // Populate some temporary values to work with
                
            }
        }
        public void Add(int Id, string value)
        {
            
        }
        public List<IssueStatus> GetAll()
        {
            return _IssueStatuses;
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
