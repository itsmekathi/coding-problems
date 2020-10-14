package com.aayud;

import com.aayud.sll.SinglyLinkedList;
import com.aayud.sll.SinglyLinkedListWithOnePointer;

public class Main {

    public static void main(String[] args) {
        // write your code here
//        RunSLLTest();
        RunSLLV2Test();
    }

    public static void RunSLLV2Test() {
        System.out.println("Singly linked list v2 test");
        SinglyLinkedList<Integer> myNumbers = new SinglyLinkedList<Integer>();
        myNumbers.add(10);
        myNumbers.add(20);
        myNumbers.add(30);
        myNumbers.add(40);
        myNumbers.add(50);
        System.out.println("The list contents are: " + myNumbers.toString());
    }

    public static void RunSLLTest() {
        System.out.println("SLL demo");
        SinglyLinkedListWithOnePointer<Integer> sll = new SinglyLinkedListWithOnePointer<Integer>();
        sll.add(1);
        sll.add(2);
        sll.add(3);
        sll.add(4);
        sll.add(5);
        System.out.println("After adding: " + sll.toString());
        sll.removeAt(0);
        System.out.println("After removing element at 0: " + sll.toString());
    }

    public static void RunDLLTest() {
        System.out.println("Doubly linked list demo");
        DoublyLinkedList<Integer> ddli = new DoublyLinkedList<Integer>();

        ddli.add(1);
        ddli.add(2);
        ddli.add(3);
        ddli.add(4);
        ddli.add(155);
        ddli.add(200);
        ddli.add(250);

        System.out.println(ddli);
        ddli.removeFirst();
        System.out.println("After removing first element: " + ddli);
        ddli.removeLast();
        System.out.println("After removing last element: " + ddli);
        ddli.removeAt(1);
        System.out.println("After removing by index of 1: " + ddli);
    }
}
