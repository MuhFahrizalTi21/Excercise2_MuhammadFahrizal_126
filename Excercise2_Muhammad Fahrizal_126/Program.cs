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
        public void display()
        {
            //display the shorted array
            Console.WriteLine("");
            Console.WriteLine(".......................");
            Console.WriteLine("Shorted Array Elements");
            Console.WriteLine(".......................");
            for (int j = 0; j < n; j++)
            {
                Console.WriteLine(fahrizal[j]);
            }
        }

     
            public void MainMerge(int[] numbers, int left, int mid, int right)
            {
                int[] temp = new int[25];
                int i, eol, num, pos;
                eol = (mid - 1);
                pos = left;
                num = (right - left + 1);

                while ((left <= eol) && (mid <= right))
                {
                    if (numbers[left] <= numbers[mid])
                        temp[pos++] = numbers[left++];
                    else
                        temp[pos++] = numbers[mid++];
                }
                while (left <= eol)
                    temp[pos++] = numbers[left++];
                while (mid <= right)
                    temp[pos++] = numbers[mid++];
                for (i = 0; i < num; i++)
                {
                    numbers[right] = temp[right];
                    right--;
                }
            }

            public void SortMerge(int[] numbers, int left, int right)
            {
                int mid;
                if (right > left)
                {
                    mid = (right + left) / 2;
                    SortMerge(numbers, left, mid);
                    SortMerge(numbers, (mid + 1), right);
                    MainMerge(numbers, left, (mid + 1), right);
                }
            }

            public void main(string[] args)
            {

                Console.Write("\nProgram for sorting a numeric array using Merge Sorting");
                Console.Write("\n\nEnter number of elements: ");
                int max = Convert.ToInt32(Console.ReadLine());
                int[] numbers = new int[max];
                for (int i = 0; i < max; i++)
                {
                    Console.Write("\nEnter [" + (i + 1).ToString() + "] element: ");
                    numbers[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Input int array : ");
                Console.Write("\n");
                for (int k = 0; k < max; k++)
                {
                    Console.Write(numbers[k] + " ");
                    Console.Write("\n");
                }
                Console.WriteLine("MergeSort By Recursive Method");
                SortMerge(numbers, 0, max - 1);
                for (int i = 0; i < max; i++)
                    Console.WriteLine(numbers[i]);
                Console.ReadLine();
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
                        myList.display();
                        break;
                    case 2:
                        Console.WriteLine("");
                        Console.WriteLine("................");
                        Console.WriteLine("Merge Sort");
                        Console.WriteLine("................");
                        myList.MainMerge();
                        myList.SortMerge();
                        myList.Main();
                        break;

                    case 3:
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
