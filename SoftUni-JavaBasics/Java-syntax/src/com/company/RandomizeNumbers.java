package com.company;


import java.util.Random;
import java.util.Scanner;

public class RandomizeNumbers {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int startNumber = sc.nextInt();
        int endNumber = sc.nextInt();
        if(startNumber>endNumber)
        {
            int temp = startNumber;
            startNumber = endNumber;
            endNumber = temp;
        }
        int arraySize = Math.abs(startNumber-endNumber)+1;
        int[] array = new int[arraySize];
        for (int i = 0; i < array.length; i++) {
            array[i] = startNumber++;

        }
        Random randGen = new Random();
        for(int i = 0; i<array.length;i++)
        {
            int firstIndex = randGen.nextInt(array.length);
            int secondIndex = randGen.nextInt(array.length);

            int temp = array[firstIndex];
            array[firstIndex] = array[secondIndex];
            array[secondIndex] = temp;
        }
        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i]+" ");
        }
    }
}
