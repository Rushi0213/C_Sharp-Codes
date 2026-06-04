using System;
using System.Collections.Generic;
using System.Text;



class EligibleException:Exception
{
   public EligibleException(string msg):base(msg)
   {

   }
}
    class CustomException
   {
   static void Main(string[] args)
   {
       Console.WriteLine("enter your age");
       int age=Convert.ToInt32(Console.ReadLine());

       if(age>=18)
       {
           Console.WriteLine("you are eligible for vote");
       }
       else
       {
          throw new EligibleException("you are not eligible for vote");
       }
   }
}

