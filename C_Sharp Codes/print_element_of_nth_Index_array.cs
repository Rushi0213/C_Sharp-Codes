using System;
using System.Collections.Generic;
using System.Text;


    class print_element_of_nth_Index_array
   {
   static void Main(string[] args)
   {
       int []arr = new int[6];
       arr[0] = 1;
       arr[1] = 2;
       arr[2] = 3;
       arr[3] = 4;
       arr[4] = 5;
       arr[5] = 6;

       Console.WriteLine("array on the index is " + arr[5]);
       for(int i=0;i<arr.Length;i++)
       {
           Console.WriteLine(arr[i]);
       }
   }
}

