package com.company;


import java.util.Arrays;
import java.util.Scanner;
import java.util.Set;
import java.util.TreeSet;

public class _10ExtractAllUniqueWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] text = sc.nextLine().split("[^a-zA-Z]+");
        Set<String> words = new TreeSet<>();
        for(String word : text){
            words.add(word.toLowerCase());
        }
        System.out.println(words);

    }
}
