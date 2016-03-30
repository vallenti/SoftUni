package com.company;


import java.util.Scanner;

public class OddEvenPairs {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String[] numbers = sc.nextLine().split("\\s");
        if(numbers.length % 2 == 1){
            System.out.println("Invalid length");
        }
        else {
            for (int i = 0; i < numbers.length - 1; i += 2) {
                int firstNumber = Integer.parseInt(numbers[i]);
                int secondNumber = Integer.parseInt(numbers[i + 1]);
                System.out.printf("%d, %d -> ", firstNumber, secondNumber);
                if (firstNumber % 2 == 0 && secondNumber % 2 == 0) {
                    System.out.println("both are even");
                } else if (firstNumber % 2 == 1 && secondNumber % 2 == 1) {
                    System.out.println("both are odd");
                } else {
                    System.out.println("different");
                }
            }
        }
    }
}
