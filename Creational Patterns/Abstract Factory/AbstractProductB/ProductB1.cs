using System;

namespace Abstract_Factory
{
    class ProductB1 : AbstractProductB
    {
        public override void Interact(AbstractProductA apa)
        {
            Console.WriteLine(this + " interacts with " + apa);
        }
    }
}
