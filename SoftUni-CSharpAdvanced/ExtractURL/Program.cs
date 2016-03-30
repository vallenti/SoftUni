using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ExtractURL
{
    static void Main()
    {
        string input = "The site nakov.com can be access from http://nakov.com or www.nakov.com. It has subdomains like mail.nakov.com and svetlin.nakov.com. Please check http://blog.nakov.com for more information.";
        char[] separators = new char[] { ' ' };
        string[] text = input.Split(separators, StringSplitOptions.RemoveEmptyEntries);
        
        string pattern1 = @"(http:\/\/)[a-zA-z0-9$-_.+!*'(),]\w+.\w+"; // pattern http://something
        string pattern2 = @"(www.)[a-zA-z0-9$-_.+!*'(),]\w+.[a-zA-z]{2,6}"; // pattern www.something.domain

        foreach (string word in text)
        {
            if (Regex.IsMatch(word, pattern1) || Regex.IsMatch(word, pattern2))
            {
                Console.WriteLine(word);
            }
        }
       
    }
}

