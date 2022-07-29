using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class printstar
    {
        static void Main()
        {
            string[,] cells = {
                {"*", " "," "," "," "},
                {"*", "*"," "," "," "},
                {"*", "*","*"," "," "},
                {"*", "*","*","*"," "},
                {"*", "*","*","*","*"}
            };      
            int i, j, k;

            for (i = 0; i <=4; i++)
            {
                for (j = 0; j <=4; j++)
                    Write(cells[i, j]);
                Write("\n");
            }

            Write("\n");

            for (i = 0; i <= 4; i++)
            {
                for (j = 4; j >= 0; j--)
                    Write(cells[i, j]);
                Write("\n");
            }

            Write("\n");

            for (i = 0; i <= 4; i++)
            {
                for (j = 4; j >=0; j--)
                    Write(cells[i, j]);
                for(k=1; k<=4; k++)
                    Write(cells[i, k]);
                Write("\n");
            }

            Write("\n");
            for (i = 0; i <= 4; i++)
            {
                for (j = 4; j >= 0; j--)
                    Write(cells[i, j]);
                for (k = 1; k <= 4; k++)
                    Write(cells[i, k]);
                Write("\n");
            }
            for (i = 3; i >= 0; i--)
            {
                for (j = 4; j >= 0; j--)
                    Write(cells[i, j]);
                for (k = 1; k <= 4; k++)
                    Write(cells[i, k]);
                Write("\n");
            }
        }
    }
}
