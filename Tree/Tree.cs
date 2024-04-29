using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tree
{
    internal class Tree
    {
        Node root;

        public Node getRoot()
        {
            return root;
        }

        public Tree(int data)
        {
            Console.WriteLine("Enter Root element");
            root = new Node(data);
        }
    }
}
