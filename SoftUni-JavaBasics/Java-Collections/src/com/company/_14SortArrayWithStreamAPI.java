package com.company;


import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _14SortArrayWithStreamAPI {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> numbers = Arrays.stream(sc.nextLine().split(" ")).map(Integer::parseInt).collect(Collectors.toList());
        String orderBy = sc.nextLine();
        if(orderBy.equals("Ascending")){
            numbers.stream().sorted().forEach(p -> System.out.print(p+" "));
        }
        else if(orderBy.equals("Descending")) {
            numbers.stream().sorted((e1,e2) -> e2.compareTo(e1)).forEach(p -> System.out.print(p + " "));
        }
    }
}
