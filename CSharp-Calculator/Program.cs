using System;
using CSharp_Calculator.Logic;


class Program
{
    
    static void Main(string[] args)
    {
        Dictionary<int, Action> Menu = new Dictionary<int, Action>()
        {
            { 1, ActionOperations.Sum },
            { 2, ActionOperations.Subtract },
            { 3, ActionOperations.Times },
            { 4, ActionOperations.Div },
        };
        bool flag = true;
        while (flag)
        {
            Console.WriteLine("*** Calculator ***");
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Sum");
            Console.WriteLine("2 - Neg");
            Console.WriteLine("3 - times");
            Console.WriteLine("4 - div");
            Console.Write("Your choice: ");
            if (int.TryParse(Console.ReadLine(), out int choice))
            {
                if (choice == 0)
                {
                    ActionOperations.Exit(ref flag);
                }
                
                else if (Menu.ContainsKey(choice))
                {
                    Menu[choice]();
                }
                else
                {
                    Console.WriteLine("*** Error, wrong choise ***");
                    ActionOperations.Exit(ref flag);
                }
            }

        }
    }

}

