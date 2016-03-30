using BuhtigIssueTracker.Interfaces;
using BuhtigIssueTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuhtigIssueTracker.Core
{
    public class CommandDispatcher
    {
        CommandDispatcher(IIssueTracker tracker)
        {
            this.Tracker = tracker;
        }
        public CommandDispatcher() 
            : this(new IssueTracker())
        {
        }

        IIssueTracker Tracker { get; set; }

        public string DispatchAction(IEndpoint url)
        {
            switch (url.ActionName)
            {
                case "":
                    return string.Empty;
                case "RegisterUser":
                    return Tracker.RegisterUser(
                        url.Parameters["username"], 
                        url.Parameters["password"], 
                        url.Parameters["confirmPassword"]);
                case "LoginUser":
                    return Tracker.LoginUser(
                        url.Parameters["username"], 
                        url.Parameters["password"]);
                case "LogoutUser":
                    return Tracker.LogoutUser();
                case "CreateIssue":
                    return Tracker.CreateIssue(
                        url.Parameters["title"], 
                        url.Parameters["description"],
                        (IssuePriority)Enum.Parse(typeof(IssuePriority),
                        url.Parameters["priority"], true),
                        url.Parameters["tags"].Split('|'));
                case "RemoveIssue":
                    return Tracker.RemoveIssue(int.Parse(url.Parameters["id"]));
                case "AddComment":
                    return Tracker.AddComment(
                        int.Parse(url.Parameters["id"]),
                        url.Parameters["text"]);
                case "MyIssues":
                    return Tracker.GetMyIssues();
                case "MyComments":
                    return Tracker.GetMyComments();
                case "Search":
                    return Tracker.SearchForIssues(url.Parameters["tags"].Split('|'));
                default:
                    return string.Format("Invalid action: {0}", url.ActionName);
            }
        }
    }
}
