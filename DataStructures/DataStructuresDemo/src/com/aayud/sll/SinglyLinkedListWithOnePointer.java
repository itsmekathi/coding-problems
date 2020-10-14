package com.aayud.sll;

public class SinglyLinkedListWithOnePointer<T> {
    private class Node<T> {
        T data;
        Node<T> next;

        public Node(T data, Node<T> next) {
            this.data = data;
            this.next = next;
        }
    }

    private Node<T> head;
//    private int count;

//    public int count() {
//        return count;
//    }

    public boolean isEmpty() {
        return head == null;
    }

    public void add(T data) {
        insertEnd(data);
    }

    public void insertFirst(T data) {
        Node<T> newNode = new Node<T>(data, head);
        head = newNode;
//        ++count;
    }

    private Node<T> getLastNode() {
        Node<T> temp = head;
        while (temp.next != null) {
            temp = temp.next;
        }
        return temp;
    }

    public void insertEnd(T data) {
         Node<T> newNode = new Node<T>(data, null);
        if (isEmpty()) {
            head = newNode;
        } else {
            Node<T> lastNode = getLastNode();
            lastNode.next = newNode;
        }
//        ++count;
    }

    public void deleteFirst() {
        if (isEmpty()) throw new RuntimeException("Array is empty");
        Node temp = head;
        head = head.next;
//        --count;
    }

    public void deleteLast() {
        Node<T> prev = null;
        Node<T> temp = head;
        while (temp.next != null) {
            prev = temp;
            temp = temp.next;
        }
        prev.next = null;
//        --count;
    }

    private void remove(Node node) {
        Node<T> prev = null;
        Node<T> curr = head;
        while (curr.next != null && curr.equals(node)) {
            prev = curr;
            curr = curr.next;
        }
        prev.next = curr.next;
//        count--;
    }

    public void removeAt(int index) {
        if (index < 0) throw new IllegalArgumentException("Array out of bounds");
        Node<T> curr = head;
        int i = 0;
        for (i = 0, curr = head; i < index && curr.next != null; i++) {
            curr = curr.next;
        }
        remove(curr);
    }

    @Override
    public String toString() {
        StringBuilder sb = new StringBuilder();
        sb.append("[ ");
        Node<T> curr = head;
        while (curr.next != null) {
            sb.append(curr.data.toString());
        }
        sb.append("\b\b]");
        return sb.toString();
    }
}
