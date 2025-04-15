using System;
using CSharp_Calculator.Logic;


class Program
{
    static void Main(string[] args)
    {
        Dictionary<int, Action> Menu = new Dictionary<int, Action>()
        {
            { 0, ActionOperations.Exit },
            { 1, ActionOperations.Sum },
            { 2, ActionOperations.Subtract },
            { 3, ActionOperations.Times },
            { 4, ActionOperations.Div }
        };
        
      /* In for the time being
        Dictionary<int, Func<float, float, float>> operations = new Dictionary<int, Func<float, float, float>>()
        {
            { 1, FuncOperations.Sum2 }
        };
        Console.WriteLine("Testing");
        Console.WriteLine(operations[1](3.4f, 5.2f));
        */

        
    Console.WriteLine("*** Calculator ***");
        Console.WriteLine("0 - Exit");
        Console.WriteLine("1 - Sum");
        Console.WriteLine("2 - Neg");
        Console.WriteLine("3 - times");
        Console.WriteLine("4 - div");
        Console.Write("Your choice: ");
        if (int.TryParse(Console.ReadLine(), out int choice))
        {
            if (Menu.ContainsKey(choice))
            {
                Menu[choice]();
            }
            else
            {
                Console.WriteLine("*** Error, wrong choise ***");
            }
        }
        else
        {
            Console.WriteLine("*** Error, wrong choice ***");
        }

            ;        





    }
    
}

