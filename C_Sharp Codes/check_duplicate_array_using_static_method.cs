//using System;
//using System.Collections.Generic;
//using System.Text;


//class check_duplicate_array_using_static_method
//{

//    static void array(int[] arr)
//    {
//        int flag = 0;

//        for(int i=0;i<arr.Length;i++)
//        {
//            for(int j=i+1;j<arr.Length;j++)
//            {
//                if (arr[i] == arr[j])
//                {
//                    flag++;
//                }
//            }
//        }
//        if(flag == 0)
//        {
//            Console.WriteLine("no duplicate");
//        }
//        else
//        {
//            Console.WriteLine("duplicate");
//        }

//    }
//    static void Main(string[] args)
//    {
//        //check_duplicate_array_using_static_method sc = new check_duplicate_array_using_static_method();

//        Console.WriteLine("enter array size");
//        int size = Convert.ToInt32(Console.ReadLine());

//        int[] arr = new int[size];

//        Console.WriteLine("enter array element");
//        for (int i = 0; i < arr.Length; i++)
//        {
//            arr[i] = Convert.ToInt32(Console.ReadLine());
//        }

//        array(arr);

//    }

//}

