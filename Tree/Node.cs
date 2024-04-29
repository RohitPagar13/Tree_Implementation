using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Node
    {
        Node left;
        int data;
        Node right;

        public Node(int data)
        {
            left = null;
            right = null;
            this.data = data;
        }

        public Node getLeft()
        {
            return left;
        }

        public Node getRight()
        {
            return right;
        }

        public int getData()
        {
            return data;
        }

        public void setLeft(Node left)
        {
            this.left = left;
        }
        public void setRight(Node right)
        {
            this.right = right;
        }
    }
}