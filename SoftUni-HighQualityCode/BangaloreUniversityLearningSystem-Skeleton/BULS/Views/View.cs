namespace BangaloreUniversityLearningSystem.Views
{
    using System.Text;
    using Interfaces;
    
    public abstract class View : IView
    {
        private object model;

        public View(object model)
        {
            this.Model = model;
        }

        public object Model
        {
            get
            {
                return this.model;
            }

            private set
            {
                this.model = value;
            }
        }

        public string Display()
        {
            var viewResult = new StringBuilder();
            this.BuildViewResult(viewResult);

            return viewResult.ToString().Trim();
        }

        internal abstract void BuildViewResult(StringBuilder viewResult);
    }
}
