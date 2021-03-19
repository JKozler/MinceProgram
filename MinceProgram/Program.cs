using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinceProgram
{
    class Program
    {
        private static int padesat = 0;
        private static int dvacet = 0;
        private static int deset = 0;
        private static int petc = 0;
        private static int dvac = 0;
        private static int jedna = 0;
        static void Main(string[] args)
        {
            KolikVratit(239, false, false, false, false, false);
            Console.WriteLine("50 - " + padesat+ "x");
            Console.WriteLine("20 - " + dvacet + "x");
            Console.WriteLine("10 - " + deset + "x");
            Console.WriteLine("5 - " + petc + "x");
            Console.WriteLine("2 - " + dvac + "x");
            Console.WriteLine("1 - " + jedna + "x");
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
