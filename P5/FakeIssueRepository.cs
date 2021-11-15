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

        private static List<Issue> _Issues = new List<Issue>();
        public FakeIssueRepository()
        {
            if (_Issues.Count == 0)
            {
                Add(new Issue { Id = 1, ProjectId = 1, Title = "SAMPLE ISSUE TITLE", DiscoveryDate = DateTime.Now, Discoverer = "tim", InitialDescription = "SOME ISSUE DESCRIPTION", Component="SOME COMPONENT", IssueStatusId=1 });
            }
        }
        public string Add(Issue issue)
        {
            string newIssueTitle = issue.Title.Trim();
            if (newIssueTitle is null)
            {
                return EMPTY_TITLE_ERROR;
            }
            if (issue.DiscoveryDate == DateTime.MinValue)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.DiscoveryDate.CompareTo(DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.Discoverer is null)
            {
                return EMPTY_DISCOVORER_ERROR;
            }

            issue.Id = GetTotalNumberOfIssues(issue.ProjectId)+1;
            _Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectId)
        {
            return _Issues;
        }

        public bool Remove(Issue issue)
        {
            _Issues.RemoveAt(issue.Id);
            return true;
        }

        public string Modify(Issue issue)
        {
            string newIssueTitle = issue.Title.Trim();
            if (newIssueTitle is null)
            {
                return EMPTY_TITLE_ERROR;
            }
            if (issue.DiscoveryDate == DateTime.MinValue)
            {
                return EMPTY_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.DiscoveryDate.CompareTo(DateTime.Now) > 0)
            {
                return FUTURE_DISCOVERY_DATETIME_ERROR;
            }
            if (issue.Discoverer is null)
            {
                return EMPTY_DISCOVORER_ERROR;
            }

            issue.Id = GetTotalNumberOfIssues(issue.ProjectId) + 1;
            _Issues.Add(issue);
            return NO_ERROR;
        }


        public int GetTotalNumberOfIssues(int ProjectId)
        {
            return _Issues.Count;
        }

        //TODO
        public List<string> GetIssuesByMonth(int ProjectId)
        {
            return null;
        }

        //TODO
        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            return null;
        }

        //TODO
        public Issue GetIssueById(int Id)
        {
            return null;
        }
    }
}
