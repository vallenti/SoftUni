package com.company.shop;


import java.time.Period;

public class Appliance extends ElectronicsProduct {
    private Period guaranteePeriod;
    private double price;
    private int quantity;


    public Appliance(String name, double price, int quantity, AgeRestriction ageRestriction, Period guaranteePeriod, double price1, int quantity1) {
        super(name, price, quantity, ageRestriction);
        this.guaranteePeriod = guaranteePeriod;
        price = price1;
        quantity = quantity1;
    }

    public Period getGuaranteePeriod() {
        return guaranteePeriod;
    }

    private void setGuaranteePeriod(Period guaranteePeriod) {
        this.guaranteePeriod = guaranteePeriod;
    }

    @Override
    public double getPrice() {
        if(this.getQuantity() < 50) {
            return price*1.05;
        }
        return price;
    }

    public void setPrice(double price) {
        this.price = price;
    }

    public int getQuantity() {
        return quantity;
    }

    public void setQuantity(int quantity) {
        this.quantity = quantity;
    }
}
