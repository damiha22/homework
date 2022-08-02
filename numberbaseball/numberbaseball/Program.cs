using System;


namespace numberbaseball
{
    class Program
    {
        static int[] cell1 = new int[3];
        static string[] cell2 = { "O", "O", "O" };     

        static int[] g=new int[3];

        static int round = 1, Sc=0, Bc=0, Oc=0;

        public static void Main(string[] args)
        {
            Console.WriteLine("start number baseball");
            rand_num();

            do
            {
                guessing_num();
                checking();
                printing();
            }while(Sc < 3);

        }
        static void rand_num()
        {
            int n0, n1, n2;
            Random rand = new Random();
            n0=rand.Next(0,10);

           
            n1 = rand.Next(0,10);
            while(n0==n1)
            {
                n1 = rand.Next(0,10);
            }

           
            n2 = rand.Next(0,10);
            while(n1==n2||n2==n0)
            {
                n2 = rand.Next(0, 10);
            }

            cell1[0] = n0;
            cell1[1] = n1;
            cell1[2] = n2;
        }
        static void guessing_num()
        {
            string s1;

            Console.WriteLine("round : " + round);
            Console.WriteLine("Input 3 number simultaneously without blank");
            s1 = Console.ReadLine();
            g[0]= int.Parse (s1.Substring(0,1));
            g[1] = int.Parse(s1.Substring(1, 1));
            g[2] = int.Parse(s1.Substring(2, 1));           
           
        }


        static void checking()
        {
            int i, j;
            for (i = 0; i < 3; i++)
            {
                cell2[i] = "O";
            }

            for (i = 0; i < 3; i++)
            {
                for (j = 0; j < 3; j++)
                {
                    if (g[i] == cell1[j])
                    {
                        if (i == j)
                        {
                            cell2[i] = "S";                            
                        }
                        else
                            cell2[i] = "B";
                    }
                    else
                        continue;
                }
            }  
            round++;
        }

        static void printing()
        {
            int i;

            Sc = 0;
            Bc = 0;
            Oc = 0;

            for (i = 0; i < 3; i++)
            {
                switch (cell2[i])
                {
                    case "S":
                        Sc++;
                        break;
                    case "B":
                        Bc++;
                        break;
                    case "O":
                        Oc++;
                        break;
                    default:
                        break;
                }
            }
                       
            if (Sc == 3)
                Console.WriteLine("You're right!!!  Congratulation, And Game is over");
            else if (Oc == 3)
                Console.WriteLine("All number is wrong!! Out");
            else
                Console.WriteLine("You're woring S:" + Sc + "        B:" + Bc);


        }
    }
}
    
