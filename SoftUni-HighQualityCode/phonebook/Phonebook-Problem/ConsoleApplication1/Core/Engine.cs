using ConsoleApplication1.Interfaces;
using ConsoleApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.Core
{
    class Engine
    {
        private const string code = "+359";

        private static IPhonebookRepository data = new PhonebookRepository();
        private static StringBuilder input = new StringBuilder();

        public void Run()
        {
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "End" || command == null)
                {
                    break;
                }
                string viewResult = string.Empty;
                try
                {
                    var ep = new Command(command);
                    viewResult = CommandDispatcher.ReturnsCommand(ep);
                    Console.WriteLine(viewResult);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                


                if ((ep.Action == "AddPhone") && (ep.Parameters.Length >= 2))
                {
                    Cmd("Cmd3", ep.Parameters);
                }
                else if ((ep.Action == "ChangeРhone") && (ep.Parameters.Length == 2))
                {
                    Cmd("Cmd2", ep.Parameters);
                }
                else if ((ep.Action == "List") && (ep.Parameters.Length == 2))
                {
                    Cmd("Cmd1", ep.Parameters);
                }
            }
            Console.Write(input);
        }

        private static void Cmd(string cmd, string[] strings)
        {
            if (cmd == "Cmd1") // first command
            {
                string str0 = strings[0]; var str1 = strings.Skip(1).ToList();
                for (int i = 0; i < str1.Count; i++)
                {
                    str1[i] = conv(str1[i]);
                }
                bool flag = data.AddPhone(str0, str1);
                if (flag)
                {
                    Print("Phone entry created.");
                }
                else
                {
                    Print("Phone entry merged");
                }
            }
            else if (cmd == "Cmd2") // second command
            {
                Print("" + data.ChangePhone(conv(strings[0]), conv(strings[1])) + " numbers changed");
            }
            else // third command
                try
                {
                    IEnumerable<Contact> entries = data.ListEntries(int.Parse(strings[0]), int.Parse(strings[1]));
                    foreach (var entry in entries) Print(entry.ToString());
                }
                catch (ArgumentOutOfRangeException)
                {
                    Print("Invalid range");
                }
        }

        private static string conv(string num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= input.Length; i++)
            {
                sb.Clear(); foreach (char ch in num) if (char.IsDigit(ch) || (ch == '+')) sb.Append(ch);
                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
                { sb.Remove(0, 1); sb[0] = '+'; }
                while (sb.Length > 0 && sb[0] == '0') sb.Remove(0, 1);


                if (sb.Length > 0 && sb[0] != '+') sb.Insert(0, code);
                sb.Clear();
                foreach (char ch in num) if (char.IsDigit(ch) || (ch == '+')) sb.Append(ch);
                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')
                { sb.Remove(0, 1); sb[0] = '+'; }


                while (sb.Length > 0 && sb[0] == '0') sb.Remove(0, 1);
                if (sb.Length > 0 && sb[0] != '+') sb.Insert(0, code);
                sb.Clear();
                foreach (char ch in num) if (char.IsDigit(ch) || (ch == '+')) sb.Append(ch);
                if (sb.Length >= 2 && sb[0] == '0' && sb[1] == '0')



                { sb.Remove(0, 1); sb[0] = '+'; }
                while (sb.Length > 0 && sb[0] == '0') sb.Remove(0, 1);
                if (sb.Length > 0 && sb[0] != '+') sb.Insert(0, code);
            }
            return sb.ToString();
        }
        private static void Print(string text)
        {
            input.AppendLine(text);
        }
    }
}

