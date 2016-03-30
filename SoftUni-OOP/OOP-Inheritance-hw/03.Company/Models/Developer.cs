using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Company
{
    class Developer : RegularEmployee
    {

        public Developer(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary, Department.Production)
        {
            this.Projects = new HashSet<Project>();
        }

        public ISet<Project> Projects { get; private set; }

        public void AddProject(Project project)
        {
            if(project == null)
            {
                throw new ArgumentNullException("cannot add null project");
            }
            Projects.Add(project);
        }

        public override string ToString()
        {
            StringBuilder projectsList = new StringBuilder();
            projectsList.AppendLine();
            foreach (Project project in this.Projects)
            {
                projectsList.AppendLine(project.ToString());
            }

            return base.ToString()+projectsList.ToString();
        }
    }
}
