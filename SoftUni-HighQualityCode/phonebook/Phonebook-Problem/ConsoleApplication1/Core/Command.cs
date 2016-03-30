using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Core
{
    public class Command : ICommand
    {
        public Command(string command)
        {
            SetupCommand(command);
        }

        private void SetupCommand(string command)
        {
            int i = command.IndexOf('(');

            this.Action = command.Substring(0, i);

            this.Parameters = command
                .Substring(i + 1, command.Length - i - 2)
                .Split(',')
                .Select(x => x.Trim())
                .ToArray();
        }

        public string Action { get; set; }
        public string[] Parameters { get; set; }
    }
}
