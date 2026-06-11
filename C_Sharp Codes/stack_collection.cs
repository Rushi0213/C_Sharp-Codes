//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Text;


//class program
//{

//    //stack is the (last in first out) method in collection
//    public void details()
//    {
//        Stack c= new Stack();
//        c.Push("rushi");
//        c.Push("ram");
//        c.Push("shyam");
//        c.Push("raju");

//        Console.WriteLine(" name of studnet");
//        foreach(var i in c)
//        {
//            Console.WriteLine(i);
//        }
//        Console.WriteLine();

//        c.Pop();//removing elment from stack

//        Console.WriteLine("after removing student");
//        foreach (var i in c)
//        {
//            Console.WriteLine(i);
//        }

//        c.Pop();
//        Console.WriteLine();
//        Console.WriteLine("again removing one more");
//        foreach (var i in c)
//        {
//            Console.WriteLine(i);
//        }
//    }
//}
//     class stack_collection
//    {

    
//    static void Main(string[] args)
//    {
//        program p= new program();

//        Thread t = new Thread(p.details);
      
//        t.Start();
//    }
//}

