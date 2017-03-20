using System;

namespace Factory_Method
{
    abstract class Product
    {
    }

    class ConcreteProduct : Product
    {
        public ConcreteProduct()
        {
            Console.WriteLine(this.GetHashCode());
        }
    }
}
