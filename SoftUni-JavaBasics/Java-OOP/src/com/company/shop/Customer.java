package com.company.shop;


public class Customer {
    private String name;
    private AgeRestriction age;
    private double balance;

    public Customer(String name, AgeRestriction age, double balance) {
        this.name = name;
        this.age = age;
        this.balance = balance;
    }

    public String getName() {
        return name;
    }

    public void setName(String name) {
        if(name.length() < 2){
            throw new IllegalArgumentException("Name is too short");
        }
        this.name = name;
    }

    public AgeRestriction getAge() {
        return age;
    }

    public void setAge(AgeRestriction age) {
        this.age = age;
    }

    public double getBalance() {
        return balance;
    }

    public void setBalance(double balance) {
        this.balance = balance;
    }
}
