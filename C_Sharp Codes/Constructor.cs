using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_programing
{
    
   internal class Constructor
   {
       static int num=10;
       //1) default constructor
       //Constructor()//default constructor
       //{
       //    Console.WriteLine("default constructor");
       //}
       //2)parameterized consructor
       Constructor(int a)//parameterized constructor
       {
           Console.WriteLine("parameterized constructor"+a);
       }
        
       Constructor(string c,int b)// parametrerized constructor
       {
           Console.WriteLine("parameterized with name is"+c+"  and roll no is"+b);
       }
     //3) privte constructror
       private Constructor()
       {
           Console.WriteLine("this is private constructor");
       }

       //4) static constructor

       static Constructor()
       {
           Console.WriteLine("this is static constructor"+num);
       }

       static void Main(string[] args)
       {
            
           Constructor sc= new Constructor();//default constructor call
           Constructor sc1 = new Constructor(10);// one parameter with parameterized constructor
           Constructor sc2 = new Constructor("rushi",10);// multiple parameter with parameterized constructor

       }

   }
}
