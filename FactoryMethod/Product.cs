//Author: José Aurelio Quezada Alvarez
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public abstract class Product
    {
        //Some atributes
        private int attribute1;
        private string attributeN;

        //The corresponding properties
        public int Attribute1
        {
            get { return attribute1; }
            set { attribute1 = value; }
        }
        public string AttributeN
        {
            get { return attributeN; }
            set { attributeN = value; }
        }

        //The default constructor
        public Product()
        {
            this.Attribute1 = 0;
            this.AttributeN = String.Empty;
        }

        //Some methods
        public void Method1()
        { Console.WriteLine("Hello, this is the simple Method1 defined in the Product class"); }

        public void MethodN()
        { Console.WriteLine("Hello, this is the simple MethodN defined in the Product class"); }

        //Some abstract methods
        public abstract void AbstractMethod1();
        public abstract void AbstractMethodN();       
        
    }
}
