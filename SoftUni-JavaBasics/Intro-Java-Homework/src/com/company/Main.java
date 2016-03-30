package com.company;

import static com.company.AssignVariables.AssignVariablesProblem;
import static com.company.AverageClass.getAverageFromThreeNumbers;
import static com.company.AverageClass.getAverageFromThreeNumbers;
import static com.company.GhettoNumeralSystem.ConvertNumber;
import static com.company.PrintCharacters.PrintCharactersProblem;
import static com.company.SumNumbersFrom1ToN.SumNumbers;

public class Main {

    public static void main(String[] args) {
        //--Problem 3 - Assign variables
        //AssignVariablesProblem();

        //--Problem 4 - Print Characters
        //PrintCharactersProblem();

        //--Problem 5 - Print Character Triangle
        //PrintCharactersProblem();

        //--Problem 6 - Sum numbers from 1 to N
        //SumNumbers();

        //--Problem 7 - Ghetto numeral system
        //ConvertNumber();

        //--Problem 8 - Get average
        System.out.printf("%.2f \n",getAverageFromThreeNumbers(1.5, 2.5, 3.8));
        System.out.printf("%.2f \n",getAverageFromThreeNumbers(12, 13, 25));
        System.out.printf("%.2f \n",getAverageFromThreeNumbers(0.005, 0.5, 0.55));
        System.out.printf("%.2f \n",getAverageFromThreeNumbers(0, 0, 2));
    }
}
