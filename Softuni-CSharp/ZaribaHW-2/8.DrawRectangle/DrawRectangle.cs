using System;

class DrawRectangle
{
    static void Main()
    {
        char space = ' ';
        char invertedQuestionMark = (char)168;

        Console.WriteLine(new string(invertedQuestionMark,6));
        Console.WriteLine(invertedQuestionMark+new string(space, 4)+invertedQuestionMark);
        Console.WriteLine(new string(invertedQuestionMark, 6));
    }
}

