using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvaffel
{
    internal class MessageIf
    {
        public static void PrisTavleForIsvaffel()
        {
            Style style = new();
            Console.WriteLine(style.UNDERLINE_UNDO);
            Console.Clear();
            Console.WriteLine("***************************************************");
            Console.WriteLine("Kære kunde.");
            Console.WriteLine("Velkommen til isbutikken GammeldagsIsVaffel.");
            Console.WriteLine("");
            Console.WriteLine(style.UNDERLINE + "PRISLISTEN:" + style.UNDERLINE_UNDO);
            Console.WriteLine("...................................................");
            Console.WriteLine("1 kugle:\t 19 kr.");
            Console.WriteLine("2 kugle:\t 25 kr.");
            Console.WriteLine("3 kugle:\t 31 kr.");
            Console.WriteLine("4 kugle:\t 37 kr.");
            Console.WriteLine("guf:\t\t 6 kr.");
            Console.WriteLine("flødebolle :\t 6 kr.");
            Console.WriteLine("***************************************************");
            Console.WriteLine();
        }


        public static void ForeløbigPris()
        {
            Style style = new();
            Console.WriteLine("Din isvaffel koster indtil videre:\t" + style.UNDERLINE + $"{BestillingIf.TotalPris():c2}" + style.UNDERLINE_UNDO);
            Console.WriteLine();
        }

        public static void TotalPris()
        {
            Console.WriteLine($"Din isvaffel koster:\t\t\t {BestillingIf.TotalPris():c2}");
            Console.WriteLine("\t\t\t\t\t" + new string('\u2550', 10)); //Double underline
            Console.WriteLine();
        }


        public static bool Afslut()
        {
            bool loop = true;
            bool loopOut = false;
            do
            {
                Console.WriteLine("Indtast \n0: For at afslutte. \n1: For at foretage en ny bestilling.");
                int brugerensValg = Validation.Integer(0, 1); //Gentager sig selv indtil brugeren har indtastet et tal mellem 0-1.
                if (brugerensValg == 1)
                {
                    loopOut = true;
                }
                loop = false;
            } while (loop);
            return loopOut;
        }

    }
}
