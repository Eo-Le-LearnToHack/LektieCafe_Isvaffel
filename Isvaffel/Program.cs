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
                BestillingIf.Nulstilling();
                MessageIf.PrisTavleForIsvaffel();
                BestillingIf.Kugler();
                MessageIf.ForeløbigPris();
                BestillingIf.Guf();
                MessageIf.ForeløbigPris();
                BestillingIf.Flødeboller();
                MessageIf.TotalPris();
                loop = MessageIf.Afslut();
            } while (loop);
        }

    }//class Program
}//namespace Isvaffel
