namespace Factory_Method
{
    abstract class Creator
    {
        Product product;

        public abstract Product FactoryMethod();

        public void AnOperation()
        {
            product = FactoryMethod();
        }
    }

    class ConcreteCreator : Creator
    {
        public override Product FactoryMethod()
        {
            return new ConcreteProduct();
        }
    }
}
