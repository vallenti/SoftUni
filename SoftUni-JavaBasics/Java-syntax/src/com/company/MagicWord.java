package com.company;


import java.util.HashMap;
import java.util.LinkedHashMap;
import java.util.Scanner;

public class MagicWord {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String[] words = sc.nextLine().split("\\s");
        String firstWord = words[0];
        String secondWord = words[1];
        HashMap<Character, Character> dict = new LinkedHashMap<>();
        boolean isMagicWord = true;
        for (int i = 0; i < firstWord.length(); i++) {
            char currentChar = firstWord.charAt(i);
            if(!dict.containsKey(currentChar)){
                dict.put(currentChar,secondWord.charAt(i));
            }
            else if(!(dict.containsKey(currentChar) && dict.get(currentChar) == secondWord.charAt(i))) {
                isMagicWord = false;
            }
        }
        System.out.println(isMagicWord);
    }
}
