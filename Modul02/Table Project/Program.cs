using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Table_Project
{
    class Program
    {
        enum ti {ime=0, familia, godini};
        

        static void Main(string[] args)
        {
            //Дефиниране на таблица
            string[,] table = new string[3,4];

            //Въвеждане на първи ред
            table[0, (int) ti.ime] = "Иван";
            table[0, (int) ti.familia] = "Пенчев";
            table[0, (int) ti.godini] = "34";
            


            //Въвеждане на втори ред
            table[1, (int) ti.ime] = "Мартин";
            table[1, (int) ti.familia] = "Пенчев";
            table[1, (int) ti.godini] = "33";


            //въвеждане на трети ред
            table[2, (int) ti.ime] = "Руси";
            table[2, (int) ti.familia] = "Цолов";
            table[2, (int) ti.godini] = "33";





            //Печат
            Console.Write("Кой ред искате да видите: ");
            int _index = Convert.ToInt32(Console.ReadLine()) - 1;


            Console.WriteLine(
                (table[_index, (int) ti.ime])[0] + ". " +
                table[_index,(int)ti.familia]+", "+
                table[_index,(int)ti.godini]+" г.");

            Console.ReadKey();

        }
    }
}

//string []row = new string[3];
//row[0] = "Ред 1";
//row[1] = "Ред 2";
//row[2] = "Ред 3";

//Console.WriteLine("Масив ROW: " + row[0] + ", " + row[1] + ", " + row[2] + "\n ");

//string[] parse = "1,2,3,4,5,6,7,8,9".Split(',');
//Console.WriteLine("Броят на масива:\n" + "1,2,3,4,5,6,7,8,9\n\ne:"+parse.Length);

//string list1 = string.Join(";", parse);
//Console.WriteLine("Новият стринг е:\n"+list1+"\n\n");



