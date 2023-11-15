using System;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }
        public Node Last { get; set; }
        public int count { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        // methods
        public void Add(int val)
        {
            // TODO: add item to the end of the list
            // consider when the list is empty

            // create a new node with the given data
             if (First == null)
            {
                Node t = new Node(val);
                t.Data = val;
                First = t;
                Last = t;
                count++;
                return;
                
            }
            Node move = First;
            while (move.Next != null)
                move = move.Next;
                Last = move;
            
            Node temp = new Node(val);
            temp.Data = val;
            Last.Next = temp;
            Last = temp;
            count++;
        }
        public void RemoveKey(int key)
        {
            // TODO: search for the key and remove it from the list
            // consider when the key does not exist and when the list is empty
             if (First == null)
                return;
            if (First.Data==key)
            {
                Node temp = First;
                First = First.Next;
                temp.Next = null;
                count--;
                return;
            }
            Node move = First;
            while (move.Next != null && move.Next.Data!= key)
                move = move.Next;
            Node t= move.Next;
            if (move.Next!=null)
            {
                move.Next = move.Next.Next;
                t.Next = null;
            }
            count--;
           
        }
        public void Merge(LinkedList other_list)
        {
            // TODO: merge this list with the other list
              Node move = this.First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = other_list.First;
        }
        public void Reverse()
        {
            // TODO: revers the nodes of this list
            // initialize three pointers: prev, curr, and next
              if (First == null || First.Next==null)
                return;
            Node prev = null, curr = First, next = null;
            while (curr != null)
            {
                next = curr.Next;
                curr.Next = prev;
                prev = curr;
                curr = next;
            }
            First = prev;
        }
    }
}
