using _03.Company.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Project : IProject
    {
        public Project(string name, DateTime startDate, string details, ProjectState state)
        {
            this.Name = name;
            this.StartDate = startDate;
            this.Details = details;
            this.State = state;
        }

        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public string Details { get; set; }
        public ProjectState State { get; set; }

        public override string ToString()
        {
            return "+" + this.Name + " " + this.State + " " + this.StartDate + " " + this.Details;
        }
    }
    public enum ProjectState
    {
        Open,
        Closed
    }
}
