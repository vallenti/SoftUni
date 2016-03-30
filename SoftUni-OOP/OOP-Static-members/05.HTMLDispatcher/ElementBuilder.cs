using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.HTMLDispatcher
{
    class ElementBuilder
    {
        private string name;
        private string openTag;
        private string closeTag;
        private string content;

        public ElementBuilder(string name)
        {
            this.Name = name;
            this.OpenTag = name;
            this.CloseTag = name;
        }

        public string Name { get; set; }
        public string OpenTag
        {
            get
            {
                return this.openTag;
            }
            set
            {
                this.openTag = "<" + value + ">";
            }
        }
        public string CloseTag
        {
            get
            {
                return this.closeTag;
            }
            set
            {
                this.closeTag = "</" + value + ">";
            }
        }
        public string Content { get; set; }

        public void AddAttribute(string attribute, string value)
        {
            string fullAttribute = String.Format(" {0}=\"{1}\"", attribute, value);
            openTag = OpenTag.Insert(OpenTag.Length-1, fullAttribute);
        }
        public void AddContent(string content)
        {
            this.Content = this.Content+content;
        }

        public static string operator *(ElementBuilder eb, int times)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(eb);
            }
            return result.ToString();
        }
        public static string operator *(int times, ElementBuilder eb)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < times; i++)
            {
                result.Append(eb);
            }
            return result.ToString();
        }

        public override string ToString()
        {
            return OpenTag + Content + CloseTag;
        }
    }
}
