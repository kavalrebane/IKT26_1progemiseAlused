namespace IfElseMethodCall
{
    internal class Program
    {
        //Main on meetod, mis läheb alati esimesena tööle
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //kasutada if ja else.
            //kui kasutaja soovib, siis saab ta meetodi välja kutsuda

            ///kirjutades siia HelloMethod siis see teeb välja kutse 
            ///ja siis see teine Hellomethod läheb ka käima

            Console.WriteLine("Kui soovid meetodit välja kutsuda siis kirjuta ja");
            string method = Console.ReadLine();

            if (method == "ja")
            {
                Hellomethod();
            }
            else
            {
                Console.WriteLine("ei soovinud midagi");
            }
        }

        //teha teine meetod siia ja nimeks on sellel "HelloMethod"
        
        static void Hellomethod()
        {
            Console.WriteLine("Hello kitty");
        }

    }
}
