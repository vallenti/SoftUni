package com.company;


import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _04LongestIncreasingSequence {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        List<Integer> nums = Arrays
                .stream(sc.nextLine().split("\\s"))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        List<Integer> tempArray = new ArrayList<>();
        List<Integer> longestArray = new ArrayList<>();
        for (int i = 0; i < nums.size()-1; i++) {
            tempArray.add(nums.get(i));
            if(nums.get(i) >= nums.get(i+1))
            {
                System.out.println(tempArray);
                if(longestArray.size() < tempArray.size())
                {
                    longestArray.clear();
                    longestArray.addAll(tempArray);
                }
                tempArray.clear();
            }

        }
        tempArray.add(nums.get(nums.size()-1));
        if(longestArray.size() < tempArray.size())
        {
            longestArray.clear();
            longestArray.addAll(tempArray);
        }
        System.out.println(tempArray);
        System.out.print("Longest: ");
        System.out.println(longestArray);
    }
}
