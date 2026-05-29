using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
using System.Text;


   class Inheritance1
   {
       public void Home()
       {
           Console.WriteLine("this is parent home");
       }

   }
class child:Inheritance1
{
   public void main()
   {
       Console.WriteLine("this is child");
   }

   static void Main(string[] args)
   {
       child sc= new child();
       sc.main();
       sc.Home();
   }
}


