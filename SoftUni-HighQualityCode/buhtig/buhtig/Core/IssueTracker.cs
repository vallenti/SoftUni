using BuhtigIssueTracker.Interfaces;
using BuhtigIssueTracker.Models;
using BuhtigIssueTracker.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuhtigIssueTracker.Core
{
    public class IssueTracker : IIssueTracker
    {
        IssueTracker(IBuhtigIssueTrackerData data)
        {
            this.Data = data as BuhtigIssueTrackerData;
        }
        public IssueTracker()
            : this(new BuhtigIssueTrackerData())
        { }
        BuhtigIssueTrackerData Data { get; set; }

        public string RegisterUser(string username, string password, string confirmPassword)
        {
            if (Data.CurrentUser != null)
                return string.Format("There is already a logged in user");
            if (password != confirmPassword)
                return string.Format("The provided passwords do not match", username);
            if (Data.Users.ContainsKey(username))
                return string.Format("A user with username {0} already exists", username);
            var user = new User(username, password);
            Data.Users.Add(username, user);
            return string.Format("User {0} registered successfully", username);
        }
        public string LoginUser(string username, string password)
        {
            if (Data.CurrentUser != null)
                return string.Format("There is already a logged in user");
            if (!Data.Users.ContainsKey(username))
                return string.Format("A user with username {0} does not exist", username);
            var user = Data.Users[username];
            if (user.Password != HashUtilities.HashPassword(password))
                return string.Format("The password is invalid for user {0}", username);

            Data.CurrentUser = user;

            return string.Format("User {0} logged in successfully", username);
        }

        public string LogoutUser()
        {
            if (Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }
            string username = Data.CurrentUser.Username;
            Data.CurrentUser = null;
            return string.Format("User {0} logged out successfully", username);
        }

        public string CreateIssue(string title, string description, IssuePriority priority, string[] tags)
        {
            if (Data.CurrentUser == null)
                return string.Format("There is no currently logged in user");

            var issue = new Issue(title, description, priority, tags.Distinct().ToList());
            var issueId = Data.AddIssue(issue);
            
            return string.Format("Issue {0} created successfully", issueId);
        }

        public string RemoveIssue(int issueId)
        {
            if (Data.CurrentUser == null)
                return string.Format("There is no currently logged in user");
            if (!Data.IssuesById.ContainsKey(issueId))
                return string.Format("There is no issue with ID {0}", issueId);
            var issue = Data.IssuesById[issueId];
            if (!Data.IssuesByUsername[Data.CurrentUser.Username].Contains(issue))
                return string.Format("The issue with ID {0} does not belong to user {1}", issueId, this.Data.CurrentUser.Username);

            Data.RemoveIssue(issue);

            return string.Format("Issue {0} removed", issueId);
        }

        public string AddComment(int intValue, string stringValue)
        {
            if (Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }
            if (!Data.IssuesById.ContainsKey(intValue))
            {
                return string.Format("There is no issue with ID {0}", intValue);
            }
            var issue = Data.IssuesById[intValue];
            var comment = new Comment(Data.CurrentUser, stringValue);
            issue.AddComment(comment);
            Data.CommentsByUsers[Data.CurrentUser].Add(comment);
            return string.Format("Comment added successfully to issue {0}", issue.Id);
        }

        public string GetMyIssues()
        {
            if (Data.CurrentUser == null)
                return string.Format("There is no currently logged in user");

            var issues = Data.IssuesByUsername[Data.CurrentUser.Username];
            var newIssues = issues;
            if (!newIssues.Any())
            {
                var result = "";
                foreach (var i in Data.IssuesByUsername)
                    result += i.Value.Select(iss => iss.Comments.Select(c => c.Text)).ToString();
                return "No issues";
            }

            return string.Join(Environment.NewLine, newIssues.OrderByDescending(x => x.Priority).ThenBy(x => x.Title));
        }

        public string GetMyComments()
        {
            if (Data.CurrentUser == null)
            {
                return string.Format("There is no currently logged in user");
            }

            var comments = this.Data.CommentsByUsers[this.Data.CurrentUser]
                .Select(i => i.ToString());
            if (!comments.Any())
            {
                return "No comments";
            }

            return string.Join(Environment.NewLine, comments);
        }

        public string SearchForIssues(string[] strings)
        {
            if (strings.Length < 0)
                return "There are no tags provided";

            var i = new List<Issue>();
            foreach (var t in strings)
                i.AddRange(Data.IssuesByTag[t]);
            if (!i.Any())
                return "There are no issues matching the tags provided";
            var newi = i.Distinct();
            if (!newi.Any())
            {
                return "No issues";
            }

            return string.Join(
                Environment.NewLine, 
                newi.OrderByDescending(x => x.Priority).ThenBy(x => x.Title)
                .Select(x => x));
        }
    }
}
