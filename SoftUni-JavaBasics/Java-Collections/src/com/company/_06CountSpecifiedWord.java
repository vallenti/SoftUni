package com.company;


import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _06CountSpecifiedWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split("\\W+");
        String searchWord = sc.nextLine().toLowerCase();
        List<String> words = Arrays.stream(input).map(w -> w.toLowerCase()).collect(Collectors.toList());
        int count = 0;
        for (String word : words){
            if(word.equals(searchWord)){
                count++;
            }
        }
        System.out.println(count);
    }
}
