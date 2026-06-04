using System;
using System.Collections.Generic;
using System.Text;


  class FileCreate_FileHnadling
   {
   void myfile()
   {
       

       string path = "D:\\VisualStudio\\Csharp\\Csharp_programing\\Csharp_programing\\wednesday.txt";
       File.Create(path);
       if(File.Exists(path) )
       {
           Console.WriteLine("file created succesfully");
       }
       else
       {
           Console.WriteLine("file created failed");
       }
   }

   static void Main(string[] args)
   {
       FileCreate_FileHnadling sc= new FileCreate_FileHnadling();
       sc.myfile();
   }

}

