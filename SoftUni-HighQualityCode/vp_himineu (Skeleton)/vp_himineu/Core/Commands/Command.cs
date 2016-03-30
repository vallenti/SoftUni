namespace VehicleParkSystem.Core.Commands
{
    using System;
    using System.Collections.Generic;
    using System.Web.Script.Serialization;
    using Interfaces;

    public class Command : ICommand
    {
        public string Name { get; set; }
        public IDictionary<string, string> Parameters { get; set; }

        public Command(string str)
        {
            Name = str.Substring(0, str.IndexOf(' '));
            Parameters = new JavaScriptSerializer()
                .Deserialize<Dictionary<string, string>>(str.Substring(str.IndexOf(' ') + 1));
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            throw new NotImplementedException();
        }

        public void Execute(object parameter)
        {
            throw new NotImplementedException();
        }
    }
}
