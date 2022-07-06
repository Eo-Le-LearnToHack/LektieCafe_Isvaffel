using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Isvaffel
{
    internal class Validation
    {
        public static int Integer(int numMin, int numMax)
        {
            int? value = null;
            string messageChoice = $"Du kan kun vælge mellem {numMin}-{numMax}.";
            do
            {
                string? answer = Console.ReadLine();
                int tempValue;
                if (int.TryParse(answer, out tempValue) && tempValue >= numMin && tempValue <= numMax)
                {
                    value = tempValue;
                    if (value < numMin && value > numMax)
                    {
                        Console.WriteLine(messageChoice);
                        value = null;
                    }
                }
                else
                {
                    Console.WriteLine(messageChoice);
                }
            } while (value == null);
            return (int)value;
        }

    }
}
