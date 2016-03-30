using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HTMLDispatcher
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);
            Console.WriteLine(2 * div);

            string img = HTMLDispatcher.CreateImage("http://s.b", "test img", "test");
            Console.WriteLine(img);

            string url = HTMLDispatcher.CreateURL("http://www.softuni.bg", "softuni", "SoftUni link");
            Console.WriteLine(url);

            string input = HTMLDispatcher.CreateInput("text", "testText", "test1");
            Console.WriteLine(input);
        }
    }
}
