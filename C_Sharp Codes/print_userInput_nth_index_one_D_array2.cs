using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace Csharp_programing
{
    internal class print_userInput_nth_index_one_D_array2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the size od array");
            int size =Convert.ToInt32(Console.ReadLine());
            int[] arr=new int[size];

            Console.WriteLine("enter the element");

            for(int i=0;i<arr.Length;i++)
            {
                arr[i]=Convert.ToInt32(Console.ReadLine());

            }

            Console.WriteLine("enter the index");
            int index=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < arr.Length; i++)
            {
                if (i == index)
                {
                    Console.WriteLine("element is: " + arr[i]);
                }
                else
                {
                    Console.WriteLine("index not found");
                }
            }
        }
    }
}
