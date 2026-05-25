using System;
using System.Collections.Generic;
using System.Text;


    class multiple_employee_class_object
    {

    string empemail;
    int empsalary;

    void employee1()
    {
        Console.WriteLine("this is first employee");
    }
    void employee2()
    {
        Console.WriteLine("this is second employee");
    }
    void employee3()
    {
        Console.WriteLine("this is third employee");
    }
    static void Main(string[] args)
    {
        multiple_employee_class_object em1= new multiple_employee_class_object();
        em1.empemail= Console.ReadLine();
        em1.empsalary=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the fisrt employee email is "+em1.empemail+"and salary is"+em1.empsalary);
        em1.employee1();

        multiple_employee_class_object em2 = new multiple_employee_class_object();
        em2.empemail = Console.ReadLine();
        em2.empsalary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the fisrt employee email is " + em2.empemail + "and salary is" + em1.empsalary);

        multiple_employee_class_object em3 = new multiple_employee_class_object();
        em3.empemail = Console.ReadLine();
        em3.empsalary = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("the fisrt employee email is " + em3.empemail + "and salary is" + em3.empsalary);

    }
}

