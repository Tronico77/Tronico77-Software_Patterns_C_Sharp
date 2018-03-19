using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Creator
    {
        //Some methods
        public void SomeMethod()
        { Console.WriteLine("Hello, this is some method defined in the Creator class"); }

        public void AnotherMethod()
        { Console.WriteLine("Hello, this is another method defined in the Creator class"); }
        
        //The FactoryMethod
        public abstract Product FactoryMethod();        
    }
}
