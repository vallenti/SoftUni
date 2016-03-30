package com.company;


import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class ExtractWords {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String text = sc.nextLine();
        Pattern wordPattern = Pattern.compile("[a-zA-z]{2,}");
        Matcher matcher = wordPattern.matcher(text);
        while (matcher.find()) {
            System.out.print(matcher.group() + " ");
        }
    }
}
