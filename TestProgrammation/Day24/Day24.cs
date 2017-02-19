using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day24
{
    class Day24
    {
        public Day24()
        {
            Node head = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                head = insert(head, data);
            }
            head = removeDuplicates(head);
            display(head);
        }

        public static Node removeDuplicates(Node head)
        {
            var result = head;
            if (head != null)
            {
               
                while (head.next != null)
                {
                    if (head.next.data == head.data)
                    {
                        if (head.next.next != null)
                        {
                            head.next = head.next.next;
                           
                        }

                        else
                            head.next = null;
                    }
                    else head = head.next;
                }
               
            }
                
 return result;
        }

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }
        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
