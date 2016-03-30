package com.company;

import java.util.Scanner;


public class CalculateExpression {
    public static void main(String[] args)
    {
        Scanner sc = new Scanner(System.in);
        double a = sc.nextDouble();
        double b = sc.nextDouble();
        double c = sc.nextDouble();

        double formulaOne = Math.pow(((Math.pow(a,2)+Math.pow(b,2))/(Math.pow(a,2)-Math.pow(b,2))),((a+b+c)/Math.sqrt(c)));
        double formulaTwo = Math.pow((Math.pow(a,2)+Math.pow(b,2)-Math.pow(c,3)),(a-b));
        double averageABC = (a+b+c)/3;
        double averageFormulas = (formulaOne+formulaTwo)/2;
        System.out.print(String.format("F1 result: %.2f; ", formulaOne));
        System.out.print(String.format("F2 result: %.2f; ",formulaTwo));
        System.out.print(String.format("Diff: %.2f",Math.abs(averageABC-averageFormulas)));
    }
}
