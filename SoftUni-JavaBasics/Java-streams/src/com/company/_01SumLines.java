package com.company;


import java.io.BufferedReader;
import java.io.FileReader;
import java.io.IOException;

public class _01SumLines {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader("Wresources\\lines.txt"));
        String line = reader.readLine();
        while (line != null)
        {
            int sum = 0;
            for (int i = 0; i < line.length(); i++) {
                sum += line.charAt(i);
            }
            System.out.println(sum);
            line = reader.readLine();
        }
    }
}
