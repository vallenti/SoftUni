package com.company;


import java.util.Scanner;

public class _05CountAllWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().split("[^a-zA-Z]+");
        System.out.println(words.length);
    }
}
