using System.Xml.Linq;

namespace SwitchCoinDivider
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //
            //Eurosendid on väärtuses 1, 2, 5, 10, 20 ja 50.Koostage funktsioon,
            //millele antakse argumendina rahasumma(sentides) ja mis trükib välja, kui palju milliseid
            //münte peaks selles vääringus andma, et müntide arv oleks väikseim.Näiteks 37 sendi puhul
            //1 20 - sendine, 1 10 - sendine, 1 5 - sendine ja 1 2 - sendine.Koostage järjend, mille elementideks
            //on teisendatavad rahasummad.Koostage programm, mis võtab järjendist elemente ja kutsub
            //igaühe korral neist välja ülaltoodud funktsiooni.Probleeme tekitab kindlasti korrektse
            //lause koostamine(mida teha, kui mingis vääringus münte ei vajata? mida teha ainsuse ja mitmusega?).
            //Püüdke leida parim võimalik lahendus.
            // NB! kasutage switchi või if ja else

            const int one = 1, two = 2, five = 5, ten = 10, twenty = 20, fifty = 50;

            Console.WriteLine("Enter sum and press enter: ");
            int sum = int.Parse(Console.ReadLine());

            int centAmmount = 0;

            if (sum >= fifty)
            {
                centAmmount = sum / fifty;
                Console.WriteLine("50 sendised: " + centAmmount);
            }

            if (sum >= twenty)
            {
                sum = sum - centAmmount * fifty;
                centAmmount = sum / twenty;
                Console.WriteLine("20 sendised: " + centAmmount);
            }

            if (sum >= ten)
            {
                sum = sum - centAmmount * twenty;
                centAmmount = sum / ten;
                Console.WriteLine("10 sendised: " + centAmmount);
            }

            if (sum >= five)
            {
                sum = sum - centAmmount * ten;
                centAmmount = sum / five;
                Console.WriteLine("5 sendised: " + centAmmount);
            }

            if (sum >= two)
            {
                sum = sum - centAmmount * five;
                centAmmount = sum / two;
                Console.WriteLine("2 sendised: " + centAmmount);
            }

            if (sum >= one)
            {
                sum = sum - centAmmount * two;
                centAmmount = sum / one;
                Console.WriteLine("1 sendised: " + centAmmount);
            }

            else
            {
                Console.WriteLine("Rohkem ei ole");
            }
        }
    }
}
