using System;
using System.Collections.Generic;
using System.Text;


    class ThisKeyword
   {

   int num;
   void displayvalue(int num)
   {
       this.num = num;//use this keyword when variable of instace and parameter variable are same
       Console.WriteLine("inside method");
       Console.WriteLine("number is: "+num);
   }
   static void Main(string[] args)
   {
       ThisKeyword t=new ThisKeyword();
       t.displayvalue(100);
       Console.WriteLine("using object access this value");
       Console.WriteLine("number is:"+t.num);
   }

}


