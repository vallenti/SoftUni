package com.company;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _01SortArrayOfNumbers {

    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int size = Integer.parseInt(sc.nextLine());
        List<Integer> nums = Arrays
                                 .stream(sc.nextLine().split("\\s"))
                                 .map(Integer::parseInt)
                                 .collect(Collectors.toList());
        nums.stream()
                .sorted()
                .forEach(e -> System.out.printf("%d ", e));
    }
}
