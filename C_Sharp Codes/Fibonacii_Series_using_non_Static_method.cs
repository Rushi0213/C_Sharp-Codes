//using System;
//using System.Collections.Generic;
//using System.Runtime.Intrinsics.Arm;
//using System.Text;


//class Fibonacii_Series_using_non_Static_method
//{

//    void fibonaci(int num,int a, int b)
//    {
//        int c;

//        for (int i = 0; i < num; i++)
//        {
//            Console.WriteLine(a);
//            c = a + b;
//            a = b;
//            b = c;


//        }
//    }
//    public static void Main(string[] args)
//    {
//        Fibonacii_Series_using_non_Static_method sc = new Fibonacii_Series_using_non_Static_method();

//        Console.WriteLine("enter limit");
//        int num = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter the vslue of a");
//        int m = Convert.ToInt32(Console.ReadLine());

//        Console.WriteLine("enter the the value of b");
//        int n = Convert.ToInt32(Console.ReadLine());

//        sc.fibonaci(num,m,n);

//    }
//}

