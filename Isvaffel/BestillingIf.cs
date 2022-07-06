using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvaffel
{
    public class BestillingIf
    {
        private static int[] kugler = new int[5] { 0, 19, 25, 31, 37 };
        private static int[] guf = new int[2] { 0, 6 };
        private static int[] flødeboller = new int[2] { 0, 6 };

        private static int AntalKugler { get; set; }
        private static int AntalGuf { get; set; }
        private static int AntalFlødeboller { get; set; }

        private static int Total { get; set; }

        public static void Nulstilling()
        {
            AntalKugler = 0;
            AntalGuf = 0;
            AntalFlødeboller = 0;
        }

        public static int Kugler()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Hvor mange kugler ønsker du?");
                Console.WriteLine("0: Ingen kugler \n1: 1 kugle \n2: 2 kugler \n3: 3 kugler \n4: 4 kugler");
                AntalKugler = Validation.Integer(0, 4); //Gentager sig selv indtil brugeren har indtastet et tal mellem 0-4.
                loop = false;
            } while (loop);
            return AntalKugler;
        }

        public static int Guf()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Ønsker du guf?");
                Console.WriteLine("0: Nej \n1: Ja");
                AntalGuf = Validation.Integer(0, 1); //Gentager sig selv indtil brugeren har indtastet et tal mellem 0-1.
                loop = false;
            } while (loop);
            return AntalGuf;
        }

        public static int Flødeboller()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Ønsker du flødebolle?");
                Console.WriteLine("0: Nej \n1: Ja");
                AntalFlødeboller = Validation.Integer(0, 1); //Gentager sig selv indtil brugeren har indtastet et tal mellem 0-1.
                loop = false;
            } while (loop);
            return AntalFlødeboller;
        }

        public static int TotalPris()
        {
            Total = kugler[AntalKugler] + guf[AntalGuf] + flødeboller[AntalFlødeboller];
            return Total;
        }

    }
}
