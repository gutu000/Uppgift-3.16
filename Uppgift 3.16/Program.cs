using System;
namespace Uppgift_3._16
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Skriv hur lång din låt är här (minst 2m45sek max 4m20sek");
            int längdM = int.Parse(Console.ReadLine());
            int sek = int.Parse(Console.ReadLine());
            int m = längdM * 60;
            int tot = m + sek;
            

            if (tot <= 165 || tot >= 265)
            {
                Console.WriteLine("Din låt får inte spelas på radion");
            }
            else
            {
                Console.WriteLine("Din låt får spelas på radion");
            }
        }
    }
}