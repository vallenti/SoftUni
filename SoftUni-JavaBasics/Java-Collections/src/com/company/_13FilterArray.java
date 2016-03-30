package com.company;


import java.util.Arrays;
import java.util.Scanner;

public class _13FilterArray {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().split(" ");
        Arrays.stream(words).filter(e -> e.length()>3).forEach(p -> System.out.print(p+" "));
    }
}
