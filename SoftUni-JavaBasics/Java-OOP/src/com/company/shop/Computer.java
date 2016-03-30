package com.company.shop;


import java.time.Period;

public class Computer extends ElectronicsProduct {
    private Period guaranteePeriod;
    private double price;
    private int quantity;

    public Computer(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }

    public Period getGuaranteePeriod() {
        return guaranteePeriod;
    }


    private void setGuaranteePeriod(Period guaranteePeriod) {
        this.guaranteePeriod = guaranteePeriod;
    }

    @Override
    public double getPrice() {
        if(this.getQuantity() > 1000) {
            return price*0.95;
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
