package com.company;

import java.util.Scanner;


public class CharacterMultiplier {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] strings = sc.nextLine().split("\\s");
        int sumOfCharacters = multiplayCharacters(strings[0],strings[1]);
        System.out.println(sumOfCharacters);
    }

    private static int multiplayCharacters(String str1, String str2) {
        int totalSum = 0;
        if(str1.length() < str2.length())
        {
            for (int i = 0; i < str1.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }
            for (int i = str1.length(); i < str2.length(); i++) {
                totalSum += str2.charAt(i);
            }
            return totalSum;
        }
        else if(str1.length() > str2.length())
        {
            for (int i = 0; i < str2.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }
            for (int i = str2.length(); i < str1.length(); i++) {
                totalSum += str1.charAt(i);
            }
            return totalSum;
        }
        else {
            for (int i = 0; i < str1.length(); i++) {
                totalSum += str1.charAt(i) * str2.charAt(i);
            }
            return totalSum;
        }
    }
}
