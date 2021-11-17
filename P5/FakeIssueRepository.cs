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
                Add(new Issue { Id = 1, ProjectId = 1, Title = "SAMPLE ISSUE TITLE", DiscoveryDate = DateTime.Now, Discoverer = "Sereda, Tim", InitialDescription = "SOME ISSUE DESCRIPTION", Component="SOME COMPONENT", IssueStatusId=1 });
                Add(new Issue { Id = 2, ProjectId = 1, Title = "SAMPLE ISSUE TITLE", DiscoveryDate = DateTime.Now, Discoverer = "Zastera, Jackson", InitialDescription = "SOME ISSUE DESCRIPTION", Component = "SOME COMPONENT", IssueStatusId = 1 });
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

            issue.Id = _Issues.Count+1;
            _Issues.Add(issue);
            return NO_ERROR;
        }

        public List<Issue> GetAll(int ProjectId)
        {
            List<Issue> projIssues = new List<Issue>();

            foreach (Issue issue in _Issues)
            {
                if (issue.ProjectId == ProjectId)
                {
                    projIssues.Add(issue);
                }
            }

            return projIssues;
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


        public List<string> GetIssuesByMonth(int ProjectId)
        {
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            Dictionary<string, int> monthDictionary = new Dictionary<string, int>();
            List<string> monthStringList = new List<string>();

            _Issues = fakeIssueRepository.GetAll(ProjectId);

            foreach (Issue issue in _Issues)
            {
                string dateLine = issue.DiscoveryDate.Year.ToString() + " - " + issue.DiscoveryDate.Month.ToString();
                if (monthDictionary.ContainsKey(dateLine)) monthDictionary[dateLine] += 1;
                else monthDictionary.Add(dateLine, 1);
            }

            foreach (string yearMonth in monthDictionary.Keys)
            {
                monthStringList.Add(yearMonth + ": " + monthDictionary[yearMonth]);
            }

            return monthStringList;
        }

        public List<string> GetIssuesByDiscoverer(int ProjectId)
        {
            FakeIssueRepository fakeIssueRepository = new FakeIssueRepository();
            Dictionary<string, int> discovererDictionary = new Dictionary<string, int>();
            List<string> discovererStringList = new List<string>();  

            _Issues = fakeIssueRepository.GetAll(ProjectId);

            foreach(Issue issue in _Issues)
            {
                if (discovererDictionary.ContainsKey(issue.Discoverer)) discovererDictionary[issue.Discoverer] += 1;
                else discovererDictionary.Add(issue.Discoverer, 1);
            }

            foreach(string discoverer in discovererDictionary.Keys)
            {
                discovererStringList.Add(discoverer + ": " + discovererDictionary[discoverer]);
            } 

            return discovererStringList;
        }
        public Issue GetIssueById(int Id)
        {
            foreach (Issue issue in _Issues)
            {
                if (issue.Id == Id) return issue;
            }
            return null;
        }
    }
}
