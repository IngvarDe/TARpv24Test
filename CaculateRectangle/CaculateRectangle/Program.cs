namespace CaculateRectangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculate rectangle");

            Console.WriteLine("Enter first value");
            string firstNumber = Console.ReadLine();
            float floatFirst = float.Parse(firstNumber);


            Console.WriteLine("Enter second value");
            string secondNumber = Console.ReadLine();
            float floatSecond = float.Parse(secondNumber);

            //teha pindala ja ümbermõõdu kalkulatsioon
            Console.WriteLine("P: " + 2 * (floatFirst * floatSecond));
            Console.WriteLine("S: " + (floatFirst * floatSecond));
        }
    }
}
