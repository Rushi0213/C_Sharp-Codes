//using System;
//using System.Collections.Generic;
//using System.Text;




//class Tri_rec_cir_squ_methodOverloading
//{


//    //this is the area of triangle method
//    public void Area(float bridth,float height)
//    {
//        float area =0.5f* bridth * height;
//        Console.WriteLine("area of triangle is: " + area);
//    }

//    //this is the area of square method
//    public void Area(int side)
//    {
//       int area = side*side;
//        Console.WriteLine("area of square is: " + area);
//    }

//    //this is the area of circle method
//    public void Area(double radius)
//    {
//       double  area = 3.14*radius*radius;
//        Console.WriteLine("area of circle is: " + area);
//    }

//    //this is area of rectangle method
//    public void Area(int width, int length)
//    {
//        int area =length*width;
//        Console.WriteLine("area of rectangle is: "+area);

//    }

//    static void Main(string[] args)
//    {
//        Tri_rec_cir_squ_methodOverloading sc= new Tri_rec_cir_squ_methodOverloading();

//        sc.Area(10f,5f);//cal the triangle

//        Console.WriteLine("enter the size of square");
//        int square=Convert.ToInt32(Console.ReadLine());
//        sc.Area(square);//call the square
//        sc.Area(5.5);// call the circle
//        sc.Area(10,5);// call the rectangle
        
//    }
//}

