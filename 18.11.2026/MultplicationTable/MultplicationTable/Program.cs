namespace MultiplicationTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Korrutstabel");

            Console.WriteLine("Sisesta tabelisse number, mis on viimane korrutis");

            //kaks for loopi ja üks on teise sees.
            int j, i, n;

            n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"korrutustabel ühest kuni {0}", n);
            Console.WriteLine("\n");



            for (i = 1; i <= 10; i++)
            {
                for (j = 1; j <= n; j++)
                {
                    if (j <= n - i)
                    {
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    }
                    else
                    {
                        Console.Write("{0}x{1} = {2}, ", j, i, i * j);
                    }
                }
                Console.Write("\n");
            }
            
            

            
        }
    }
}
