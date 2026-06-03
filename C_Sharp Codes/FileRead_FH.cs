//using System;
//using System.Collections.Generic;
//using System.Text;


//class FileRead_FH
//{
//    void read()
//    {
//        string path = "D:\\VisualStudio\\Csharp\\Csharp_programing\\Csharp_programing\\newfile_FH.txt";
//        FileStream fs = new FileStream(path, FileMode.OpenOrCreate);

//        StreamReader sr = new StreamReader(fs);
//        string alldata = sr.ReadToEnd();
//        Console.WriteLine("data read done !");
//        Console.WriteLine("the data is :");
//        Console.WriteLine(alldata);
//        sr.Close();
//        fs.Close();

//    }
//    static void Main(string[] args)
//    {
//        FileRead_FH fh = new FileRead_FH();
//        fh.read();
//    }
//}

