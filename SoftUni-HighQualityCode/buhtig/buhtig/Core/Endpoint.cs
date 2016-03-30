﻿using BuhtigIssueTracker.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BuhtigIssueTracker.Core
{
    public class Endpoint : IEndpoint
    {
        public Endpoint(string url)
        {
            int questionMark = url.IndexOf('?');
            if (questionMark != -1)
            {
                this.ActionName = url.Substring(0, questionMark);
                var pairs = url.Substring(questionMark + 1).Split('&').Select(x => x.Split('=').Select(xx => WebUtility.UrlDecode(xx)).ToArray());
                var parameters = new Dictionary<string, string>();
                foreach (var pair in pairs)
                    parameters.Add(pair[0], pair[1]);
                this.Parameters = parameters;
            }
            else
                this.ActionName = url;
        }
        public string ActionName { get; set; }
        public IDictionary<string, string> Parameters { get; set; }

    }
}
