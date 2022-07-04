using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvaffel
{
    public class Bestilling
    {
        private static int[] kugler = new int[5] {0, 19, 25, 31, 37 };
        private static int[] guf = new int[2] { 0, 6 };
        private static int[] flødeboller = new int[2] { 0, 6 };

        private static int AntalKugler { get; set; }
        private static int AntalGuf { get; set; }
        private static int AntalFlødeboller { get; set; }
        
        private static int Total { get; set; }

        public static int Kugler()
        {
            bool loop = true;
            do
            {
                Console.WriteLine("Hvor mange kugler ønsker du?");
                Console.WriteLine("0: Ingen kugler \n1: 1 kugle \n2: 2 kugler \n3: 3 kugler \n4: 4 kugler");
                AntalKugler = Validation.Integer(0, 4);
                switch (AntalKugler)
                {
                    case 0:
                    case 1:
                        loop = false;
                        Console.WriteLine();
                        break;
                    case 2:
                    case 3:
                    case 4:
                        loop = false;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine();
                        break;
                }
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
                AntalGuf = Validation.Integer(0, 1);
                switch (AntalGuf)
                {
                    case 0:
                    case 1:
                        loop = false;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine($"Du kan kun vælge mellem 0-1 (Nej/Ja). Prøv igen");
                        Console.WriteLine();
                        break;
                }
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
                AntalFlødeboller = Validation.Integer(0, 1);
                switch (AntalFlødeboller)
                {
                    case 0:
                    case 1:
                        loop = false;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine($"Du kan kun vælge mellem 0-1 (Nej/Ja). Prøv igen");
                        Console.WriteLine();
                        break;
                }
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
