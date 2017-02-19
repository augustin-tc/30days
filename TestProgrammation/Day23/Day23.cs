using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day23
{
    class Day23
    {
        public Day23()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            levelOrder(root);
        }

        static void levelOrder(Node root)
        {
            string res = "";
            

            Queue<Node> queue = new Queue<Node>();
            queue.Enqueue(root);
            
            while( queue.Count > 0)
            {
                Node current = queue.Dequeue();
                res += current.data + " ";

                if (current.left != null)
                    queue.Enqueue(current.left);
                if (current.right != null)
                    queue.Enqueue(current.right);
            }


         


            Console.WriteLine(res);

        }

        public  Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
    }
}
