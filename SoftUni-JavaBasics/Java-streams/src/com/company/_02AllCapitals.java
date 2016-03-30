package com.company;


import java.io.*;

public class _02AllCapitals {
    public static void main(String[] args) throws IOException {
        BufferedReader reader = new BufferedReader(new FileReader("resources\\lines.txt"));
        String line = reader.readLine();
        StringBuilder output = new StringBuilder();
        while(line != null)
        {
            output.append(line.toUpperCase()+"\n");
            line = reader.readLine();
        }
        FileWriter fw = new FileWriter("resources\\lines.txt",false);
        PrintWriter writer = new PrintWriter(fw,false);
        writer.print(output);
        writer.flush();
        writer.close();
        reader.close();
    }
}
