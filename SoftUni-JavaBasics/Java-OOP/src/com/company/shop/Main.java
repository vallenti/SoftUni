package com.company.shop;


import java.time.Period;
import java.util.Date;

public class Main {
    public static void main(String[] args) {
        FoodProduct cigarettes = new FoodProduct("Shipka",2.60,100,AgeRestriction.Adult,new Date(2015,11,11));
        Customer vasko = new Customer("Vasko",AgeRestriction.Adult,20);
        try {
            PurchaseManager.processPruchase(cigarettes,vasko);
        } catch (Exception e) {
            e.getMessage();
        }


    }
}
