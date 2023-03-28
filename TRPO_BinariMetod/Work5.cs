using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work5
    {
        public void Function1()
        {
            string file_read = File.ReadAllText(@"C:\Progects\College VKSIT\OAiP\TRPO_BinariMetod\TRPO_BinariMetod\note.txt");
            string[] tmp;
            string[] a = { "\n", "\r" };
            tmp = file_read.Split(a, System.StringSplitOptions.RemoveEmptyEntries);

            int size = tmp.Length;            
            string[] arr_numbers = new string[size];
            string[] arr_sings = new string[size];

            string[] number;

            for(int i = 0; i < size; i++)
            {
                number = tmp[i].Split(' ');
                arr_numbers[i] = number[0];
                arr_sings[i] = number[1];
            }

            string[] arr_result = new string[size];
            for (int i = 0; i < size; i++)
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
                File.WriteAllLines(@"C:\Progects\College VKSIT\OAiP\TRPO_BinariMetod\TRPO_BinariMetod\note.txt", arr_result);
            }    

            for (int i = 0; i < size; i++)
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
