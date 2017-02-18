using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProgrammation.Day22
{
    class Day22
    {
        public Day22()
        {
            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }
            int height = getHeight(root);
            Console.WriteLine(height);
        }

        private int getHeight(Node root)
        {
            //forumula : h(t) = 1+ (max(height(t.left), height(t.right)

            int heightLeft = -1;
            int heightRight = -1;

            if (root.left != null)
              heightLeft =  getHeight(root.left);
            if (root.right != null)
             heightRight =  getHeight(root.right);



            return heightLeft > heightRight ? 1 + heightLeft : 1 + heightRight;
        }

        static Node insert(Node root, int data)
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
