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
<<<<<<< HEAD
        }
=======
        }

        public void addElement(int data, Node next = null)
        {
            if (root == null)
            {
                root = new Node(data);
                Console.WriteLine("Element added: " + data);
            }
            else
            {
                if (next == null)
                {
                    next = root;
                }

                Node n = next;
                if (n.getData() >= data && n.getLeft() == null)
                {
                    n.setLeft(new Node(data));
                    Console.WriteLine("Element added: " + data);
                }
                else if (n.getData() < data && n.getRight() == null)
                {
                    n.setRight(new Node(data));
                    Console.WriteLine("Element added: " + data);
                }
                else if (n.getData() >= data)
                {
                    addElement(data, n.getLeft());
                }
                else if (n.getData() < data)
                {
                    addElement(data, n.getRight());
                }
            }
        }

        public void Inorder(Node next)
        {
            if (root == null)
            {
                Console.WriteLine("No element inn the list");
            }
            else
            {
                if (next == null)
                {
                    return;
                }
                Inorder(next.getLeft());
                Console.Write(next.getData() + " -- ");
                Inorder(next.getRight());
            }
        }

        public void Preorder(Node next)
        {
            if (root == null)
            {
                Console.WriteLine("No element inn the list");
            }
            else
            {
                if (next == null)
                {
                    return;
                }
                Console.Write(next.getData() + " -- ");
                Preorder(next.getLeft());
                Preorder(next.getRight());
            }
        }

        public void Postorder(Node next)
        {
            if (root == null)
            {
                Console.WriteLine("No element in the list");
            }
            else
            {
                if (next == null)
                {
                    return;
                }

                Postorder(next.getLeft());
                Postorder(next.getRight());
                Console.Write(next.getData() + " -- ");
            }
        }

>>>>>>> 4_PostOrder
    }
}