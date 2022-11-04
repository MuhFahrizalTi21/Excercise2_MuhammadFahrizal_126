using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2_Muhammad_Fahrizal_126
{
    class Program
    {
        // membuat array 
        int[] fahrizal = new int[20];
        // Number of elements in the array 
        int n;
        //Get the number of elements to store in the array
        int i;

        public void input()
        {
            while (true)
            {
                Console.WriteLine("Masukkan panjang array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Masukan Panjang Array Minimal 1 dan Maksimum 20 elemen.\n");

                for (i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    fahrizal[i] = Int32.Parse(s1);
                }
            }
        }

        public void InsertionSort()
        {
            int j, temp;
            for (int i = 1; i <= fahrizal.Length - 1; i++)
            {
                temp = fahrizal[i];
                j = i - 1;
                while (j >= 0 && fahrizal[j] > temp)
                {
                    fahrizal[j + 1] = fahrizal[j];
                    j--;
                }
                fahrizal[j + 1] = temp;
            }

        }
        static void Main(string[] args)
        {
        }
    }
}
