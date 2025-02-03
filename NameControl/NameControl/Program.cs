namespace NameControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //programm küsib nime
            //kui sisestasid nime, siis konsool vastab
            //TERE, sinu nimi
            //peab kasutama if ja else
            //kui nime ei sisestata, siis tuleb vastuseks
            //ERROR ja konsool teeb Beep kolm korda
            Console.WriteLine("Sisesta enda nimi ja vajuta enter");
            string name = Console.ReadLine();

            if (name != "")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Tere " + name);
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("ERROR");
                Console.Beep();
                Console.Beep();
                Console.Beep();
            }
        }
    }
}
