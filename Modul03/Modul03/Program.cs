using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul03
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0;

            Console.Write("> a = ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("> b = ");
            b = Convert.ToDouble( Console.ReadLine());


            string _format = "#0.00 м3";

            Console.WriteLine("\n\n>a / b = " + (a/b).ToString(_format));




        }
    }
}
