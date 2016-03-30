package com.company;


import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _11MostFrequentWord {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] text = sc.nextLine().split("[^a-zA-Z]+");
        Map<String, Integer> wordsCount = new LinkedHashMap<>();
        int mostFrequentCount = 0;
        for(String word : text)
        {
            if(!wordsCount.containsKey(word.toLowerCase()))
            {
                wordsCount.put(word.toLowerCase(),0);
            }
            wordsCount.put(word.toLowerCase(),wordsCount.get(word.toLowerCase())+1);
            if(wordsCount.get(word.toLowerCase()) > mostFrequentCount)
            {
                mostFrequentCount = wordsCount.get(word.toLowerCase());
            }
        }

        for (Map.Entry<String, Integer> entry : wordsCount.entrySet())
        {
            if(entry.getValue() == mostFrequentCount)
            {
                System.out.println(entry.getKey()+" -> "+entry.getValue());
            }
        }

    }
}
