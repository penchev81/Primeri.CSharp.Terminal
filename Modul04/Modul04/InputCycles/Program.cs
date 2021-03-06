﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputCycles
{
    class Program
    {
        static void Main(string[] args)
        {
            string[,] _table =
            {
                {"Иван",    "Георгиев",     "19"},
                {"Васил",   "Иванов",       "23"},
                {"Милен",   "Георгиев",     "58"},
                {"Цветан",  "Бориславов",   "14"},
                {"Гергана", "Василева",     "25"},
                {"Ивана",   "Христова",     "21"}

            };

            //Антетка на таблица
            Console.WriteLine("Име".PadRight(12)+ "Фамилия".PadRight(12)+ "Години".PadRight(12));
            Console.WriteLine("=================================");


            
            //Тяло на таблица
            for (int i = 0; i < _table.Length / 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(_table [i,j].PadRight(12));
                }
                Console.WriteLine();
            }
        }
    }
}
