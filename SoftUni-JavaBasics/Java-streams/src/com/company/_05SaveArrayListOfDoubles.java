package com.company;

import java.io.*;
import java.util.ArrayList;
import java.util.List;


public class _05SaveArrayListOfDoubles {
    public static void main(String[] args) throws IOException, ClassNotFoundException {
        List<Double> doubleList = new ArrayList<Double>();
        doubleList.add(1.0);
        doubleList.add(1.23235444);
        doubleList.add(3.1415293231);
        doubleList.add(2.71282312354557);
        doubleList.add(2131231.6565623342);

        ObjectOutputStream oos = new ObjectOutputStream(
                new BufferedOutputStream(
                        new FileOutputStream(
                                "resources\\doubles.list"
                        )
                ));
        oos.writeObject(doubleList);
        oos.flush();
        ObjectInputStream ois = new ObjectInputStream(
                new BufferedInputStream(
                        new FileInputStream(
                                "resources\\doubles.list"
                        )
                ));
        System.out.println(ois.readObject());
        ois.close();

    }
}
