namespace SwitchLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meetodi valimine");
            //tee kolm meetodit, mis teevad järgmist:
            //esimene ütleb: auh
            //teine ütleb: tahan magada
            //kolmas ütleb: tahan õppida
            //need tuleb esile kutsuda numbri valikuga
            //tuleb kasutada switchi
            //Tuleb teha menüü, kus kasutaja saab valida, millist meetodit ta tahab esile kutsuda

            Console.WriteLine("Vali meedtod (1-3)");
            Console.WriteLine("1. auh");
            Console.WriteLine("2. tahan magada");
            Console.WriteLine("3. tahan õppida");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice )
            {
                case 1:
                    Auh();
                    
                    break;

                case 2:
                    sleep();
                    break;
                case 3:
                    Study();
                    break;

                default:
                    Console.WriteLine("Vale valik");
                    break;
                    
            }

        }

        static void Auh()
        {
            Console.WriteLine("auh");
        }
        static void sleep()
        {
            Console.WriteLine("Tahana magada");
        }
        static void Study()
        {
            Console.WriteLine("tahan õppida");
        }
    }
}
