using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;


class one_D_array_withSize
{
   static void Main(string[] args)
   {
       int[] arr = new int[4];
       arr[0] = 1;
       arr[1] = 2;
       arr[2] = 3;
       arr[3] = 4;

       int index = 0;
       while (index < arr.Length)
       {
           Console.WriteLine("the array is " + arr[index]);
           index++;
       }
   }
}

