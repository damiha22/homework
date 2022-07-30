using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class sweet:Rice
    {
        public override int Eat(int carbohydrate)
        {
            Console.WriteLine("eat sweetpotato-rice");
            base.Eat(carbohydrate);

            return carbohydrate*2;
        }

        public override int Noteat(int empty)
        {
            Console.WriteLine("Don't eat sweetpotato-rice");
            base.Noteat(empty++);

            return empty/2;
        }
    }
}
