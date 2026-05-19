using System;
using System.Collections.Generic;
using System.Text;


   class ifElsestmt
   {

 public static void Main(string[] args)
   {

       int age = int.Parse(Console.ReadLine());
       if(age>18)
       {
           Console.WriteLine("you are eligible for voting");

       }
       else
       {
           Console.WriteLine("you are not eligible for voting");
       }
   }

}

