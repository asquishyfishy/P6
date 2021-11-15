using System;
using System.Collections.Generic;

namespace P5
{

    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A Title is required.";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a Discovery Date/Time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future.";
        public const string EMPTY_DISCOVORER_ERROR = "A Discoverer is required.";

        private static List<IssueStatus> _IssueStatuses = new List<IssueStatus>();
        public FakeIssueRepository()
        {
            if (_IssueStatuses.Count == 0)
            {
                // Populate some temporary values to work with
                Add(new Issue { Id = 1, ProjectId = 1, Title = "SAMPLE ISSUE TITLE", DiscoveryDate = DateTime.Now,InitialDescription = "SOME ISSUE DESCRIPTION", Component="SOME COMPONENT", IssueStatusId=1 });
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
