using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work5
    {
        public void Function1()
        {
            Console.WriteLine("Введите количество чисел:");
            int size = Convert.ToInt32(Console.ReadLine());
            string[] arr_numbers = new string[size];
            string[] arr_sings = new string[size];

            Console.WriteLine("Теперь вводите числа:");
            string[] number;
            for (int i = 0; i < size; i++)
            {
                number = Console.ReadLine().Split(' ');
                arr_numbers[i] = number[0];
                arr_sings[i] = number[1];              
                
            }

            string[] arr_result = new string[size];
            for(int i = 0; i < size; i++)
            {
                if (arr_sings[i] == "+")
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (arr_numbers[i] == arr_result[j])
                            break;
                        arr_result[i] = arr_numbers[i];
                        break;
                    }                    
                }

                if (arr_sings[i] == "-")
                {
                    for (int j = 0; j < size; j++)
                    {
                        if (arr_numbers[i] == arr_result[j])
                        {
                            arr_result[j] = null;
                            break;
                        }
                            
                    }
                }

            }

            string result = "";
            int count = 0;
            for(int i = 0; i < size; i++)
            {
                if (arr_result[i] != null)
                {
                    result += arr_result[i] + " ";
                    count++;
                }

            }

            Console.WriteLine("Количество элементов:" + count);
            Console.WriteLine(result);

        }
    }
}
