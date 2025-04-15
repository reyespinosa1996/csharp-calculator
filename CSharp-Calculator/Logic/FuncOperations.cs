namespace CSharp_Calculator.Logic;


/* In for the time being
  Dictionary<int, Func<float, float, float>> operations = new Dictionary<int, Func<float, float, float>>()
  {
      { 1, FuncOperations.Sum2 }
  };
  Console.WriteLine("Testing");
  Console.WriteLine(operations[1](3.4f, 5.2f));
  */

public class FuncOperations
{
    public static float Sum2(float a, float b)
    {
        return a + b;
    }
}