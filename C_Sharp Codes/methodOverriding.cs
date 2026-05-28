//using System;
//using System.Collections.Generic;
//using System.Text;


//class methodOverriding
//{
//    public  virtual void details()//parent class method,
// //used virtual keywork for calling parent class methodin child class in method overrinding
//    {
//        Console.WriteLine("established in 1994");
//    }
//}

//class employee : methodOverriding
//{
//    public override void details()// child class method,using override keyword
//    {
//        base.details();//call parent class method using override,with base keyword
//        Console.WriteLine("name is raj");
//    }
//}

//class intern :employee
//{
//    public override void details()
//    {
//        base.details();
//        Console.WriteLine(" ravi is intern ");
//    }
//}
//class main 
//{ 
  
//   public static void Main(string[] args)
//    {
//        intern e= new intern();
//        e.details();
//    }
//}

