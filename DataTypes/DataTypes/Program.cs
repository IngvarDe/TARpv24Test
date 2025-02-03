namespace DataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data types!");

            //täisarv
            int bigNumber = 2147483647;
            Console.WriteLine(bigNumber);

            long longNumber = long.MinValue;
            Console.WriteLine(longNumber);

            //12.5
            float floatVarible = 12.5F;
            Console.WriteLine(floatVarible);

            //veel komaga arv
            double comaNumber = double.MaxValue;
            Console.WriteLine(comaNumber);

            //tähemärk
            string stringVar = "asd234345475   @$^&*()&$$#";
            Console.WriteLine(stringVar);

            //true and false
            bool boolVarible = false;
            Console.WriteLine(boolVarible);

        }
    }
}
