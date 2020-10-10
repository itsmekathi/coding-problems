package com.aayud.dynamicarray;

/**
 * Hello world!
 */
public class App {
    public static void main(String[] args) {

        System.out.println("Hello World!");
        Array<Integer> mynumbers = new Array<Integer>(10);

        mynumbers.add(10);
        mynumbers.add(11);
        mynumbers.add(12);
        mynumbers.add(13);
        mynumbers.add(14);
        mynumbers.add(15);
        System.out.println(mynumbers.toString());

        mynumbers.removeAt(0);
        System.out.println(mynumbers);
        mynumbers.removeAt(mynumbers.size() -1 );
        System.out.println(mynumbers);
        mynumbers.add(100);

        System.out.println("Index of 11 is: " + mynumbers.indexOf(11));
        System.out.println("Exists check for 200: " + mynumbers.contains(200));

        System.out.println(mynumbers);


    }

    public String concatAndConvertString(String str1, String str2){
        String result = str1.concat(str2);
        return result.toUpperCase();
    }
}
