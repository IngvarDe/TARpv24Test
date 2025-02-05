namespace CoinCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Raha ümber maa!");

            //vaja arvutada, mitu kahe eurost münti läheb ümber maa
            //maa ümbermõõt tuleb välja arvutada raadiuse abil

            double coinDiameter = 25.75; //mm
            double earthRadius = 6378000000;
            double aroundEarth = 2 * Math.PI * earthRadius;

            Console.WriteLine("Maa ümbermõõt: " + aroundEarth);

            //nüüd arvutame müntide arvu
            double result = aroundEarth / coinDiameter;

            Console.WriteLine("Ümber maa mahub nii " +
                "palju kahe euroseid " + result);
        }
    }
}
