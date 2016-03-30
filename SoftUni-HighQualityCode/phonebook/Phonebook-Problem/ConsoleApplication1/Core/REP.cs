using ConsoleApplication1.Interfaces;
using ConsoleApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace ConsoleApplication1.Core
{
    public class PhoneBook : IPhonebookRepository
    {
        private OrderedSet<Contact> sorted =
            new OrderedSet<Contact>(); private Dictionary<string, Contact> dict =
             new Dictionary<string, Contact>(); private MultiDictionary<string, Contact> multidict =
              new MultiDictionary<string, Contact>(false);

        public bool AddPhone(string name, IEnumerable<string> nums)
        {
            string name2 = name.ToLowerInvariant();
            Contact entry; bool flag = !this.dict.TryGetValue(name2, out entry);
            if (flag)
            {
                entry = new Contact();
                entry.Name = name;
                entry.Strings = new SortedSet<string>();
                this.dict.Add(name2, entry);
                this.sorted.Add(entry);
            }
            foreach (var num in nums)
            {
                this.multidict.Add(num, entry);
            }
            entry.Strings.UnionWith(nums);
            return flag;
        }

        public int ChangePhone(string oldent, string newent)
        {
            var found = this.multidict[oldent].ToList(); foreach (var entry in found)
            {
                entry.Strings.Remove(oldent);
                this.multidict.Remove(oldent, entry);



                entry.Strings.Add(newent); this.multidict.Add(newent, entry);
            }
            return found.Count;
        }

        public Contact[] ListEntries(int first, int num)
        {
            if (first < 0 || first + num > this.dict.Count) { Console.WriteLine("Invalid start index or count."); return null; }
            Contact[] list = new Contact[num];

            for (int i = first; i <= first + num - 1; i++)
            {
                Contact entry = this.sorted[i];
                list[i - first] = entry;
            }
            return list;
        }
    }
}
