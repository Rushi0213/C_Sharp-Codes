using System;
using System.Collections.Generic;
using System.Text;


   class Forgatepassword_Switchcase
   {
  public static void Main(string[] args)
   {
       Console.WriteLine("forgate password using another way");
       Console.WriteLine("enter methods");
       string options=Console.ReadLine();

       switch(options)
       {
           case "Email":
               Console.WriteLine("login by email");
               break;

           case "Phone":
               Console.WriteLine("login by phone");
               break;

           case "Aadhar":
               Console.WriteLine("login by Aadhar");
               break;


           default:
               Console.WriteLine("invalid options");
               break ;

       }
   }

}

