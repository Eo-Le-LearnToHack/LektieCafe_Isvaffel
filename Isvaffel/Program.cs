using System;
using System.Runtime.InteropServices;

namespace Isvaffel
{
    public class Program
    {
        //const int STD_OUTPUT_HANDLE = -11;
        //const uint ENABLE_VIRTUAL_TERMINAL_PROCESSING = 4;

        //[DllImport("kernel32.dll", SetLastError = true)]
        //static extern IntPtr GetStdHandle(int nStdHandle);

        //[DllImport("kernel32.dll")]
        //static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);

        //[DllImport("kernel32.dll")]
        //static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
        public static void Main(string[] args)
        {
            //    var handle = GetStdHandle(STD_OUTPUT_HANDLE);
            //    uint mode;
            //    GetConsoleMode(handle, out mode);
            //    mode |= ENABLE_VIRTUAL_TERMINAL_PROCESSING;
            //    SetConsoleMode(handle, mode);

            //    const string UNDERLINE = "\x1B[4m";
            //    const string RESET = "\x1B[0m";
            //    Console.WriteLine("Some " + UNDERLINE + "Min tekst er underlined" + RESET + " text");
            //Console.ReadLine();
         

            bool loop = true;
            do
            {
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
