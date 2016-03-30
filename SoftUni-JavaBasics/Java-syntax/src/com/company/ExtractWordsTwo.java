package com.company;

import java.util.Scanner;
import java.util.regex.*;


public class ExtractWordsTwo {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().split("\\s");

        Pattern wordPattern = Pattern.compile("\\b[A-Z][a-zA-Z]*[A-Z]\\b");
        for (int i = 0; i < words.length; i++) {
            Matcher matcher = wordPattern.matcher(words[i]);
            if(matcher.find()){
                System.out.print(words[i]+" ");
            }
        }

    }
}
