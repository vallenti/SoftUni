package com.company;


import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.Map;
import java.util.Scanner;

public class _12CardFrequences {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        String[] input = sc.nextLine().split(" ");
        Map<String, Integer> cards = new LinkedHashMap<>();
        for(String card : input){
            String currentCard = card.substring(0,card.length()-1);
            if(!cards.containsKey(currentCard)){
                cards.put(currentCard,0);
            }
            cards.put(currentCard,cards.get(currentCard)+1);
        }
        for(Map.Entry<String,Integer> entry : cards.entrySet()){
            System.out.printf("%s -> %.2f%% \n",entry.getKey(),((entry.getValue()*1.0 / input.length) * 100));
        }
    }
}

