package com.company;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _09CombineListOfLetters {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String lineOne = sc.nextLine();
        String lineTwo = sc.nextLine();
        List<Character> l1 = new ArrayList<>();
        for (int i = 0; i < lineOne.length(); i++) {
            if(lineOne.charAt(i) != ' '){
                l1.add(lineOne.charAt(i));
            }
        }
        for (int i = 0; i < lineTwo.length(); i++) {
            if((lineTwo.charAt(i) != ' ')){
                l1.add(lineTwo.charAt(i));
            }
        }
        List<Character> result = l1.stream().distinct().collect(Collectors.toList());
        System.out.println(result);


    }
}
