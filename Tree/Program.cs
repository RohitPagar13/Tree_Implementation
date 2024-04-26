namespace Tree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Tree Structure");
            Tree t = new Tree();
            while (true)
            {
                Console.WriteLine("\nWhat you want to do?\n1: Add Element\n0: Exit");
                int choice= Convert.ToInt32(Console.ReadLine());
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
                            Console.WriteLine("Enter data to add");
                            int data= Convert.ToInt32(Console.ReadLine());
                            t.addElement(data);
                            break;

                        case 2:

                            break;

                        case 3:

                            break;


                    }
                }
            }
            
        }
    }
}