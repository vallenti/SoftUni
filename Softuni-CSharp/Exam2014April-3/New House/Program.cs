using System;
using System.Text;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string flat = '|' + MakeString('*', n - 2) + '|';
        int star = 1;
        
        while(star<=n)
        {
            int dash = (n - star) / 2;
            string str = MakeString('-', dash) + MakeString('*', star) + MakeString('-', dash);
            Console.WriteLine(str);
            star += 2;
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(flat);
        }
    }
    static string MakeString(char ch, int size)
    {
        StringBuilder sb = new StringBuilder(size);
        for (int i = 0; i < size; i++)
        {
            sb.Append(ch);
        }
        return sb.ToString();
    }
}

