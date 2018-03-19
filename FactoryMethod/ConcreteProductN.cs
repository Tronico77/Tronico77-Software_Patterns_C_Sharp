//Author: José Aurelio Quezada Alvarez
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteProductN : Product
    {
        //The overridden methods
        public override void AbstractMethod1()
        { Console.WriteLine("Hello, this is the concrete productN class AbstractMethod1"); }

        public override void AbstractMethodN()
        { Console.WriteLine("Hello, this is the concrete productN class AbstractMethodN"); }
    }
}
