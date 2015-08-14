using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.DesignerServices;
using System.Text;
using System.Threading.Tasks;

namespace Soft_WittedError
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

            try
            {
                Console.Write("Елемен " + _ui.ToString() + " от масива е ");
                Console.WriteLine(_i[_ui -1]);
            }
            catch
            {
                Console.WriteLine("< Недефиниран елемен >");
            }
        }
    }
}
