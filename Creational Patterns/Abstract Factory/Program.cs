namespace Abstract_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Client client = null;

            client = new Client(new ConcreteFactory1());
            client.Run();

            client = new Client(new ConcreteFactory2());
            client.Run();
        }
    }
}
