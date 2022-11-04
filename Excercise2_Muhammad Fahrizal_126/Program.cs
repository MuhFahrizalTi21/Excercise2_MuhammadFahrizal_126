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
                Console.Write("Masukkan panjang array : ");
                string s = Console.ReadLine();
                n = Int32.Parse(s);
                if ((n > 0) && (n <= 20))
                    break;
                else
                    Console.WriteLine("\n Masukan Panjang Array Minimal 1 dan Maksimum 20 elemen.\n");
            }
                Console.WriteLine("");
                Console.WriteLine(".......................");
                Console.WriteLine("Masukkan element Array");
                Console.WriteLine(".......................");
                for (i = 0; i < n; i++)
                {
                    Console.Write("<" + (i + 1) + ">");
                    string s1 = Console.ReadLine();
                    fahrizal[i] = Int32.Parse(s1);
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
            Program myList = new Program();
            int PilihanMenu;
            do
            {
                Console.WriteLine("Menu Option");
                Console.WriteLine("=================");
                Console.WriteLine("1. Insertion Sort");
                Console.WriteLine("2. Merge Sort");
                Console.WriteLine("3. Exit");
                Console.WriteLine("Enter your choice (1,2,3) : ");
                PilihanMenu = Convert.ToInt32(Console.ReadLine());

                switch (PilihanMenu)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Insertion Sort");
                        Console.WriteLine("................");
                        myList.input();
                        myList.InsertionSort();
                        break;
                    case 2:
                        Console.WriteLine("Exit.");
                        break;
                    default:
                        Console.WriteLine("Error");
                        break;
                }
                //to exit from the console
                Console.WriteLine("\n\nPress Return to exit.");
                Console.ReadLine();
            } while (PilihanMenu != 3);
        }
    }
}
