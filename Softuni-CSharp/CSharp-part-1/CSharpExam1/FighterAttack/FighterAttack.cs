using System;


class FighterAttack
{
    static void Main()
    {
        int px1 = int.Parse(Console.ReadLine());
        int py1 = int.Parse(Console.ReadLine());
        int px2 = int.Parse(Console.ReadLine());
        int py2 = int.Parse(Console.ReadLine());
        int fx = int.Parse(Console.ReadLine());
        int fy = int.Parse(Console.ReadLine());
        int d = int.Parse(Console.ReadLine());
        int damage = 0;

        //find hit point
        int hpX = fx+d;
        int hpY = fy;

        //find hit point side cells
        int hpLeftX = hpX;
        int hpLeftY = hpY + 1;
        int hpRightX = hpX;
        int hpRightY = hpY - 1;

        //find hit point front cell
        int hpFrontX = hpX + 1;
        int hpFrontY = hpY;

        //find plant boundries
        int downSide = Math.Min(py1, py2);
        int upSide = Math.Max(py1, py2);
        int leftSide = Math.Min(px1, px2);
        int rightSide = Math.Max(px1, px2);

        //check for direct hit
        if (hpX >= leftSide && hpX <= rightSide && hpY>=downSide && hpY<=upSide)
        {
            damage += 100;
        }
        //check for left side hit
        if (hpLeftX >= leftSide && hpLeftX <= rightSide && hpLeftY>=downSide && hpLeftY <= upSide )
        {
            damage += 50;
        }
        //check for right side hit
        if (hpRightX >= leftSide && hpRightX <= rightSide && hpRightY >= downSide && hpRightY <= upSide)
        {
            damage += 50;
        }
        //check for front hit
        if (hpFrontX >= leftSide && hpFrontX <= rightSide && hpFrontY >= downSide && hpFrontY <= upSide)
        {
            damage += 75;
        }
        Console.WriteLine(damage+"%");
    }
}