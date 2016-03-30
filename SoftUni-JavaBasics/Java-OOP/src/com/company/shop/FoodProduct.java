package com.company.shop;


import java.util.Date;

public class FoodProduct extends Product implements Expirable {
    private String name;
    private double price;
    private int quantity;
    private AgeRestriction ageRestriction;
    private Date expirationDate;


    public FoodProduct(String name, double price, int quantity, AgeRestriction ageRestriction, Date expirationDate) {
        super(name, price, quantity, ageRestriction);
        this.expirationDate = expirationDate;
    }

    @Override
    public double getPrice() {
        if(this.expirationDate.compareTo(new Date()) > 1){
            return this.price * 0.7;
        }
        return this.price;
    }

    @Override
    public Date getExpirationDate() {
        return this.expirationDate;
    }
}
