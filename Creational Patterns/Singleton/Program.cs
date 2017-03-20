using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton instance1 = Singleton.Instance();
            Singleton instance2 = Singleton.Instance();
            Console.WriteLine(ReferenceEquals(instance1, instance2));

            instance1.SingletonOperation();
            string singletonData = instance1.GetSingletonData();
            Console.WriteLine(singletonData);
        }
    }
}
