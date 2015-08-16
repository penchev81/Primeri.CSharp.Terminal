using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhile
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string[,] _table =
            {
                {"Иван", "Георгиев", "19"},
                {"Васил", "Иванов", "23"},
                {"Милен", "Георгиев", "58"},
                {"Цветан", "Бориславов", "14"},
                {"Гергана", "Василева", "25"},
                {"Ивана", "Христова", "21"}

            };

            //Антетка на таблица
            Console.WriteLine("Име".PadRight(12) + "Фамилия".PadRight(12) + "Години".PadRight(12));
            Console.WriteLine("=================================");


            int i = 0;
            
            do
            {
            Console.WriteLine
                (_table[i, 0].PadRight(12) +
                    _table[i, 1].PadRight(12) +
                    _table[i, 2].PadRight(12)
                );

                i++;
            } 
            while (i<_table.Length /3);
        }
    }
}
