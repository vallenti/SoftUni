namespace BuhtigIssueTracker.Core
{
    using Interfaces;
    using Models;
    using System.Collections.Generic;
    using Wintellect.PowerCollections;

    public class BuhtigIssueTrackerData : IBuhtigIssueTrackerData
    {
        private  int nextIssueId;

        public BuhtigIssueTrackerData()
        {
            nextIssueId = 1;
            Users = new Dictionary<string, User>();

            IssuesById = new OrderedDictionary<int, Issue>();
            IssuesByUsername = new MultiDictionary<string, Issue>(true);
            IssuesByTag = new MultiDictionary<string, Issue>(true);

            CommentsByUsers = new MultiDictionary<User, Comment>(true);
            Comments = new Dictionary<Comment, User>();
        }

        public User CurrentUser { get; set; }

        public IDictionary<string, User> Users { get; set; }

        public OrderedDictionary<int, Issue> IssuesById { get; set; }

        public MultiDictionary<string, Issue> IssuesByUsername { get; set; }

        public MultiDictionary<string, Issue> IssuesByTag { get; set; }

        public MultiDictionary<User, Comment> CommentsByUsers { get; set; }

        public Dictionary<Comment, User> Comments { get; set; }

        public int AddIssue(Issue issue)
        {
            issue.Id = nextIssueId;
            this.IssuesById.Add(issue.Id, issue);
            this.IssuesByUsername[this.CurrentUser.Username].Add(issue);
            foreach (var tag in issue.Tags)
            {
                this.IssuesByTag[tag].Add(issue);
            }

            return nextIssueId++;
        }

        public void RemoveIssue(Issue issue)
        {
            this.IssuesById.Remove(issue.Id);
            this.IssuesByUsername[this.CurrentUser.Username].Remove(issue);
            foreach (var tag in issue.Tags)
                this.IssuesByTag[tag].Remove(issue);
        }
    }
}

