using System;
using System.Runtime.InteropServices;

namespace Isvaffel
{
    public class Program
    {
        public static void Main(string[] args)
        {
            bool loop = true;
            do
            {
                Bestilling.Nulstilling();
                Message.PrisTavleForIsvaffel();
                Bestilling.Kugler();
                Message.ForeløbigPris();
                Bestilling.Guf();
                Message.ForeløbigPris();
                Bestilling.Flødeboller();
                Message.TotalPris();
                loop = Message.Afslut();
            } while (loop);
        }

    }//class Program
}//namespace Isvaffel
