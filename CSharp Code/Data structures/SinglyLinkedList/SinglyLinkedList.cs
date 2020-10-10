using System;

namespace SinglyLinkedList
{
    internal class SinglyLinkedList
    {
        internal Node head;
        internal void InsertFront(int data)
        {
            Node newNode = new Node(data);
            newNode.next = head;
            head = newNode;
        }
        internal void InsertEnd(int data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = newNode;
        }
        internal void InsertAfter(Node prev_node, int data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            Node newNode = new Node(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
        }

        internal void DeleteNodeByKey(int data)
        {
            Node temp = head;
            Node prev = null;
            if(temp != null && temp.data == data)
            {
                head = temp.next;
                return;
            }
            while(temp != null && temp.data != data)
            {
                prev = temp;
                temp = temp.next;
            }
            if(temp == null)
            {
                return;
            }
            prev.next = temp.next;
        }

        public void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;

            while(current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        private Node GetLastNode()
        {
            Node temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
