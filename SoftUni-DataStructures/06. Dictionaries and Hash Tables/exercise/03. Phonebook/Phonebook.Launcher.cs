using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            HashTable<string, string> phonebook = new HashTable<string, string>();
            string command = Console.ReadLine();

            //add contacts
            while(command != "search")
            {
                string[] contactDetails = command.Split(new char[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
                string name = contactDetails[0];
                string phone = contactDetails[1];
                if(!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, phone);
                }

                command = Console.ReadLine();
            }

            //search contacts
            string lookupName = Console.ReadLine();
            while(true)
            {
                if(phonebook.ContainsKey(lookupName))
                {
                    var contact = phonebook.Find(lookupName);
                    Console.WriteLine("{0} -> {1}", contact.Key, contact.Value);
                }
                else
                {
                    Console.WriteLine("Contact {0} does not exist.", lookupName);
                }

                lookupName = Console.ReadLine();
            }
        }
    }
}
