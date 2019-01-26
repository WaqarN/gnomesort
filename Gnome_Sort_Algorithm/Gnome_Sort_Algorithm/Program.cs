using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gnome_Sort_Algorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10] { 10, 3, 12, 50, 23, 1, 9, 233, 100, 8 };
            Gnome(arr);
            foreach(int i in arr)
                Console.Write(i + ">");
        }

        public static void Gnome(int[] arr)
        {
            int pos = 0;
            while (pos < arr.Length)
            {
                if (pos==0 || arr[pos] >= arr[pos - 1])
                    pos = pos + 1;
                else
                {
                    int temp = arr[pos];
                    arr[pos] = arr[pos - 1];
                    arr[pos - 1] = temp;
                    pos = pos - 1;

                }
            }
        }
    }
}
