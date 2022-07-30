using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Side : Koreanfood
    {
        int calorie;
        int happy;

        Side()
        {

        }

        public override int Eat(int happy)
        {
            return happy;
        }

        public override int Noteat(int calorie)
        {
            return calorie;
        }


    }
}
