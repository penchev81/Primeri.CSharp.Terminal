using System;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace Modul02
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			//дефиниране на променливи
		    int a = 0, b = 0;
		    int sum = 0;

		    //Събиране на Числа
		    a = 55;
		    b = 10;

		    sum = a + b;

		    //Писане в конзола
		    Console.Write(a);
		    Console.Write(" + ");
		    Console.Write(b);
            Console.Write(" = ");
		    Console.WriteLine(sum);  

		}
	}
}
