using System;
using System.Collections.Generic;
using System.Text;


   abstract class EmployeeAbstract
   {
   public abstract void employeee();
   public void salary()
   {
       Console.WriteLine("the salary is 50000");
   }
}

class employee:EmployeeAbstract
{
   public override void employeee()
   {
       Console.WriteLine("employeee id is 45678");
   }

   //public void salary()
   //{
   //    Console.WriteLine("employee salary is 50000");
   //}
}
class main
{
   static void Main(string[] args)
   {
       employee e= new employee();
       e.employeee();
   }
}

