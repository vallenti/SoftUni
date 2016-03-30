package com.company;


import java.util.Scanner;

public class PrintCharacterTriangle {
    public static void PrintCharacterTriangleProblem()
    {
        Scanner sc = new Scanner(System.in);
        int input = sc.nextInt();
        for (int row = 0; row <= input; row++) {
            for (char col = 'a'; col < row+'a'; col++) {
                System.out.print(col + " ");
            }
            System.out.println();
        }
        for (int row = input-1; row > 0; row--) {
            for (char col = 'a'; col < row+'a'; col++) {
                System.out.print(col + " ");
            }
            System.out.println();
        }
    }
}
