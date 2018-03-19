//Author: José Aurelio Quezada Alvarez
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreator1 : Creator
    {
        //A simple implementation of factory method
        public override Product FactoryMethod()
        {
            return new ConcreteProduct1();
        }

        public void SpecificConcreteCreator1Method()
        {
            Console.WriteLine("Hi, this is a simple method in ConcreteCreator1 class");
        }
    }
}
