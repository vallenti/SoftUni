package com.company.shop;


import java.util.Date;

public class PurchaseManager {
    static void processPruchase(Product product, Customer customer) throws Exception {
        if (product.getQuantity() <= 0){
            throw new Exception("The product is out of stock");
        }
        if(product instanceof FoodProduct && ((FoodProduct) product).getExpirationDate().compareTo(new Date()) > 0){
            throw new Exception("Product expiration date has passed");
        }
        if(customer.getBalance() < product.getPrice()){
            throw new Exception("Customer has not enough money to buy this product");
        }
        if(customer.getAge().ordinal() < product.getAgeRestriction().ordinal()){
            throw new Exception("Customer is underage to buy this product");
        }
        product.setQuantity(product.getQuantity()-1);
        customer.setBalance(customer.getBalance()-product.getPrice());
        System.out.println("Successful deal.");
    }
}
