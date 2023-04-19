using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work7
    {
        public void Function1()
        {
            Console.WriteLine("Введите ДЛИНУ и ШИРИНУ пазла");
            string data = Console.ReadLine();
            string[] m_arrSizePazla = data.Split(' ');
            int lenght = Convert.ToInt32(m_arrSizePazla[0]);
            int width = Convert.ToInt32(m_arrSizePazla[1]);
            Console.WriteLine("Генерируем пазл");

            //Будет посторочная генерация
            for (int i = 0; i < lenght; i++)
            {
                //Всего будет 4 строки - один кусочек пазла

                //Первая строка
                if (i == 0)
                {
                    Console.WriteLine("   _( )_ " + String.Concat(Enumerable.Repeat("_( )_ ", width - 1)));
                    Console.WriteLine(" _|    _|" + String.Concat(Enumerable.Repeat("    _|", width - 1)));
                    Console.WriteLine("(_    (_ " + String.Concat(Enumerable.Repeat("   (_ ", width - 1)));
                    Console.WriteLine("  |_( )_|" + String.Concat(Enumerable.Repeat("_( )_|", width - 1)));

                }
                else
                {
                    Console.WriteLine(" _|    _|" + String.Concat(Enumerable.Repeat("    _|", width - 1)));
                    Console.WriteLine("(_    (_ " + String.Concat(Enumerable.Repeat("   (_ ", width - 1)));
                    Console.WriteLine("  |_( )_|" + String.Concat(Enumerable.Repeat("_( )_|", width - 1)));
                }
            }

        }              
    }
}
