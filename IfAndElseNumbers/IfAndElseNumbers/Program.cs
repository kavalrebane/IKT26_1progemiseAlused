namespace IfAndElseNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("2026");

            //konsoolis sisestame numbri
            //see number salvestatakse string andmetüüpi
            //toimub kontroll, kas sisestatud väärtus on number
            //kasutada if ja else lauseid

            string number = Console.ReadLine();

            if (number == "")
            {
                
            }

            Console.WriteLine("sisestasid numbri");
            Console.WriteLine(number);

            Console.BackgroundColor = ConsoleColor.Magenta;
            
        }
    }
}
