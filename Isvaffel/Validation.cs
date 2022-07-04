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
            do
            {
                string? answer = Console.ReadLine();
                int tempValue;
                if (int.TryParse(answer, out tempValue) && tempValue >=numMin && tempValue <= numMax)
                {
                    value = tempValue;
                }
                else
                {
                    Console.WriteLine($"The input must between {numMin}-{numMax}.");
                }

            } while (value == null);
            return (int)value;
        }

    }
}
