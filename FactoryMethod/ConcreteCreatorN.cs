//Author: José Aurelio Quezada Alvarez

using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    class ConcreteCreatorN : Creator
    {
        //A simple implementation of factory method
        public override Product FactoryMethod()
        {
            return new ConcreteProductN();
        }
    }
}
