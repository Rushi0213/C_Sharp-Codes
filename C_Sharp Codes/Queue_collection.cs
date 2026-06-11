using System;
using System.Collections.Generic;//this is colection namespace
using System.Text;



class program
{
    public void details()
    {
        // in queue is (first in first out) method

        Queue<string> q = new Queue<string>();


        //inserting element in queue

        q.Enqueue("rushi");
        q.Enqueue("shyam");
        q.Enqueue("ram");
        q.Enqueue("raju");
        q.Enqueue("ravi");
        q.Enqueue("rushi");

        foreach(string s in q)
        {
            Console.WriteLine(s);
        }

        q.Dequeue();//removing element from queue

        Console.WriteLine("-----------------------");
        foreach(string i in q)
        {
            Console.WriteLine(i);
        }
    }
}
     class Queue_collection
    {
    static void Main(string[] args)
    {
     program p= new program();
        p.details();
    }
}

