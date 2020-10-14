package com.aayud;

import java.util.Iterator;
import java.util.LinkedList;

public class Queue<T> implements Iterable<T> {

    private LinkedList<T> list = new LinkedList<T>();

    public Queue() {
    }

    public Queue(T firstElem) {
        list.addFirst(firstElem);
    }

    public int size() {
        return list.size();
    }

    public boolean isEmpty() {
        return list.size() == 0;
    }

    public void enqueue(T elem) {
        list.addFirst(elem);
    }

    public T dequeue() {
        if (list.isEmpty()) throw new RuntimeException("Queue is empty");
        return list.removeLast();
    }

    @Override
    public Iterator<T> iterator() {
        return list.iterator();
    }
}
