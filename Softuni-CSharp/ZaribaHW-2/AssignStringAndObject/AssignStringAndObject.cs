using System;

class AssignStringAndObject
{
    static void Main()
    {
        string zariba = "Zariba";
        string academy = "Academy";
        object zaribaAcademy = zariba + " " + academy;
        string finalString = zaribaAcademy.ToString();
    }
}
