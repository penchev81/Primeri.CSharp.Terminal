using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadFrom_CommandLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //дефиниране на променливи
            int a = 5, b = 0;
            
            //въвеждане на входни параметри
            Console.Write("Моля въведете а: ");
            b = Convert.ToInt32(Console.ReadLine());
            
            
            //Печат на резултат
            Console.WriteLine("Резултата a + b e " + (a+b).ToString()+"\n");


            string test = " 1";
            test += ", 2";
            test += ", 100";
            test += ", 4";
            test += ", 5";

            Console.WriteLine( "Събиране с += :"+ test + "\n");

            test = test.Replace(",", ";");
            Console.WriteLine("Работа с Replace: " + test + "\n");

            
            Console.WriteLine("3ти знак: " + test.Split(';')[2]);



        }
    }
}
