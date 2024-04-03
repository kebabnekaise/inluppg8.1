using System;

namespace inluppg8._1
{
    class Program
    {
        static void Main(string[] args)
        {
            bil bil1 = new bil();

            bil1.marke = "Toyota";
            bil1.alder = 2000;
            bil1.modell = "Yaris";
            bil1.topphastighet = 200;
            bil1.regnummer = "ABC123";

            Console.WriteLine("Modell: " + bil1.marke);
            Console.WriteLine("Alder: " + bil1.alder);
            Console.WriteLine("Modell: " + bil1.modell);
            Console.WriteLine("Topphastighet: " + bil1.topphastighet);
            Console.WriteLine("Regnummer: " + bil1.regnummer);
        }
    }
}