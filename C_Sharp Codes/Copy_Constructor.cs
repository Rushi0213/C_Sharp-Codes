using System;
using System.Collections.Generic;
using System.Text;




class Copy_Constructor
{
   int mid;
   string mname;
   long mphno;
   string password;

   Copy_Constructor(int mid,string mname, long mphno,string password)
   {
       this.mid = mid;
       this.mname = mname;
       this.mphno = mphno;
       this.password = password;
   }
   Copy_Constructor(Copy_Constructor c)
   {
       this.mid=c.mid;
       this.mname=c.mname;
       this.mphno=c.mphno;
       this.password=c.password;
   }

   
    
   static void Main(string[] args)
   {

       Copy_Constructor mn = new Copy_Constructor(23, "ramesh", 4567855,"ramesh@123");
       Console.WriteLine("manager details");
       Console.WriteLine();
       Console.WriteLine("manage id is :"+mn.mid);
       Console.WriteLine("manager name is :"+mn.mname);
       Console.WriteLine("manager phone is :"+mn.mphno);
       Console.WriteLine("manager password is :"+mn.password);
       Console.WriteLine();

       Console.WriteLine("------------------copy constructor----------------");
       Console.WriteLine();
       Console.WriteLine("copy of manager details");
       Console.WriteLine();
       Copy_Constructor mn2= new Copy_Constructor(mn);
       Console.WriteLine("copy mid is :"+mn2.mid);
       Console.WriteLine("copy mname is :"+mn2.mname);
       Console.WriteLine("copy mphno is :"+mn2.mphno);
       Console.WriteLine("copy mpassword is :"+mn2.password);
   }

}

