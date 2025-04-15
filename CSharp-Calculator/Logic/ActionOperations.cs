namespace CSharp_Calculator.Logic;

public static class ActionOperations
{
    public static void Exit()
    {
        Console.WriteLine("Exiting program");
        Environment.Exit(0);
    }

    public static void Sum()
    {
        Console.WriteLine("first number");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("second number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"sol:  {a+b}");
    }
    
    public static void Subtract()
    {
        Console.WriteLine("first number");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("second number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"sol:  {a-b}");
    }
    
    public static void Times()
    {
        Console.WriteLine("first number");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("second number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"sol:  {a*b}");
    }
    
    public static void Div()
    {        
        Console.WriteLine("first number");
        int a = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("second number");
        int b = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine($"sol:  {a/b}");
    }

    

    
}