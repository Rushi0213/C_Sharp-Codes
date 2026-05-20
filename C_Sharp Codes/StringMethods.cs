using System;
using System.Collections.Generic;
using System.Text;


    class StringMethods
   {
   static void Main(string[] args)
   {
       string name = " Rushikesh ";
       Console.WriteLine("string is:"+name);
       Console.WriteLine("Touppercse:"+name.ToUpper());
       Console.WriteLine("tolower:"+name.ToLower());
       Console.WriteLine("replace:"+name.Replace('h','m'));
       Console.WriteLine("trim:"+name.Trim());
       Console.WriteLine("length:"+name.Length);
       Console.WriteLine("substrin:"+name.Substring(5));
       Console.WriteLine("index of charecter: "+name.IndexOf("k"));
       Console.WriteLine("contains:"+name.Contains("i"));
       Console.WriteLine("append:"+name.Append("is my name"));
       char[] arr = name.ToArray();
       for(int i=0;i<arr.Length;i++)
       {
           Console.WriteLine(arr[i]);
       }
   }
}

