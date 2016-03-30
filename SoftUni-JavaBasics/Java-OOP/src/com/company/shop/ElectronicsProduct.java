package com.company.shop;


import java.time.Period;

public abstract class ElectronicsProduct extends  Product {
    protected Period guaranteePeriod;

    public ElectronicsProduct(String name, double price, int quantity, AgeRestriction ageRestriction) {
        super(name, price, quantity, ageRestriction);
    }
}
