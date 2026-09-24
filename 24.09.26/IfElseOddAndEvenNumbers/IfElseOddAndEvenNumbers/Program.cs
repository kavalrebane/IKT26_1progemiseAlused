namespace IfElseOddAndEvenNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //konsool küsib numbrit
            //number tuleb ära parsida

            //if ja else juures toimub kontroll
            //kas on paaris või paaritu number

            Console.WriteLine("Kirjuta number");

            string nr = Console.ReadLine();

            int number = int.Parse(nr);

            //% jagab mutujat number 2-gakuni võrdub 0
            //kui 2 asemel panna 3, siis jagab 3-ga
            if (number %2 == 0)
            {
                Console.WriteLine("see on paarisarv " + number);
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paaris arv

                EvenNumberMethod();
            }
            
            else
            {
                Console.WriteLine("See on paaritu number " + number);
                //siia tuleb välja kutsuda meetod,
                //mis ütleb, et see on paaritu arv

                OddNumberMethod();
            }
        }

        static void EvenNumberMethod()
        {
            Console.WriteLine("See on paarisarv");
        }
        static void OddNumberMethod()
        {
            Console.WriteLine("see on paarituarv");
        }
    }
}
