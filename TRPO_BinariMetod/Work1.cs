﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work1
    {
        public void Function1()
        {
            Console.WriteLine("Введите через пробел количество чисел МАССИВА1 и МАССИВА2");
            string razmer = Console.ReadLine();
            string[] razmeri = new string[2];
            razmeri = razmer.Split(' ');

            Console.WriteLine("Введите элементы МАССИВА1 по возрастанию");
            string nabor1 = Console.ReadLine();
            string[] massiv1 = new string[Convert.ToInt32(razmeri[0])];
            massiv1 = nabor1.Split(' ');

            Console.WriteLine("Введите элементы МАССИВА2");
            string nabor2 = Console.ReadLine();
            string[] massiv2 = new string[Convert.ToInt32(razmeri[1])];
            massiv2 = nabor2.Split(' ');

            int left_number = Convert.ToInt32(massiv1[0]);
            int right_number = Convert.ToInt32(massiv1.Last());
            int middle_number = 0;

            float left_end;
            float right_end;
            float middle_end = 0;

            int target_number = 0;
            string result_number = "";

            for (int i = 0; i < massiv2.Length; i++)
            {
                target_number = Convert.ToInt32(massiv2[i]);
                left_end = 0;
                right_end = massiv1.Length - 1;
                while (true)
                {
                    middle_end = (left_end + right_end) / 2;
                    middle_number = Convert.ToInt32(massiv1[(int)middle_end]);
                    if (middle_number < target_number)
                    {
                        left_end = (int)middle_end;
                    }
                    else
                    {
                        right_end = (int)middle_end;
                    }

                    if (((right_end - left_end == 1) || (right_end == left_end)) && (middle_end % 1 != 0))
                    {
                        result_number += Convert.ToString(massiv1[(int)middle_end]) + " ";
                        break;
                    }
                }
            }

            Console.WriteLine(result_number);
        }

    }
}