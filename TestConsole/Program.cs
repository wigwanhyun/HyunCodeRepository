using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintFeetToMeter(1, 20);
            PrintMeterToFeet(1, 20);


            Console.Read();
        }

        static double FeetToMeter(int feet)
        {
            return feet * 0.3048;
        }
        static double MeterToFeet(int meter)
        {
            return meter / 0.3048;
        }

        static void PrintFeetToMeter(int start, int stop)
        {
            for (int feet = start; feet <= stop; feet++)
            {
                double meter = FeetToMeter(feet);
                Console.WriteLine("{0} FT = {1:0.0000} M", feet, meter);
            }
        }

        static void PrintMeterToFeet(int start, int stop)
        {
            for (int meter = start; meter <= stop; meter++)
            {
                double feet = MeterToFeet(meter);
                Console.WriteLine("{0} M = {1:0.0000} ft", meter, feet);
            }
        }
    }
}
