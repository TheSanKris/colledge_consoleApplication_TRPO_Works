using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work9
    {
        public void Function1()
        {
            Console.WriteLine("Введите количество вставок");
            int m_Number = Convert.ToInt32(Console.ReadLine());

            int counter = 0;
            int countPosition = 1;
            while (true)
            {                
                countPosition = countPosition + countPosition;
                if (countPosition > m_Number)
                    break;
                counter++;
            }

            Console.WriteLine($"Количество раз увеличений массива равно {counter}");

        }
    }
}
