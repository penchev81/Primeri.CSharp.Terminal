using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] _i = new int[] { 4, 3, 2 };

            int _ui = 0;

            string _input = "0";

            Console.Write("Моля въведете индекс: ");
            _input = Console.ReadLine();

            bool _check01 = int.TryParse(_input, out _ui);


            //Използване на условно присвояване.

            //_ui = (_ui <= _i.Length) ? _ui : 3;
            //_ui = (_ui > 0) ? _ui : 1;


            // Използване наSwitc

            switch (_ui)
            {
                case 1:
                {
                    Console.Write("1ви елемен от масива: ");
                    Console.WriteLine(_i[_ui-1]);
                    break;
                } 
                case 2:
                {
                    Console.Write("2ри елемен от масива: ");
                    Console.WriteLine(_i[_ui-1]);
                    break;

                }
                case 3:
                {
                    Console.Write("3ти елемен от масива: ");
                    Console.WriteLine(_i[_ui-1]);
                    break;
                }
                default:
                {
                    Console.Write("В масива няма стойност за този индекс.\n опитайте с индекс между 1 и 3.\n\n ");
                    break;
                }
            }

        }
    }
}
