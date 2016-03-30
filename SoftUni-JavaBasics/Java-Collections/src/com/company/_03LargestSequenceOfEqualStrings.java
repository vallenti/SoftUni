package com.company;


import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;

public class _03LargestSequenceOfEqualStrings {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] stringArray = sc.nextLine().split(" ");
        List<String> tempArray = new ArrayList<>();
        List<String> longestArray = new ArrayList<>();
        for (int i = 0; i < stringArray.length-1; i++) {
            tempArray.add(stringArray[i]);
            if(!stringArray[i].equals(stringArray[i+1])){
                if(tempArray.size() > longestArray.size()){
                    longestArray.clear();
                    longestArray.addAll(tempArray);
                }
                tempArray.clear();
            }

        }
        tempArray.add(stringArray[stringArray.length-1]);
        if(tempArray.size() > longestArray.size()){
            longestArray.clear();
            longestArray.addAll(tempArray);
        }
        System.out.println(longestArray);
    }
}
