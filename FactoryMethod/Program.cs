using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is just an example to show how to create concrete product objects with the FactoryMethod            

            ConcreteCreator1 creatorObject = new ConcreteCreator1();
            
            //A call to an inherited method
            creatorObject.SomeMethod();

            //A call to a specific Concrete Creator1 method 
            creatorObject.SpecificConcreteCreator1Method();
                        

            ConcreteProduct1 concreteProduct1 = (ConcreteProduct1)creatorObject.FactoryMethod();
            concreteProduct1.Method1();
            concreteProduct1.SpecificConcreteProduct1Method();
        }
    }
}
