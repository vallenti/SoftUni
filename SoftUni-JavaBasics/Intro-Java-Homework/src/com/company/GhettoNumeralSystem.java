package com.company;


import java.util.Scanner;

public class GhettoNumeralSystem {
    public static void ConvertNumber()
    {
        Scanner sc = new Scanner(System.in);
        String number = sc.nextLine();
        StringBuilder ghettoNumber = new StringBuilder();
        for (int i = 0; i < number.length(); i++) {
            switch(number.charAt(i))
            {
                case '0': ghettoNumber.append("Gee");break;
                case '1': ghettoNumber.append("Bro");break;
                case '2': ghettoNumber.append("Zuz");break;
                case '3': ghettoNumber.append("Ma");break;
                case '4': ghettoNumber.append("Duh");break;
                case '5': ghettoNumber.append("Yo");break;
                case '6': ghettoNumber.append("Dis");break;
                case '7': ghettoNumber.append("Hood");break;
                case '8': ghettoNumber.append("Jam");break;
                case '9': ghettoNumber.append("Mack");break;
            }
        }
        System.out.println(ghettoNumber);
    }
}
