using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

        public void Function2()
        {
            Console.WriteLine("Вася загадал число от 1 до N. Введите N.");
            float number_end = Convert.ToInt32(Console.ReadLine());
            float number_start = 1;
            float number_middle = 0;

            int number_target = 2;
            int result = 0;

            while (true)
            {
                result++;
                number_middle = (number_start + number_end) / 2;
                
                number_end = number_middle;
                

                if((Math.Ceiling(number_end)-number_start == 1) && number_middle % 1 != 0)
                {
                    Console.WriteLine(result);
                    break;
                }
            }
            
        }

        public void Function3()
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
            int middle_number2 = 0;

            float left_end;
            float right_end;
            double middle_end = 0;

            int target_number = 0;
            string result = "";

            for (int i = 0; i < massiv2.Length; i++)
            {
                target_number = Convert.ToInt32(massiv2[i]);
                left_end = 0;
                right_end = massiv1.Length - 1;
                while (true)
                {
                    //Код для проверки искомого числа на равенство с границами
                    middle_end = (left_end + right_end) / 2;
                    middle_number = Convert.ToInt32(massiv1[(int)middle_end]);
                    if (middle_number == target_number)
                    {
                        result = "YES";
                        break;
                    }else if(middle_number < target_number)
                    {
                        left_end = (int)middle_end;
                    }else
                    {
                        right_end = (int)middle_end;
                    }

                    if (((right_end - left_end == 1) || (right_end == left_end)) && (middle_end % 1 != 0))
                    {
                        if(middle_number == target_number)
                        {
                            result = " YES ";
                            break;
                        }else
                        {
                            result = " NO ";
                            break;
                        }
                    }

                }
                Console.WriteLine(result);
            }

            
        }

    }
}
