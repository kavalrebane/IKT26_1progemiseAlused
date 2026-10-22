namespace WhileDoTriangel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //1.otsida Internetist Whilw koodiga kolmnurga
            //kujundeid ehk tegemise viise
            //2.kui kood on leitud, siis kirjutada see siia
            //3. tee vooskem
            Console.WriteLine("Kolmnurk");

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while (n <= 5)
            {
                int number = 1;

                while (number <= n)
                {
                    Console.Write(number);
                    number++;
                }

                Console.WriteLine();
                n++;
            }


        }
    }
}
