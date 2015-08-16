using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamplesDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниции
            string _userinput = "";

            //Потребителски вход
            do
            {
                Console.Write("?");
                _userinput = Console.ReadLine();
            } while (_userinput != "exit");

        }
    }
}
