//using System;
//using System.Collections.Generic;
//using System.Text;


//    class MethodOverloading
//    {
//      void billPayment()
//    {
//        Console.WriteLine("bill payment of electricity bill");
//    }
//    void billPayment(int amount)
//    {
//        Console.WriteLine("bill payment of waterbill");
//    }
//    void billPayment(string amount)
//    {
//        Console.WriteLine("bill payment of telephone bill");
//    }
//    void billPayment(int amount, string name)
//    {
//        Console.WriteLine("bill payment of credit card bill :"+" amount of bill is : "+amount+"  name of bill payer :"+name);
//    }

//    void billPayment(string name,int amount)
//    {
//        Console.WriteLine("bill payment of credit card bill :" + " amount of bill is : " + amount + "  name of bill payer :" + name);
//    }

//    static void Main(string[] args)
//    {
//        MethodOverloading m= new MethodOverloading();
//        m.billPayment();
//        m.billPayment(2000);
//        m.billPayment("20000");
//        m.billPayment(1000,"rushikesh");
//        m.billPayment("rushikesh",15000);
//    }
//}

