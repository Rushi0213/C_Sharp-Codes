using System;
using System.Collections.Generic;
using System.Text;


    class Multiple_tyr_catch
    {
    static int c;
    static void Main(string[] args)
    {
        int a = 10;
        int b = 0;
        

        string name = null;

        try
        {

            int count=name.Length;//nullreference exception
            c = a / b;//dividebyzeroexception
  
        }

        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    //    try
    //    {
    //        Console.WriteLine("name is :"+name);
    //    }
    //    catch(Exception f)
    //    {
    //        Console.WriteLine(f);
    //    }
    //}
}

