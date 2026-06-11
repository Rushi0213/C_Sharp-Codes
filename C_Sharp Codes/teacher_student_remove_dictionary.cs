//using System;
//using System.Collections.Generic;
//using System.Text;



//class program
//{
//    public void detail()
//    {
//        Dictionary<Int32, String> dic = new Dictionary<Int32, String>();

//        dic.Add(11, "rushi");
//        dic.Add(12, "ram");
//        dic.Add(13, "shyam");
//        dic.Add(14, "raju");


//        Console.WriteLine("key vaue list");
//        Console.WriteLine();

//        foreach (var i in dic)
//        {
//            Console.WriteLine(i);
//        }

//        Console.WriteLine("enter the key for deleting by Teacher");
//        Int32 num = Convert.ToInt32(Console.ReadLine());

//        if (dic.ContainsKey(num))
//        {
//            dic.Remove(num);
//        }

//        else
//        {
//            Console.WriteLine("key not found");
//        }

//        Console.WriteLine();
//        Console.WriteLine("after reomving key value");

//        foreach (var i in dic)
//        {
//            Console.WriteLine(i);
//        }


//        //find the index of value like rushi

//        for(int i=0; i<dic.Count; i++)
//        {
//            if (dic[i]=="rushi")
//            {
//                Console.WriteLine("index of rushi"+i);
//            }
//        }
//    }
//}
//class teacher_student_remove_dictionary
//{
//    static void Main(string[] args)
//    {
//        program p = new program();

//        Thread t = new Thread(p.detail);

//        t.Start();
//    }
//}

