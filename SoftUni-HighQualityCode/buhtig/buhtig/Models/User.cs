namespace BuhtigIssueTracker.Models
{
    using Utilities;

    public class User
    {
        private string username;
        private string password;

        public User(string username, string password)
        {
            this.Username = username;
            this.Password = HashUtilities.HashPassword(password);
        }

        public string Username
        {
            get
            {
                return this.username;
            }
            
            private set
            {
                //TODO validate
                this.username = value;
            }
        }

        public string Password
        {
            get
            {
                return this.password;
            }

            private set
            {
                //TODO validate
                this.password = value;
            }
        }
    }
}
