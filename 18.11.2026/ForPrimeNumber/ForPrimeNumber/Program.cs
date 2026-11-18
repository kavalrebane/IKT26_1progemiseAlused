namespace ForPrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta algarv");

            //sisestad algarvu

            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = number > 1;

            //for loopiga käib kontroll, kas on algarv

            //if ja else annavad vastuse, kas on algarv või mitte

            for (int i = 0; i < number; i++)
            {
                
            }

            //% operaatorit kasutada


            if (isPrime)
            {
                Console.WriteLine($"{number}On algarv");
            }
            else
            {
                Console.WriteLine($"{number}ei ole algarv");
            }



        }
    }
}
