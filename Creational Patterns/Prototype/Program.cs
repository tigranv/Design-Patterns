namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Prototype prototype = null;
            Prototype original = null;

            prototype = new ConcretePrototype1(1);
            original = prototype.Clone();

            prototype = new ConcretePrototype2(2);
            original = prototype.Clone();
        }
    }
}
