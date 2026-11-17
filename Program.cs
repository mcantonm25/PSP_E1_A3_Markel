using System;
using System.Threading.Tasks;

namespace PSP_E1_A3_Markel
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // Bi fitxategiz osatuta egongo da, Kalkulagailua klasea daukana, eta programaren Main metodoa daukana.

            string jarraitu;

            do
            {
                Console.WriteLine("\nKALKULAGAILUA");
                Console.WriteLine("-------------\n");

                // Programak egingo duen lehenengo gauza kalkulagailuaren “modua” galdetzea da: classic edo advanced.

                Console.WriteLine("Aukeratu modua:");
                Console.WriteLine("1. Classic");
                Console.WriteLine("2. Advanced");
                Console.Write("Modua (1/2): ");

                int modua = int.Parse(Console.ReadLine());
                Kalkulagailua k = new Kalkulagailua(modua);

                if (modua == 1)
                {
                    // Classic aukeratzen badugu, bi zenbaki galdetuko ditu eta haien batuketa, kenketa, biderketa eta zatiketa kalkulatuko du
                    k.agurtu();

                    Console.Write("Sartu 1. zenbakia: ");
                    double zbk1 = double.Parse(Console.ReadLine());

                    Console.Write("Sartu 2. zenbakia: ");
                    double zbk2 = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    double batura = k.batuketa(zbk1, zbk2);
                    Console.WriteLine($"Batuketa: {batura}");

                    double kenketaEm = 0;
                    k.kenketa(zbk1, zbk2, ref kenketaEm);
                    Console.WriteLine($"Kenketa: {kenketaEm}");

                    double biderketaEm;
                    k.biderketa(in zbk1, in zbk2, out biderketaEm);
                    Console.WriteLine($"Biderketa: {biderketaEm}");

                    double zatidura = k.zatiketa(zbk1, zbk2);
                    Console.WriteLine($"Zatiketak: {zatidura}");
                }
                else if (modua == 2)
                {
                    // Advanced aukeratzen badugu, bi zenbakien arteko zenbaki guztiak erakutsiko ditu, eta ere zenbaki tarte horretan dauden 2ren, 3ren eta 5en multiplo danak.

                    k.agurtu();

                    Console.Write("Sartu 1. zenbakia: ");
                    double zbk1 = double.Parse(Console.ReadLine());

                    Console.Write("Sartu 2. zenbakia: ");
                    double zbk2 = double.Parse(Console.ReadLine());

                    Console.WriteLine();

                    k.erakutsiZenbakiGuztiak(zbk1, zbk2);
                    k.erakutsi2Multiploak(zbk1, zbk2);
                    k.erakutsi3Multiploak(zbk1, zbk2);
                    k.erakutsi5Multiploak(zbk1, zbk2);
                } else {
                    Console.WriteLine("\n- Zenbaki hori ez dauka modurik esleituta! -");
                }

                Console.WriteLine();
                Console.Write("Beste kalkulu bat egin nahi duzu? (b/e): ");
                jarraitu = Console.ReadLine().ToLower();

            } while (jarraitu == "b");
        }
    }
}