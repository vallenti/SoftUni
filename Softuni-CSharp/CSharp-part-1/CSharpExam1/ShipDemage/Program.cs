using System;

class Program
{
    static void Main()
    {
        int sx1 = int.Parse(Console.ReadLine());
        int sy1 = int.Parse(Console.ReadLine());
        int sx2 = int.Parse(Console.ReadLine());
        int sy2 = int.Parse(Console.ReadLine());
        int h = int.Parse(Console.ReadLine());
        int cx1 = int.Parse(Console.ReadLine());
        int cy1 = int.Parse(Console.ReadLine());
        int cx2 = int.Parse(Console.ReadLine());
        int cy2 = int.Parse(Console.ReadLine());
        int cx3 = int.Parse(Console.ReadLine());
        int cy3 = int.Parse(Console.ReadLine());
        int damage = 0;

        //find projected points
        int ppc1X = cx1;
        int ppc1Y = 2 * h - cy1;
        int ppc2X = cx2;
        int ppc2Y = 2 * h - cy2;
        int ppc3X = cx3;
        int ppc3Y = 2 * h - cy3;

        //find ship boundries
        int downSide = Math.Min(sy1, sy2);
        int upSide = Math.Max(sy1, sy2);
        int leftSide = Math.Min(sx1, sx2);
        int rightSide = Math.Max(sx1, sx2);

        //check for internal demage
        if (ppc1X > leftSide && ppc1X < rightSide && ppc1Y > downSide && ppc1Y < upSide)
        {
            damage += 100;
        }
        else if (ppc2X > leftSide && ppc2X < rightSide && ppc2Y > downSide && ppc2Y < upSide)
        {
            damage += 100;
        }
        else if (ppc3X > leftSide && ppc3X < rightSide && ppc3Y > downSide && ppc3Y < upSide)
        {
            damage += 100;
        }

        //check for side hits up/down
        if ((ppc1X > leftSide && ppc1X < rightSide) && (ppc1Y == downSide || ppc1Y == upSide))
        {
            damage += 50;
        }
        else if ((ppc2X > leftSide && ppc2X < rightSide) && (ppc2Y == downSide || ppc2Y == upSide))
        {
            damage += 50;
        }
        else if ((ppc3X > leftSide && ppc3X < rightSide) && (ppc3Y == downSide || ppc3Y == upSide))
        {
            damage += 50;
        }
        //check for side hits right/left
        if ((ppc1Y > downSide && ppc1Y < upSide) && (ppc1X == leftSide || ppc1X == rightSide))
        {
            damage += 50;
        }
        else if ((ppc2Y > downSide && ppc2Y < upSide) && (ppc2X == leftSide || ppc2X == rightSide))
        {
            damage += 50;
        }
        else if ((ppc3Y > downSide && ppc3Y < upSide) && (ppc3X == leftSide || ppc3X == rightSide))
        {
            damage += 50;
        }

        //check for corner hits
        if ((ppc1X==leftSide || ppc1X==rightSide)&&(ppc1Y==upSide || ppc1Y==downSide))
        {
            damage += 25;
        }
        else if ((ppc2X == leftSide || ppc2X == rightSide) && (ppc2Y == upSide || ppc2Y == downSide))
        {
            damage += 25;
        }
        else if ((ppc3X == leftSide || ppc3X == rightSide) && (ppc3Y == upSide || ppc3Y == downSide))
        {
            damage += 25;
        }

        Console.WriteLine(damage+"%");
    }
}

