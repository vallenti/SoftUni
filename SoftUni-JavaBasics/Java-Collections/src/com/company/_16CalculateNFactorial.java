package com.company;


import java.util.Scanner;

public class _16CalculateNFactorial {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int number = Integer.parseInt(sc.nextLine());
        System.out.println(calculateFactorial(number));
    }

    public static int calculateFactorial(int n){
        if(n == 1 || n == 0){
            return 1;
        }
        else {
            return n * calculateFactorial(n-1);
        }
    }
}
