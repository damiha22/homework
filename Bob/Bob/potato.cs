using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class potato : Rice
    {
        public override int Eat(int carbohydrate)
        {
            Console.WriteLine("eat potato-rice");
            base.Eat(carbohydrate);

            return carbohydrate;
        }

        public override int Noteat(int empty)
        {
            Console.WriteLine("Don't eat potato-rice");
            base.Noteat(++empty);

            return empty;
        }


    }
}
