using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bob
{
    class Program
    {
        void Main()
        {
            potato potatobob = new potato();
            sweet sweetpotatobob = new sweet();

            meat meat = new meat();
            kimchi Kimcchi = new kimchi();

            int carbohydrate, empty, happy, calorie;
            string name = "In Duk ee";

            carbohydrate = potatobob.Eat(10) + sweetpotatobob.Eat(10);

            empty = potatobob.Noteat(10) + sweetpotatobob.Noteat(10);

            calorie = meat.Eat(10) + Kimcchi.Eat(10);

            happy = meat.Noteat(10) + Kimcchi.Noteat(10);

            Console.WriteLine(name + happy + calorie + carbohydrate + empty);

            Console.ReadLine();
        }
    }
}

     