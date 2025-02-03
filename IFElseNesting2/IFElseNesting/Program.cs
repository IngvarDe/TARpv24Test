namespace IFElseNesting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int number = int.Parse(Console.ReadLine());

            if (number == 12)
            {
                Console.WriteLine("Number on " + number);
            }
            else if (number >= 13 && number <= 25)
            {
                //nestimine
                if (number == 17)
                {
                    Console.WriteLine("Number on 17");
                }
                else
                {
                    Console.WriteLine("Number on 13 kuni 16 ja 18 kuni 25");
                }
            }
            else
            {
                Console.WriteLine("Imelik number");
            }
        }
    }
}
