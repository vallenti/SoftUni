package com.company;


import java.util.Scanner;

public class GetFirstElements {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        String[] stringArray = sc.nextLine().split("\\s");
        String[] commandArgs = sc.nextLine().split("\\s");
        int count = Integer.parseInt(commandArgs[1]);
        int remainder = commandArgs[2].equals("even") ? 0 : 1;
        for (int i = 0; i < stringArray.length; i++) {
            int currentElement = Integer.parseInt(stringArray[i]);
            if(currentElement % 2 == remainder) {
                System.out.print(currentElement+" ");
                count--;
                if(count <= 0) {
                    break;
                }
            }
        }
    }
}
