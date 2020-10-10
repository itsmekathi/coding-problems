package com.aayud;

public class Main {
    public static void main(String[] args){
        System.out.println("Dynamic Array demo");
        Array<Integer> myNumbersArray = new Array<Integer>(2);

        myNumbersArray.add(10);
        myNumbersArray.add(11);
        myNumbersArray.add(12);
        myNumbersArray.add(13);
        myNumbersArray.add(14);
        myNumbersArray.add(1);
        myNumbersArray.add(2);
        myNumbersArray.add(130);
        myNumbersArray.add(234);
        myNumbersArray.add(3546);
        myNumbersArray.add(2345);

        System.out.println(myNumbersArray.toString());

        myNumbersArray.removeAt(0);
        myNumbersArray.remove(130);
        System.out.println("Index of 2345 is: " + myNumbersArray.indexOf(2345) );

        System.out.println(myNumbersArray.toString());


    }
}
