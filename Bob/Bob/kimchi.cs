using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class kimchi:Side
    {
        public override int Eat(int calorie)
        {
            Console.WriteLine("eat Meat.");
            base.Eat(calorie);

            return calorie;
        }

        public override int Noteat(int happy)
        {
            Console.WriteLine("Don't eat Meat.");
            base.Noteat(happy++);

            return happy;
        }
    }
}
