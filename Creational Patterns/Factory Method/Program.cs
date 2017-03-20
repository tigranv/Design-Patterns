namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            Creator creator = null;
            Product product = null;

            creator = new ConcreteCreator();
            product = creator.FactoryMethod();

            creator.AnOperation();
        }
    }
}
