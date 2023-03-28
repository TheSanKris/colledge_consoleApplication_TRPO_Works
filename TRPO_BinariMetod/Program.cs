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
                Work5 da = new Work5();
                da.Function1();

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
