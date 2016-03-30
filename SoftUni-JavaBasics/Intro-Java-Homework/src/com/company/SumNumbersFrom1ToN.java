package com.company;

import java.util.Scanner;


public class SumNumbersFrom1ToN {
    public static void SumNumbers()
    {
        Scanner sc = new Scanner(System.in);
        int lastNumber = sc.nextInt();
        int sum = 0;
        for (int i = 1; i <= lastNumber; i++) {
            sum += i;
        }
        System.out.println(sum);
    }
}
