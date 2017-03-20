using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    abstract class Builder
    {
        public abstract void BuildPartA();
        public abstract void BuildPartB();
        public abstract void BuildPartC();
        public abstract Product GetResult();
    }

    class ConcreteBuilder : Builder
    {
        Product product = new Product();

        public override void BuildPartA()
        {
            product.Add("Part A");
        }

        public override void BuildPartB()
        {
            product.Add("Part B");
        }

        public override void BuildPartC()
        {
            product.Add("Part C");
        }

        public override Product GetResult()
        {
            return product;
        }
    }
}
