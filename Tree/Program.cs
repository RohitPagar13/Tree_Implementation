using System.Linq.Expressions;

namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tree Structure");

<<<<<<< HEAD
            Console.WriteLine("Enter Root element");
=======
            Console.WriteLine("\nEnter Root element");
>>>>>>> 4_PostOrder

            Tree t = new Tree(Convert.ToInt32(Console.ReadLine()));
            while (true)
            {
<<<<<<< HEAD
                Console.WriteLine("\nWhat you want to do?\n1: Add Element\n2: Inorder of Tree\n0: Exit");
                int choice= Convert.ToInt32(Console.ReadLine());
=======
                Console.WriteLine("\nWhat you want to do?\n1: Add Element\n2: Inorder of Tree \n3: Pre-Order of Tree \n4: Post-order of Tree\n0: Exit");
                int choice = Convert.ToInt32(Console.ReadLine());
>>>>>>> 4_PostOrder
                if (choice == 0)
                {
                    Console.WriteLine("Exiting..");
                    break;
                }
                else
                {
                    switch (choice)
                    {
                        case 1:
<<<<<<< HEAD
                            Console.WriteLine("Enter data to add");
                            int data= Convert.ToInt32(Console.ReadLine());
                            t.addElement(data,t.getRoot());
                            break;
=======
                            Console.WriteLine("\nEnter data to add");
                            int data = Convert.ToInt32(Console.ReadLine());
                            t.addElement(data, t.getRoot());
                            break;

                        case 2:
                            Console.WriteLine("\nInorder of Tree is: ");
                            t.Inorder(t.getRoot());
                            break;

                        case 3:
                            Console.WriteLine("\nPreorder of Tree is: ");
                            t.Preorder(t.getRoot());
                            break;

                       case 4:
                            Console.WriteLine("\nPostorder of Tree is: ");
                            t.Postorder(t.getRoot());
                            break;
>>>>>>> 4_PostOrder
                    }
                }
            }

        }
    }
}