﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниции
            string _userinput = "";

            //List
            List<int> _list = new List<int>();
            _list.Add(5);
            _list.Add(3);
            _list.Add(9);
            _list.Add(12);

            //Потребителски вход
            do
            {
                Console.Write("? ");
                _userinput = Console.ReadLine();

                //Добавяне на Стойности
                
                //add<int>

                if (_userinput.ToLower().Contains("add"))
                {
                    try
                    {
                        int _add = 0;
                        if (int.TryParse(_userinput.Split(' ')[1], out _add))
                        {
                            _list.Add(_add);
                            Console.WriteLine();
                        }
                    }
                    catch
                    {
                        
                    }
                }

                //Преглед на List
                if (_userinput.ToLower().Contains("show"))
                {
                    Console.Write("List: ");
                    for (int i = 0; i < _list.Count; i++)
                    {

                        Console.Write(_list[i]);
                        if (i != _list.Count - 1) Console.Write(", ");
                        {

                        }
                    }
                    Console.WriteLine();
                }

                //Размер на List
                if (_userinput.ToLower().Contains("size"))
                {
                    Console.WriteLine("Размер на списъка: "+ _list.Count.ToString()+"\n");
                }

            } while (_userinput != "exit");
        }
    }
}
