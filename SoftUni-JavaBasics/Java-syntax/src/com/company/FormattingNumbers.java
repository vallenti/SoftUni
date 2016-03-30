package com.company;


import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int a = Integer.parseInt(sc.nextLine());
        double b = Double.parseDouble(sc.nextLine());
        double c = Double.parseDouble(sc.nextLine());
        System.out.println("|"+String.format("%-10X",a)+
                            "|"+String.format("%10s",Integer.toBinaryString(a).replace(' ','0'))+
                            "|"+String.format("%10.2f",b)+
                            "|"+String.format("%-10.3f",c)+"|");
    }
}
