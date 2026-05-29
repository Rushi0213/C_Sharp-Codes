using System;
using System.Collections.Generic;
using System.Text;


interface BankInterface
{
   public void bankbalance();


   public void bankloan();

   public void bankaccount();
   public void bankaccountloan()
   {
       Console.WriteLine("the loan on bank account loan is 234567");
   }

}


class bankinfo : BankInterface
{

   public void bankbalance()
   {

       Console.WriteLine("bankbalance is 60 rs");
   }
   public void bankloan()
   {
       Console.WriteLine("bankloan is  5000rs");
   }

   public void bankaccount()
   {
       Console.WriteLine("accountnumber is 1234567");
   }

   static void Main(string[] args)
   {
       bankinfo b = new bankinfo();
       b.bankbalance();
       b.bankloan();
       b.bankaccount();
       //b.bankaccountloan();
   }
}

