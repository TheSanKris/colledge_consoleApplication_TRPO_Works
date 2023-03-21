using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work4
    {
        public void Function1()
        {
            Console.WriteLine("Введите 2 числа (размеры матрицы - длиина, ширина)");
            string tmp = Console.ReadLine();
            string[] arr = tmp.Split(' ');
            int[][] arr_stroki = new int[Convert.ToInt32(arr[0])][];

            //Получение и преобразование строк в числовой тип
            
            for(int i = 0; i < arr_stroki.Length; i++)
            {
                tmp = Console.ReadLine();
                string[] vrm = tmp.Split(' ');
                int[] stroka = Array.ConvertAll(vrm, int.Parse);
                if (stroka.Length > Convert.ToInt32(arr[1]))
                    break;
                arr_stroki[i] = stroka;
            }

            Console.WriteLine("Преобразуем строки");
            Sravnivanie(arr_stroki);
            int finish = 0;
            arr_stroki = Normalization(arr_stroki, finish);
            if (finish == 1)
                return;            
            Perevorot(arr_stroki);

            //Теперь "Столбцы"

            Console.WriteLine("Преобразуем столбцы");
            Sravnivanie(arr_stroki);
            finish = 0;
            Normalization(arr_stroki, finish);
            if (finish == 1)
                return;
            Perevorot(arr_stroki);

            Console.WriteLine("---- Результат ----");
            for(int i = 0; i < arr_stroki.Length; i++)
            {
                for (int j = 0; j < arr_stroki[i].Length; j++)
                {
                    Console.Write(arr_stroki[i][j] + " ");
                }
                Console.WriteLine();
            }

        }

        public void Sravnivanie(int[][] arr_stroki)
        {
            //Сравнивание СТРОК или "СТОЛБЦОВ"

            int counter = 0;
            int[] nulle = new int[0];

            for (int i = 0; i < arr_stroki.Length; i++)
            {
                for (int j = 0; j < arr_stroki.Length; j++)
                {
                    if (i == j)
                        continue;
                    if ((arr_stroki[i].Length == 0) || (arr_stroki[j].Length == 0))
                        continue;

                    counter = 0;
                    for (int k = 0; k < arr_stroki[i].Length; k++)
                    {
                        if (arr_stroki[i][k] > arr_stroki[j][k])
                            counter++;

                    }

                    if (counter == arr_stroki[i].Length)
                        arr_stroki[j] = nulle;

                }
            }
        }

        public int[][] Normalization(int[][] arr_stroki, int finish)
        {
            //Обработка массива после сравнивания строк

            int dada = 0;
            for (int i = 0; i < arr_stroki.Length; i++)
            {
                if (arr_stroki[i].Length != 0)
                    dada++;
            }

            int[][] arr_vrem = new int[dada][];

            int da = 0;
            for (int i = 0; i < arr_stroki.Length; i++)
            {
                if (arr_stroki[i].Length == 0)
                    continue;
                arr_vrem[da] = arr_stroki[i];
                da++;

            }
            arr_stroki = arr_vrem;

            if (arr_stroki.Length == 1)
            {
                Console.Write("Осталась только: ");
                for (int i = 0; i < arr_stroki[0].Length; i++)
                {
                    Console.Write(arr_stroki[0][i] + " ");
                }
                finish = 1;
                return arr_stroki;
            }
            return arr_stroki;

        }

        public void Perevorot(int[][] arr_stroki)
        {
            //Замена местами строк на столбцы и наоборот

            int[][] vrem = new int[arr_stroki.Length][];
                        
            for(int i = 0; i < arr_stroki.Length; i++)
            {
                int[] vremvrem = new int[arr_stroki[0].Length];
                for (int j = 0; j < arr_stroki.Length; j++)
                {
                    vremvrem[j] = arr_stroki[j][i];
                   
                }
                vrem[i] = vremvrem;
            }
            arr_stroki = vrem;

        }

    }
}
