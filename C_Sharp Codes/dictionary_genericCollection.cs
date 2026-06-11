//using System;
//using System.Collections.Generic;
//using System.Text;


//    class dictionary_genericCollection
//    {

//    public void details()
//    {
//        Console.WriteLine("company info");

//        Dictionary<Int32,String> dic = new Dictionary<Int32,String>();

//        dic.Add(1, "microsoft");
//        dic.Add(2, "google");
//        dic.Add(3, "amazon");
//        dic.Add(4,"cognizant");
        


//        foreach (var  v in dic)
//        {
//            Console.WriteLine("first loop");
//            Console.WriteLine(v);
//            Thread.Sleep(1000);
//        }

//        Console.WriteLine("conatians key: " + dic.ContainsKey(1));
//        Console.WriteLine("contain value :"+dic.ContainsValue("amazon"));
//        Console.WriteLine();
     
//        dic.Remove(2);

//        foreach (var v in dic)
//        {
//            Console.WriteLine("second loop");
//            Console.WriteLine(v);
//            Thread.Sleep(1000);
//        }
//    }
//    static void Main(string[] args)
//    {
//        dictionary_genericCollection d= new dictionary_genericCollection();
//        d.details();
//    }
//}

