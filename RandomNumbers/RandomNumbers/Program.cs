namespace RandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //genereerib iga kord suvalised nr 1-st kuni 6-ni
            //kasutate switchi

            int cube = new Random().Next(1,6);

            switch (cube)
            {
                case 1:
                    Console.WriteLine("Said 1 ja oled luuser");
                    break;

                case 2:
                    Console.WriteLine("Said 2 ja oled pool luuser");
                    break;

                case 3:
                    Console.WriteLine("Said 3 ja see käib küll");
                    break;

                case 4:
                    Console.WriteLine("Said 4 ja juba läheb");
                    break;

                case 5:
                    Console.WriteLine("Said 5 ja nagu tubli õpilane");
                    break;

                case 6:
                    Console.WriteLine("Said 6 ja max puktid");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
