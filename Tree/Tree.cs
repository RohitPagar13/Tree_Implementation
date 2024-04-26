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
        List<Node> tree;
        Node node;
        int c; 
        

        public Tree()
        {
            tree = new List<Node>();
            c = 0;
        }

        public void addElement(int data)
        {
            if(tree.Count == 0)
            {
                tree.Add(new Node(data));
                Console.WriteLine("Element added: " + data);
            }
            else
            {
                Node n = tree[c];
                if (n.getData() > data && n.getLeft() == null)
                {
                    tree.Add(new Node(data));
                    Console.WriteLine("Element added: " + data);
                }
                else if (n.getData() < data && n.getRight() == null)
                {
                    tree.Add(null);
                    tree.Add(new Node(data));
                    Console.WriteLine("Element added: "+ data);
                }
                else
                {
                    c++;
                    addElement(data);
                }
            }
        }

        
    }
}
