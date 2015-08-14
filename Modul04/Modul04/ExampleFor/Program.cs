using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExampleFor
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] _table = {"Иван", "Гошо", "Гергана"};

            //Антетка на таблица
            Console.WriteLine("Име");
            Console.WriteLine("===============");

            //Тяло на таблица
            for (int i = 0; i < _table.Length; i ++)
            {
                //Код на Цикъка
                Console.WriteLine(_table[i]);
            }
        }
    }
}
