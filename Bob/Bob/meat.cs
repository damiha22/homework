using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class meat:Side
    {
        public override int Eat(int calorie)
        {
            Console.WriteLine("eat Meat.");
            base.Eat(calorie);

            return calorie/2;
        }

        public override int Noteat(int happy)
        {
            Console.WriteLine("Don't eat Meat.");
            base.Noteat(happy);

            return happy;
        }
    }
}
