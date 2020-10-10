package com.aayud.dynamicarray;

import java.util.Iterator;
import java.util.function.Consumer;

public class Array<T> implements Iterable<T> {
    private T[] arr;
    private int length;                     // Length the user thinks
    private int capacity;                   // Actual array size

    public Array() {
        this(16);
    }

    public Array(int capacity) {
        if (capacity < 0) throw new IllegalArgumentException("Illegal capacity: " + capacity);
        this.capacity = capacity;
        arr = (T[]) new Object[capacity];
    }

    public int size() {
        return length;
    }

    public boolean isEmpty() {
        return size() == 0;
    }

    public T get(int index) {
        return arr[index];
    }

    public void set(int index, T elem) {
        arr[index] = elem;
    }

    public void clear() {
        for (int i = 0; i < length; i++) {
            arr[i] = null;
        }
        length = 0;
    }

    public void add(T elem) {
        if (length + 1 >= capacity) {
            if (capacity == 0) capacity = 1;
            capacity *= 2;
            T[] newArray = (T[]) new Object[capacity];
            for (int i = 0; i < length; i++) {
                newArray[i] = arr[i];
            }
            arr = newArray;
        }
        arr[length++] = elem;
    }

    // Removes the element at the specified index in the list.
    public T removeAt(int removeIndex) {
        if (removeIndex >= length || removeIndex < 0) throw new IllegalArgumentException();
        T elem = arr[removeIndex];
        for (int i = removeIndex; i < length - 1; i++) {
            arr[i] = arr[i + 1];
        }
        arr[length--] = null;
        return elem;
    }

    public boolean remove(Object obj){
        for (int i = 0; i < length; i++) {
            if(arr[i].equals(obj)){
                removeAt(i);
                return true;
            }
        }
        return false;
    }

    public int indexOf(Object obj){
        for (int i = 0; i < length; i++) {
            if(arr[i].equals(obj))
                return i;
        }
        return  -1;
    }

    public boolean contains(Object obj){
        return indexOf(obj) != -1;
    }

    @Override
    public String toString() {
        if (length == 0) return "[]";
        else {
            StringBuilder sb = new StringBuilder(length).append("[");
            for (int i = 0; i < length - 1; i++) {
                sb.append(arr[i] + ", ");
            }
            return sb.append(arr[length - 1] + "]").toString();
        }
    }


    public Iterator<T> iterator() {
        return new Iterator<T>() {
            int index = 0;
            public boolean hasNext() {
                return  index < length;
            }

            public T next() {
                return arr[index];
            }

            public void remove() {

            }

            public void forEachRemaining(Consumer<? super T> action) {

            }
        };
    }
}
