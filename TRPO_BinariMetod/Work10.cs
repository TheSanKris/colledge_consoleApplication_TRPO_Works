using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TRPO_BinariMetod
{
    internal class Work10
    {
        public void Function1()
        {            
            Console.WriteLine("Сейчас мы построим для вас цепочку домино (21 штука)");

            string[] arr = { ".", ":", ".:", "::", ".::", ":::" };
            int[] use = new int[6];

            int counter = 0;            
            string m_LastPart = "";

            InsertDomino(arr, use, counter, m_LastPart);
            
        }

        public void InsertDomino( string[] arr, int[] use,int counter, string lastPart)
        {
           

            Console.Write("[" + firstPart + "-" + secondPart + "]");
            counter++;
            InsertDomino(arr, use, counter, lastPart);
        }

    }
}
