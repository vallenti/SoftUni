using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Core
{
    class CommandDispatcher
    {
        public static string ReturnsCommand(ICommand command)
        {
            switch (command.Action)
            {
                case "AddPhone":
                    //add phone
                    break;
                case "ChangePhone":
                    //change phone
                    break;
                case "List":
                    //print list
                    break;
                case "End":
                    //exit program
                    break;
                default:
                    throw new InvalidOperationException("unknow command");
            }
        }
    }
}
