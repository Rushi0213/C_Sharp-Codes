using System;
using System.Collections.Generic;
using System.Text;


class streamWriter_FH
{

   void show()
   {
       string path = "D:\\VisualStudio\\Csharp\\Csharp_programing\\Csharp_programing\\newfile_FH.txt";
       FileStream fs = new FileStream(path, FileMode.Create);

       StreamWriter sw = new StreamWriter(fs);

       sw.WriteLine("today is wednesday");
       sw.Write("happy wednesday");
       sw.Close();
       fs.Close();
       Console.WriteLine("file writed succesfully");
   }

   static void Main(string[] args)
   {
       streamWriter_FH s = new streamWriter_FH();
       s.show();
   }
}

