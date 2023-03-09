using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work2
    {
        public void Function1()
        {
            Console.WriteLine("Введите через пробел 3 числа: 'Ширина', 'Высота', 'Множитель'.");
            string tmp = Console.ReadLine();
            string[] arr = tmp.Split();
            int[] values = Array.ConvertAll(arr, int.Parse);             

            float width = values[0];
            float heigth = values[1];
            int multiplier = values[2];

            float square = 0;
            int limit = multiplier;
            int step = 0;
            int gamer_number = 0;

            float remainder_width = 0;
            float remainder_height = 0;
            int i_h = 1;
            int i_w = 1;

            while (true)
            {
                step++;
                square = width * heigth;

                if (square <= limit + 1)
                {
                    step++;
                    break;
                }

                remainder_width = width / limit;
                remainder_height = heigth / limit;

                if (remainder_width < remainder_height)
                {                    
                    for(int i = 0; limit >= width*i_h;)
                    {
                        i_h++;
                    }
                    heigth -= i_h;
                }
                else
                {
                    for (int i = 0; limit >= heigth * i_w;)
                    {
                        i_w++;
                    }
                    heigth -= i_w;
                }

            }

            if (step % 2 == 1)
                gamer_number = 1;
            else
                gamer_number = 2;

            Console.WriteLine(gamer_number);
        }

        public void Function2()
        {
            Console.WriteLine("Введите целое число, чтобы мы разложили его на простые множители");
            float number = Convert.ToInt32(Console.ReadLine());

            float[] ezzy_multipliers = new float[4] {2, 3, 5, 7};
            int[] ez_mult_degrees = new int[4];

            float middle_number = 0;
            string result = "";

            for (int ez_mult_id = 0; ez_mult_id < ezzy_multipliers.Length; ez_mult_id++)
            {
                if (number % ezzy_multipliers[ez_mult_id] == 0)
                {
                    while (true)
                    {
                        ez_mult_degrees[ez_mult_id]++;
                        middle_number = number / ezzy_multipliers[ez_mult_id];
                        number = middle_number;
                        if (middle_number % ezzy_multipliers[ez_mult_id] != 0)
                            break;
                    }
                }

                if (number == 1)
                    break;
            }
            
            for(int i = 0; i < ezzy_multipliers.Length; i++)
            {
                if(ez_mult_degrees[i] != 0)
                    result += Convert.ToString(ezzy_multipliers[i]) + "^" + Convert.ToString(ez_mult_degrees[i]) + "*";
            }
             
            if(number != 1)
                result += Convert.ToString(number);

            Console.WriteLine(result);

        }

    }
}
