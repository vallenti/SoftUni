namespace BangaloreUniversityLearningSystem.Views.Courses
{
    using System.Linq;
    using System.Text;
    using Models;

    public class Details : View
    {
        public Details(Course course)
            : base(course)
        {
        }

        internal override void BuildViewResult(StringBuilder viewResult)
        {
            var course = this.Model as Course;
            viewResult.AppendLine(course.Name);
            if (!course.Lectures.Any())
            {
                viewResult.AppendLine("No lectures");
            }
            else
            {
                foreach (var lecture in course.Lectures)
                {
                    viewResult.AppendFormat("- {0}", lecture.Name).AppendLine();
                }
            }
        }
    }
}
