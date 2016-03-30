package com.company;

import java.util.Scanner;

public class ConvertNumberToDecimal {

    public static void main(String[] args) {
        //Problem 6 - Convert from system base 7 to decimal
        Scanner sc = new Scanner(System.in);
        int numSept = Integer.parseInt(sc.nextLine());
        System.out.println(convertNumberToDecimalFromBaseSeven(numSept));
    }

    public static int convertNumberToDecimalFromBaseSeven(int numSep){
        int numDec = 0;
        int len = String.valueOf(numSep).length();
        for (int i =  0; i < len; i++) {
            int lastDigit = numSep % 10;
            numDec += lastDigit * (int)Math.pow(7,i);
            numSep/=10;
        }
        return numDec;
    }


}
