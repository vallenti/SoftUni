package com.company;


import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.FileOutputStream;
import java.io.IOException;

public class _04CopyJPGFile  {

    public static void main(String[]args) throws IOException {
        String file="resources\\picture.jpg";
        String copiedFile="resources\\my-copied-picture.jpg";
        FileInputStream fis=new FileInputStream(file);
        FileOutputStream fos=new FileOutputStream(copiedFile);
        int byteContainer;
        while((byteContainer = fis.read())!=-1)
        {
            fos.write(byteContainer);
        }
        fis.close();
        fos.close();
    }

}
