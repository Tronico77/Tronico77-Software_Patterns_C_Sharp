using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreator2 : Creator
    {
        //A simple implementation of factory method
        public override Product FactoryMethod()
        {
            return new ConcreteProductN();
        }
    }
}
