using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            //Дефиниции
            string _userinput = "";

            //List
            List<int> list = new List<int>();
            list.Add(5);
            list.Add(3);
            list.Add(9);
            list.Add(12);

            //Потребителски вход
            do
            {
                Console.Write("? ");
                _userinput = Console.ReadLine();

                //Добавяне на Стойности

                //Преглед на List
                if (_userinput.Contains("show"))
                {
                    Console.Write("List: ");
                    for (int i = 0; i < list.Count; i++)
                    {
                        
                        Console.Write(list[i]);
                        if (i != list.Count -1)Console.Write(", ");
                        {
                            
                        }
                    }
                    Console.WriteLine();
                }

                //Размер на List


            } while (_userinput != "exit");

        }
    }
}
