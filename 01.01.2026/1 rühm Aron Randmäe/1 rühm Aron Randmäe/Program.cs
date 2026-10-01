using System.Numerics;

namespace _1_rühm_Aron_Randmäe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Teha if ja else konsolirakendus
            //Teha neli if-i ja else-i kontrolli,
            //kus kontrollitakse majade ruutmeetreid.
            //Esimene kontroll on 0-40 ruutmeetri juures.
            //Teine kontroll 41-90 ruutmeetrit,
            //kolmas kontroll on 91-130 ja 
            //neljas on suuremad, kui 131 ruutmeetrit.
            //Kui mingi suurus on tuvastatud, siis konsool näitab
            //teksti: Sinu maja on (sisestatud suurus).

            Console.WriteLine("Sisestage maja ruutmeetrid");

            string number = Console.ReadLine();
            int house = int.Parse(number);

            Console.WriteLine("Sinu majal on " + house + " ruutmeetrit");

            if (house >= 0 && house <= 40)
            {
                Console.WriteLine("sinu majal on 0 kuni 40 ruutmeetrit");
            }
            else if (house >= 41 && house <= 90)
            {
                Console.WriteLine("sinu majal on 41 kuni 90 ruutmeetrit");
            }
            else if (house >= 91 && house <= 130)
            {
                Console.WriteLine("sinu majal on 91 kuni 130 ruutmeetrit");
            }
            else if (house >= 131)
            {
                Console.WriteLine("sinu majal on rohkem kui 131 ruutmeetrit");
            }
            else
            {
                Console.WriteLine("Siin ei räägita maja infost");
            }
        }
    }
}
