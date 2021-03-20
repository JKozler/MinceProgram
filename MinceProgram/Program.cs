using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinceProgram
{
    public class Program
    {
        public static int padesat = 0;
        public static int dvacet = 0;
        public static int deset = 0;
        public static int petc = 0;
        public static int dvac = 0;
        public static int jedna = 0;
        static void Main(string[] args)
        {
            Console.Write("Jaká je cena: ");
            string s = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Kolik zaplatil: ");
            string a = Console.ReadLine();
            if (Convert.ToInt32(a) - Convert.ToInt32(s) == Math.Abs(Convert.ToInt32(a) - Convert.ToInt32(s)))
            {
                try
                {
                    KolikVratit(Convert.ToInt32(a) - Convert.ToInt32(s), false, false, false, false, false);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.WriteLine("Vráceno:");
                Console.WriteLine("50 - " + padesat + "x");
                Console.WriteLine("20 - " + dvacet + "x");
                Console.WriteLine("10 - " + deset + "x");
                Console.WriteLine("5 - " + petc + "x");
                Console.WriteLine("2 - " + dvac + "x");
                Console.WriteLine("1 - " + jedna + "x");
            }
            else
            {
                Console.WriteLine("Nejde vrátit, zaplaceno málo.");
            }
            Console.ReadKey();
        }

        public static void KolikVratit(int castka, bool pad, bool dvace, bool des, bool pet, bool dva) {
            if (!pad)
            {
                int x = castka % 50;
                if (x != 0)
                {
                    padesat = (castka - x) / 50;
                    KolikVratit(x, true, false, false, false, false);
                }
                else
                    padesat = (castka - x) / 50;
            }
            else if (!dvace)
            {
                int x = castka % 20;
                if (x != 0)
                {
                    dvacet = (castka - x) / 20;
                    KolikVratit(x, true, true, false, false, false);
                }
                else
                    dvacet = (castka - x) / 50;
            }
            else if (!des)
            {
                int x = castka % 10;
                if (x != 0)
                {
                    deset = (castka - x) / 10;
                    KolikVratit(x, true, true, true, false, false);
                }
                else
                    deset = (castka - x) / 10;
            }
            else if (!pet) 
            {
                int x = castka % 5;
                if (x != 0)
                {
                    petc = (castka - x) / 5;
                    KolikVratit(x, true, true, true, true, false);
                }
                else
                    petc = (castka - x) / 5;
            }
            else if (!dva)
            {
                int x = castka % 2;
                if (x != 0)
                {
                    dvac = (castka - x) / 2;
                    KolikVratit(x, true, true, true, true, true);
                }
                else
                    dvac = (castka - x) / 2;
            }
            else
                jedna = castka;
        }
    }
}
