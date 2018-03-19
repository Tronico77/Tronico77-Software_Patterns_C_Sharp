using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProduct1 : Product
    {
        //The overridden methods
        public override void AbstractMethod1()
        { Console.WriteLine("Hello, this is the concrete product1 class AbstractMethod1"); }

        public override void AbstractMethodN()
        { Console.WriteLine("Hello, this is the concrete product1 class AbstractMethodN"); }

        //A specific ConcreteProduct1 method 
        public void SpecificConcreteProduct1Method()
        {
            Console.WriteLine("Hi, this is a specific method in ConcreteProduct1 class");
        }

    }
}
