using System.Threading.Channels;

namespace YesGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sõna");

            string word = "";

            //while ja nii kaua tsükkel kestab kuni kasutaja sisestab sõna yes

            while (word != "yes")
            {
                Console.WriteLine("kirjuta sõna yes või midagi muud");
                word = Console.ReadLine();
            }
            Console.WriteLine("tubli töö");
        }
    }
}
