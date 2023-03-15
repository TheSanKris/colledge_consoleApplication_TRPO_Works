using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work3
    {
        public void Function1()
        {
            Console.WriteLine("Введи значения клеток игрового поля");
            string tmp = Console.ReadLine();
            string[] tmp_arr = tmp.Split();
            int[] doska = Array.ConvertAll(tmp_arr, int.Parse);

            int cubik = 0;
            int lenght_doska = doska.Length;
            int last_position = 0;
            int position = 0;
            int number_hod = 0;

            while(true)
            {
                Console.WriteLine("");
                Console.WriteLine("Введите значение кости");
                cubik = Convert.ToInt32(Console.ReadLine());
                last_position = position;
                position += cubik;
                number_hod++;                

                Console.WriteLine($"Сдвиньтесь на {cubik}");

                while(true)
                {
                    Console.WriteLine($"------- {number_hod} -------");
                    Console.WriteLine($"Значение кубика {cubik}");
                    Console.WriteLine($"Ваша позиция: {position}; Прошлая позиция: {last_position}");
                    Console.WriteLine(tmp);

                    if (position > lenght_doska)
                    {
                        Console.WriteLine("Вы вышли за границу, следующий бросок кубика!");
                        position = last_position;
                        break;
                    }
                    else if (doska[position-1] != 0)
                        position += doska[position-1];
                    else
                        break;
                }

                if(position == lenght_doska)
                {
                    Console.WriteLine("");
                    Console.WriteLine("УРА! УРА! УРА! УРА! УРА! УРА! УРА! ");
                    Console.WriteLine("--------- Вы победили!!! ---------");
                    Console.WriteLine("УРА! УРА! УРА! УРА! УРА! УРА! УРА! ");
                    break;
                }                

            }

        }

    }
}
