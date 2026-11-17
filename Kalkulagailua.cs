using System;
using System.Collections.Generic;
using System.Linq;

namespace PSP_E1_A3_Markel
{
    public class Kalkulagailua
    {
        // Kalkulagailua klaseak, “mode” atributua izango du “classic” edo “advanced” balioak hartuko dituena. Horrez gain, gutxienez, ondorengo metodoak izango ditu:
        public int modua { get; set; }

        public Kalkulagailua(int modua)
        {
            this.modua = modua;
        }

        // agurtu: mode atributuaren arabera, “Classic” edo “Advanced” mezua erakutsiko du pantailatik.
        public void agurtu()
        {
            Console.WriteLine("\n***********");
            if (modua == 1)
            {
                Console.WriteLine("  Classic");
            }
            else if (modua == 2)
            {
                Console.WriteLine("  Advanced");
            }
            Console.WriteLine("***********");
        }

        // batuketa: bi zenbakiak jasoko ditu baliozko parametro bezala eta emaitza bueltatuko du return erabiliz.
        public double batuketa(double a, double b)
        {
            return a + b;
        }

        // kenketa: bi zenbakiak jasoko ditu baliozko parametro bezala eta emaitza erreferentziaz pasatutako beste parametro baten bueltatuko da.
        public void kenketa(double a, double b, ref double emaitza)
        {
            emaitza = a - b;
        }

        // biderketa:bi zenbakiak jasoko ditu in parametro bezala eta emaitza erreferentziaz pasatutako out beste parametro baten bueltatuko da.
        public void biderketa(in double a, in double b, out double emaitza)
        {
            emaitza = a * b;
        }

        // zatiketa: nahi duzun moduan pasa parametroak.
        public double zatiketa(double a, double b)
        {
            return a / b;
        }

        // erakutsiZenbakiGuztiak: sartutako bi zenbakien arteko zenbaki danak erakutsiko ditu pantailatik. Erabili Enumerable.Range metodoa hau lortzeko.
        public void erakutsiZenbakiGuztiak(double a, double b)
        {
            int zbkHasiera = (int)Math.Min(a, b);
            int zbkAmaiera = (int)Math.Max(a, b);

            var zbks = Enumerable.Range(zbkHasiera, zbkAmaiera - zbkHasiera + 1);
            Console.WriteLine("Zenbaki guztiak:");
            Console.WriteLine(string.Join(" ", zbks));
        }

        // erakutsi2Multiploak: sartutako bi zenbakien artean dauden 2ren multiploak erakutsiko ditu pantailtik (erabili LINQ kontsulta).
        public void erakutsi2Multiploak(double a, double b)
        {
            int zbkHasiera = (int)Math.Min(a, b);
            int zbkAmaiera = (int)Math.Max(a, b);

            var multiploak = Enumerable.Range(zbkHasiera, zbkAmaiera - zbkHasiera + 1).Where(i => i % 2 == 0);
            Console.WriteLine("Biaren multiploak:");
            foreach (var i in multiploak)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // erakutsi3Multiploak: sartutako bi zenbakien artean dauden 3ren multiploak erakutsiko ditu pantailtik (erabili LINQ kontsulta).
        public void erakutsi3Multiploak(double a, double b)
        {
            int zbkHasiera = (int)Math.Min(a, b);
            int zbkAmaiera = (int)Math.Max(a, b);

            var multiploak = Enumerable.Range(zbkHasiera, zbkAmaiera - zbkHasiera + 1).Where(i => i % 3 == 0);
            Console.WriteLine("Hiruaren multiploak:");
            foreach (var i in multiploak)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        // erakutsi5Multiploak: sartutako bi zenbakien artean dauden 5en multiploak erakutsiko ditu pantailtik (erabili LINQ kontsulta).
        public void erakutsi5Multiploak(double a, double b)
        {
            int zbkHasiera = (int)Math.Min(a, b);
            int zbkAmaiera = (int)Math.Max(a, b);

            var multiploak = Enumerable.Range(zbkHasiera, zbkAmaiera - zbkHasiera + 1).Where(i => i % 5 == 0);
            Console.WriteLine("Bostaren multiploak:");
            foreach (var i in multiploak)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}