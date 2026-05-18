using System;
using System.Collections.Generic;
using System.Text;


    class PrimeNo_forloop
   {
  public static void Main(string[] args)
   {
       //prime no is divisible by itself and 1

       //int no=Convert.ToInt32( Console.ReadLine());
       int no = 6;

       for (int i = 2; i < no; i++)
       {
           if(no%2==0)
           {
               Console.WriteLine(" Not prime");
           }
            
       }
   }
}

