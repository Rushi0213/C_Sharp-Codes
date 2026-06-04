using System;
using System.Collections.Generic;
using System.Text;

using System;

// ABSTRACTION
abstract class Animal
{
   // ENCAPSULATION (private  property)
   private string Name;

   public abstract void Sound();

   public void setname(string Name)
   {
       this.Name = Name;
   }

   public string getname()
   {
       return Name;
   }

   // Abstract method
   

   
}

// inheritance and polymorphism
class Dog : Animal
{
   public override void Sound()
   {
        
       Console.WriteLine(getname()+ " is Barking");
   }
}

class All_Oops
{
   static void Main()
   {
       // Object of child class
       Dog d = new Dog();

       // Encapsulation (set value)
       d.setname("tommy");

       // Encapsulation (get output)
       Console.WriteLine("name is "+d.getname());

       d.Sound(); //call polymorphism
          
   }
}
