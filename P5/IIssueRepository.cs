using System.Collections.Generic;

namespace P5
{
    public interface IIssueRepository
    {
        string Add(Issue issue);

        List<IssueStatus> GetAll();

        int GetIdByStatus(string value);

        string GetValueById(int Id);
    }
}
