using System;

namespace SinglyLinkedList
{
    internal class SinglyLinkedList
    {
        internal SNode head;
        internal void InsertFront(int data)
        {
            SNode newNode = new SNode(data);
            newNode.next = head;
            head = newNode;
        }
        internal void InsertEnd(int data)
        {
            SNode newNode = new SNode(data);
            if (head == null)
            {
                head = newNode;
                return;
            }
            SNode lastNode = GetLastNode();
            lastNode.next = newNode;
        }
        internal void InsertAfter(SNode prev_node, int data)
        {
            if(prev_node == null)
            {
                Console.WriteLine("The given previous node cannot be null");
                return;
            }
            SNode newNode = new SNode(data);
            newNode.next = prev_node.next;
            prev_node.next = newNode;
        }

        internal void DeleteNodeByKey(int data)
        {
            SNode temp = head;
            SNode prev = null;
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
            SNode prev = null;
            SNode current = head;
            SNode temp = null;

            while(current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        private SNode GetLastNode()
        {
            SNode temp = head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }
    }
}
