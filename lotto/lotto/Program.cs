using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lotto
{
    class program
    {
        static int[] Lotto = new int[5];
        static int[] inum = new int[5];
        static int score=6;

        static void Main()
        {
            rand_num();
            input_num();
            checking();
            print();
        }

        static void rand_num()
        {
            int i,j;

            Random rand = new Random();
            for (i = 0;i < Lotto.Length;i++)
            {
                Lotto[i] = rand.Next(1,49);
                for(j=0;j<i;j++)
                {
                    if (Lotto[j] == Lotto[i])
                    {
                        i--;
                        continue;
                    }
                }
            }
        }

        static void input_num()
        {
            int i,j;

            for(i=0;i<5;i++)
            {
                j = i + 1;
                Console.WriteLine("input " + j + "th number from 1 to 49");
;               inum[i] = int.Parse(Console.ReadLine());
                if (inum[i]<1 || inum[i]>49)
                {
                    i--;
                    continue;
                }
            }
        }

        static void checking()
        {
            int i, j;
            for (i = 0; i < 5; i++)
            {
                for (j = 0; j < 5; j++)
                {
                    if (Lotto[i] == inum[j])
                    {
                        score--;
                        continue;
                    }
                       
                }
            }
        }
        static void print()
        {
            if(score<6)
            {
                Console.WriteLine(score + "grade !!");
            }
            else
            {
                Console.WriteLine("Boom!!");
            }         
               
        }

    }
}


