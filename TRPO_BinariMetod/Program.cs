using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;


namespace TRPO_BinariMetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Work1 da = new Work1();
                da.Function3();

                Console.WriteLine();
                Console.WriteLine(" Желаете продолжить? Введите '+' - ДА ИЛИ '-' - НЕТ");
                string signal = Console.ReadLine();
                if (signal == "-")
                {
                    Console.WriteLine("ББ");
                    break;
                }           
               
            }

        }
    }
}
