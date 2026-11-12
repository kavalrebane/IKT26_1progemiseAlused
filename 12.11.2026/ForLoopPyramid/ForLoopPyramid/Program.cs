namespace ForLoopPyramid
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tärnidest püramiid");
            Console.WriteLine("------------------");
            //  \n tähendab uut rida
            Console.Write("\n\n");

            Console.WriteLine("Sisesta suurus: ");
            //for tuleb panna for loopi sisse

            int i, j, k;

            k = Convert.ToInt32(Console.ReadLine());

            for (i = 0; i <= k; i++)
            {
                for (j = 1; j <= k - i; j++)
                {
                    Console.Write(" ");

                    for (j = 1; j <= 2 * i - 1; j++)
                    {
                        Console.Write("*");
                    }

                    Console.Write('\n');
                }
                
            }

        }
    }
}