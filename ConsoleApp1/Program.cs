using static System.Console;

namespace hw
{
    internal class Class1
    {
        static void Main()
        {
            int num1, num2, result;
            string op, answer;
            bool err=true;

            WriteLine("Input first number");
            num1 = int.Parse(ReadLine());

            do
            {
                do
                {
                    if (err == false)
                        WriteLine("Input error!! Select + - * /");
                    else
                        WriteLine("Select + - * /");
                    op = ReadLine();
                    err = op == "+" || op == "-" || op == "*" || op == "/";
                } while (!err);


                WriteLine("Input second number");
                num2 = int.Parse(ReadLine());

                switch (op)
                {
                    case "+":
                        result = num1 + num2;
                        break;
                    case "-":
                        result = num1 - num2;
                        break;
                    case "*":
                        result = num1 * num2;
                        break;
                    case "/":
                        result = num1 / num2;
                        break;
                    default:
                        result = 0;
                        break;
                }

                WriteLine(num1 + op + num2 + " = " + result);

                err = true;
                do
                {
                    if (err == false)
                        WriteLine("Input error!! continue? y/n");
                    else
                        WriteLine("continue? y/n");
                    answer = ReadLine();
                    err = answer == "y" || answer == "Y" || answer == "n" || answer == "N";
                } while (!err);

               
                num1 = result;
                err = true;

                
            } while (answer == "y" || answer == "Y");


               Console.ReadKey();
        }
    }
}
