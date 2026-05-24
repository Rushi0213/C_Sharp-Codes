using System;
using System.Collections.Generic;
using System.Text;

namespace Csharp_programing
{
    internal class callByReference
    {
        static void referece( ref int x)
        {
            x++;
            Console.WriteLine("value is:"+x);
        }
        static void Main(string[] args)
        {
            int a = 10;
            Console.WriteLine("before passing value:"+a);
            referece( ref a);
            Console.WriteLine("after passing value:"+a);
        }
    }
}
