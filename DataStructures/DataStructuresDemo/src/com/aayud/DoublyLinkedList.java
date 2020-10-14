package com.aayud;

import java.util.Iterator;
import java.util.Spliterator;
import java.util.function.Consumer;

public class DoublyLinkedList<T> implements Iterable<T> {

    private int size = 0;
    private Node<T> head = null;
    private Node<T> tail = null;

    private class Node<T> {
        T data;
        Node<T> next, previous;

        public Node(T data, Node<T> previous, Node<T> next) {
            this.data = data;
            this.next = next;
            this.previous = previous;
        }

        @Override
        public String toString() {
            return data.toString();
        }
    }

    // Empty this Linked list, o(n)
    public void clear() {
        Node<T> trav = head;
        while (trav != null) {
            Node<T> next = trav.next;
            trav.previous = trav.next = null;
            trav.data = null;
            trav = next;
        }
        head = tail = trav = null;
        size = 0;
    }

    public int size() {
        return size;
    }

    public boolean isEmpty() {
        return size() == 0;
    }

    // Add an element to the tail of the linked list. O(1)
    public void add(T elem) {
        addLast(elem);
    }

    public void addFirst(T elem) {
        if (isEmpty()) {
            head = tail = new Node<T>(elem, null, null);
        } else {
            head.previous = new Node<T>(elem, null, head);
            head = head.previous;
        }
        size++;
    }

    public void addLast(T elem) {
        if (isEmpty()) {
            head = tail = new Node<T>(elem, null, null);
        } else {
            tail.next = new Node<T>(elem, tail, null);
            tail = tail.next;
        }
        size++;
    }

    public T peekFirst() {
        if (isEmpty()) throw new RuntimeException("Empty List");
        return head.data;
    }

    public T peekLast() {
        if (isEmpty()) throw new RuntimeException(("Empty List"));
        return tail.data;
    }

    public T removeFirst() {
        if (isEmpty()) throw new RuntimeException("Empty List");
        T data = head.data;

        head = head.next;
        size--;

        // If the list is empty set the tail to null as well
        if (isEmpty()) tail = null;
        else head.previous = null;

        return data;
    }

    public T removeLast() {
        if (isEmpty()) throw new RuntimeException("Empty List");
        T data = tail.data;

        tail = tail.previous;
        size--;

        if (isEmpty()) head = null;
        else tail.next = null;

        return data;
    }

    private T remove(Node<T> node) {

        // If the node to remove is somewhere either at the
        // head or the tail handle those independently
        if (node.previous == null) return removeFirst();
        if (node.next == null) return removeLast();

        // Make the pointers of adjacent nodes skip over 'node'
        node.next.previous = node.previous;
        node.previous.next = node.next;

        // Temporary store the data we want to return
        T data = node.data;

        // Memory cleanup
        node.data = null;
        node = node.previous = node.next = null;
        --size;

        return data;
    }

    // Remove a node at a particular index, o(n)
    public T removeAt(int index) {
        // Make sure the index provided is valid -_-
        if (index < 0 || index >= size) throw new IllegalArgumentException();

        int i;
        Node<T> trav;
        // Search from the front of the list
        if (index < size / 2) {
            for (i = 0, trav = head; i != index; i++) {
                trav = trav.next;
            }
        } else {
            for (i = size - 1, trav = tail; i != index; i--) {
                trav = trav.previous;
            }
        }
        return remove(trav);
    }

    // Remove a particular value in the linked list, o(n)
    public boolean remove(Object obj) {
        Node<T> trav = head;

        // Support searching for null
        if (obj == null) {
            for (trav = head; trav != null; trav = trav.next) {
                if (trav.data == null) {
                    remove(trav);
                    return true;
                }
            }
        } else {
            for (trav = head; trav != null; trav = trav.next) {
                if (trav.data.equals(obj)) {
                    remove(trav);
                    return true;
                }
            }
        }
        return false;
    }

    // Find the index of a particular value in the linked list, O(n)
    public int indexOf(Object obj) {
        int index = 0;
        Node<T> trav = head;

        if (obj == null) {
            for (trav = head, index = 0; trav != null; trav = trav.next, index++) {
                if (trav.data == null) return index;
            }
        } else {
            for (trav = head, index = 0; trav != null; trav = trav.next, index++) {
                if (trav.data.equals(obj)) return index;
            }
        }
        return -1;
    }

    // check if a value is contained within the Linked list
    public boolean conatins(Object obj) {
        return indexOf(obj) != -1;
    }

    @Override
    public Iterator<T> iterator() {
        return new Iterator<T>() {
            private Node<T> trav = head;

            @Override
            public boolean hasNext() {
                return trav != null;
            }

            @Override
            public T next() {
                T data = trav.data;
                trav = trav.next;
                return data;
            }
        };
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("[");
        Node<T> trav = head;
        while (trav != null) {
            sb.append(trav.data.toString() + ", ");
            trav = trav.next;
        }
        sb.append("\b\b]");
        return sb.toString();
    }

    @Override
    public void forEach(Consumer<? super T> action) {

    }

    @Override
    public Spliterator<T> spliterator() {
        return null;
    }
}
