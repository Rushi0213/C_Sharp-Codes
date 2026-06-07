using System;
using System.Collections.Generic;
using System.Text;


//multiple inheritance

interface Animal//interface class
{
   void Eat();
}
interface Pet//interface class
{
   void Play();
}

class Dog : Animal, Pet// inherite interface class
{
   public void Bark()// simple method
   {
       Console.WriteLine("dog is barking");
   }
   public void Eat()//animal interface method
   {
       Console.WriteLine("dog is eating");
   }
   public void Play()//pet interface method
   {
       Console.WriteLine("dog is playing");
   }

}

class multiple_inheritance_interface
{

   static void Main(string[] args)
   {
       Dog d = new Dog();//created object of chid class of both interface
       d.Bark();
       d.Eat();
       d.Play();
   }



}

