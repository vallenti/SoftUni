package com.company;


import java.util.Scanner;

public class _07CountSubstringOccurences {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine().toLowerCase();
        String searchWord = sc.nextLine().toLowerCase();
        int index = -1;
        int wordsCount = 0;
        do {
            index = text.indexOf(searchWord,index + 1);
            if (index != -1) {
                wordsCount++;
            }
        }while(index != -1);
        System.out.println(wordsCount);
    }
}
