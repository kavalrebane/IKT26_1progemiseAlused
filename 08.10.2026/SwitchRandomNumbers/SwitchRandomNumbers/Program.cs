namespace SwitchRandomNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Täringu viskamis mäng");

            //Random genereerib iga kord suvalise nr 1-st kuni 6-ni
            int cube = new Random().Next(1, 7);

            //kasuta switchi ja iga juhtum tuleb ära printida, mis number tuli
            switch (cube)
            {
                case 1:
                    Console.WriteLine("Saite nr 1");
                    break;
                case 2:
                    Console.WriteLine("Saite nr 2");
                    break;
                case 3:
                    Console.WriteLine("Saite nr 3");
                    break;
                case 4:
                    Console.WriteLine("Saite nr 4");
                    break;
                case 5:
                    Console.WriteLine("Saite nr 5");
                    break;
                case 6:
                    Console.WriteLine("Saite nr 6");
                    break;
                default:
                    Console.WriteLine("ERROR");
                    break;
            }
        }
    }
}
