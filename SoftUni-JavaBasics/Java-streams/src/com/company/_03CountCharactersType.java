package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;

public class _03CountCharactersType {

    public static void main(String[] args) throws IOException {
        List<Character> vowels = Arrays.asList('a', 'e','i','o','u');
        List<Character> punctuationMarks = Arrays.asList('!',',','.','?');
        int vowelsCount = 0;
        int punctuationMarksCount = 0;
        int consonantsCount = 0;
        BufferedReader reader = new BufferedReader(new FileReader("resources\\words.txt"));
        String line = reader.readLine();
        while(line != null)
        {
            for (int i = 0; i < line.length(); i++) {
                if(vowels.contains(line.charAt(i))){
                    vowelsCount++;
                }
                else if(punctuationMarks.contains(line.charAt(i))){
                    punctuationMarksCount++;
                }
                else if(line.charAt(i) != ' ')
                {
                    consonantsCount++;
                }
            }
            line = reader.readLine();
        }
        FileWriter fw = new FileWriter("resources\\count-chars.txt",true);
        PrintWriter writer = new PrintWriter(fw,true);
        writer.println("Vowels: "+vowelsCount);
        writer.println("Consonants: "+consonantsCount);
        writer.println("Punctuation: "+punctuationMarksCount);
    }
}
