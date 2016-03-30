using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BuhtigIssueTracker.Utilities
{
    public static class HashUtilities
    {
        public static string HashPassword(string password)
        {
            return string.Join(string.Empty, SHA1.Create().ComputeHash(Encoding.Default.GetBytes(password)).Select(x => x.ToString()));
        }
    }
}
