namespace IfAndElseNesting2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Teha üks if ja else nestimine iseseisvalt");
            Console.WriteLine("Teise else if-i sisse panna if ja else nestimine");

            int number = 635;
            if (number == 9)
            {
                if (number == 668)
                {
                    Console.WriteLine("Number 670");
                }
                else
                {
                    Console.WriteLine("Vastus oli 500 kuni 680 ja 700 kuni 800");
                }
            }
            else
            {
                Console.WriteLine("Mingid kahtlased numbrid jälle");
            }
        }
    }
}
