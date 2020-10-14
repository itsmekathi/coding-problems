package com.aayud.sll;

public class SinglyLinkedList<T> {
    private class SNode<T> {
        private T element;
        private SNode next;

        public SNode(T element, SNode<T> next) {
            this.element = element;
            this.next = next;
        }

        public T getElement() {
            return element;
        }

        public SNode<T> getNext() {
            return next;
        }

        public void setElement(T element) {
            this.element = element;
        }

        public void setNext(SNode<T> next) {
            this.next = next;
        }

    }

    protected SNode head;                // head node of the list
    protected long size;                // number of nodes in the list

    public SinglyLinkedList() {
        head = null;
        size = 0;
    }

    public long size() {
        return size;
    }

    public boolean isEmpty() {
        return size == 0;
    }

    public void add(T element) {
        addLast(element);
    }

    public void addFirst(T element) {
        SNode<T> newNode = new SNode(element, null);
        newNode.next = head;
        head = newNode;
        ++size;
    }

    public T removeByValue(T value) {
        if (isEmpty()) throw new RuntimeException("List is empty, cannot remove element");
        SNode<T> prev = null, current = head;
        while (current.next != null) {
            prev = current;
            current = current.next;
            if(prev.element == value){
                break;
            }
        }
        
    }

    private SNode<T> getLastNode() {
        SNode<T> current = head;
        while (current.next != null) {
            current = current.next;
        }
        return current;
    }


    public void addLast(T element) {
        if (isEmpty()) {
            addFirst(element);
        } else {
            SNode<T> newNode = new SNode<T>(element, null);
            SNode<T> lastNode = getLastNode();
            lastNode.next = newNode;
        }
        size++;
    }

    @Override
    public String toString() {
        if (isEmpty()) return "[]";
        else {
            StringBuilder sb = new StringBuilder();
            sb.append("[");
            SNode<T> current = head;
            while (current.next != null) {
                sb.append(current.element.toString() + ", ");
                current = current.next;
            }
            sb.append("\b\b]");
            return sb.toString();
        }
    }
}
