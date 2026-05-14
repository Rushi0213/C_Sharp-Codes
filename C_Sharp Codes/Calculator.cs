using System;
using System.Collections.Generic;
using System.Text;


  class Calculator
   {

      public static void Main(string[] args)
      {
       int a,b;

       Console.Write("enter first number");
       a= int.Parse(Console.ReadLine());

       Console.WriteLine();

       Console.Write("enter second number");
       b=int.Parse(Console.ReadLine());

       Console.WriteLine("the addition is:- "+(a + b));
       Console.WriteLine("the substration is:- " + (a - b));
       Console.WriteLine("the multiplication is:- " + (a * b));
       Console.WriteLine("the Division is:- " + (a / b));
       Console.WriteLine("the reminder is:- " + (a % b));


        



      }


   }

