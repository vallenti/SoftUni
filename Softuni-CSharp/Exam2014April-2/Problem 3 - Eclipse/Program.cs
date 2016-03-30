using System;
using System.Text;

class Program
{
    static void Main()
    {
        int size = int.Parse(Console.ReadLine());
        int glassSize = size * 2;
        string border =' '+ MakeString('*', glassSize-2) + MakeString(' ', size+1) + MakeString('*', glassSize-2)+' ';
        string middle = '*' + MakeString('/', glassSize - 2) + '*' + MakeString('-', size-1) + '*' + MakeString('/', glassSize - 2) + '*';
        string glass = '*' + MakeString('/', glassSize - 2) + '*' + MakeString(' ', size-1) + '*' + MakeString('/', glassSize - 2) + '*';
        for (int row = 0; row < size; row++)
        {
            if (row == 0 || row == size - 1)
            {
                Console.WriteLine(border);
            }
            else if (row == size / 2)
            {
                Console.WriteLine(middle);
            }
            else
            {
                Console.WriteLine(glass);
            }
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

