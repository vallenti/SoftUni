package com.company;

import java.util.Scanner;

public class ConvertNumberToBaseSeven {
    public static void main(String[] args) {
        //Problem 5 - Convert from decimal to system base 7
        Scanner sc = new Scanner(System.in);
        int numDec = Integer.parseInt(sc.nextLine());
        System.out.println(convertNumberToBaseSeven(numDec));


    }
    public static int convertNumberToBaseSeven(int numDec){
        if(numDec < 7)
        {
            return numDec;
        }
        StringBuilder sb = new StringBuilder();
        do
        {
            sb.append(numDec%7);
            numDec/=7;
        }while(numDec/7 != 0);
        sb.append(numDec % 7);
        int numSeptenary = Integer.parseInt(sb.reverse().toString());
        return numSeptenary;
    }


}
