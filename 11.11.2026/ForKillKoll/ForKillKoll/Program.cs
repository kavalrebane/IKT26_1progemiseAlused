namespace ForKillKoll
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Eelnevaid teadmisi kasutades kirjutada programm, mis väljastaks:
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //kill - koll
            //kill - koll
            //killadi - koll
            //for loop sees peab olema loop
            //peab saama sisestada arvu, mitu korda soovib väljundit korrata
            //iga kord, kui hakkab väljundit kordama, siis näitab re numbrit
            Console.WriteLine("Sisesta arv, kui mitu korda korratakse kill - koll");

            int KillKoll = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= KillKoll; i++)
            {
                Console.WriteLine("See on rida nr {0}", i);
                for (int j = 0; j < 2; j++)
                {
                    Console.WriteLine("kill - koll ");
                }

                for (int k = 0; k < 1; k++)
                {
                    Console.WriteLine("killadi - koll ");
                }
            }
        }
    }
}
