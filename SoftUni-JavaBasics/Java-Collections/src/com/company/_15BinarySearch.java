package com.company;


import com.sun.deploy.util.ArrayUtil;

import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class _15BinarySearch {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int searchElement = Integer.parseInt(sc.nextLine());
        int[] numbers = Arrays.stream(sc.nextLine().split(" ")).mapToInt(i -> Integer.parseInt(i)).toArray();
        System.out.println(binarySearch(numbers,searchElement));
    }
    public static int binarySearch(int[] a, int x) {
        return binarySearch(a, x, 0, a.length - 1);
    }

    private static int binarySearch(int[ ] a, int x,
                             int low, int high) {
        if (low > high) return -1;
        int mid = (low + high)/2;
        if (a[mid] == x) return mid;
        else if (a[mid] < x)
            return binarySearch(a, x, mid+1, high);
        else
            return binarySearch(a, x, low, mid-1);
    }
}
