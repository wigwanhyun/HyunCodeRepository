using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileDirectory
{
    class Study
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                double meter = i * 0.3048;
                Console.WriteLine("{0} FT = {1:0.0000} M", i, meter);
            }
        }
    }
}
