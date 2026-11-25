using System.Numerics;

namespace DecimalToBinary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decimal to binary");

            Console.WriteLine("Sisesta number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            //otsida internetist koodiliik ülesse
            //peab olema while-ga tehtud
            string BinaryNumber = "";

            while (num > 0)
            {
                int reminder = num % 2;
                BinaryNumber = reminder + BinaryNumber;
                num /= 2;
            }
            Console.WriteLine("Binnar: " + BinaryNumber);
        }
    }
}
