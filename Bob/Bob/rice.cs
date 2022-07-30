using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Rice : Koreanfood
    {
        int carbohydrate;
        int empty;

        Rice()
        {

        }
        public override int Eat(int carbohydrate)
        {
            return carbohydrate;
        }

        public override int Noteat(int empty)
        {
            return empty;
        }
    }
}
