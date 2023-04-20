using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work8
    {
        public void Function1()
        {
            //Получение данных
            Console.WriteLine("Введите размеры матрицы: ДЛИНА ШИРИНА");
            string[] tmp = Console.ReadLine().Split(' ') ;
            int lenght = Convert.ToInt32 (tmp[0]) ;
            int width = Convert.ToInt32(tmp[1]);

            Console.WriteLine("Вводите массив построчно в соответствии с размерами");
            int[][] m_arrMatrica = new int[lenght][];
            for(int i = 0; i < lenght; i++)
            {
                tmp = Console.ReadLine().Split(' ') ;
                int[] result = new int[width];
                for(int j = 0; j < width; j++)
                {
                    result[j] = Convert.ToInt32(tmp[j]);
                    
                }
                m_arrMatrica[i] = result;

            }

            Console.WriteLine("Введите число для поиска");
            int m_Chislo = Convert.ToInt32(Console.ReadLine());

            //Сортировка данных
            Sort(m_arrMatrica, lenght);
            Perevorot(m_arrMatrica);
            Sort(m_arrMatrica, lenght);
            Perevorot(m_arrMatrica);
            Sort(m_arrMatrica, lenght);

            //Вывод отсортированного массива
            Console.WriteLine("Отсортированный массив:");
            for(int i = 0; i < lenght; i++)
            {
                string da = "";
                for (int j = 0; j < width; j++)
                {
                    da += Convert.ToString(m_arrMatrica[i][j]) + " ";
                }
                Console.WriteLine(da);
            }

            //Поиск элемента
            int flag = 0;
            for(int i = 0; i < lenght; i++)
            {
                for(int j = 0; j < width; j++)
                {
                    if (m_arrMatrica[i][j] == m_Chislo)
                    {
                        flag++;
                        Console.WriteLine($"Адрес вашего числа в массиве (строка, столбик): ({i + 1};{j + 1})");
                    }
                }
            }
            if (flag == 0)
                Console.WriteLine("Такого числа нет в массиве");

        }

        public void Sort(int[][] arr_matrica, int lenght)
        {
            //Сортировка строк
            for(int i = 0; i < lenght; i++)
            {
                Array.Sort(arr_matrica[i]);
            }
        }

        public void Perevorot(int[][] arr_stroki)
        {
            //Замена местами строк на столбцы и наоборот

            int[][] vrem = new int[arr_stroki.Length][];

            for (int i = 0; i < arr_stroki.Length; i++)
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
