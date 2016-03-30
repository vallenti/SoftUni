namespace BuhtigIssueTracker.Interfaces
{
    using System.Collections.Generic;
    using Models;
    using Wintellect.PowerCollections;

    public interface IBuhtigIssueTrackerData
    {
        User CurrentUser { get; set; }
        IDictionary<string, User> Users { get; }
        OrderedDictionary<int, Issue> IssuesById { get; }
        MultiDictionary<string, Issue> IssuesByUsername { get; }
        MultiDictionary<string, Issue> IssuesByTag { get; }
        MultiDictionary<User, Comment> CommentsByUsers { get; }
        int AddIssue(Issue issue);
        void RemoveIssue(Issue issue);
    }
}
