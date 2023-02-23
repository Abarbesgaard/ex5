namespace Lommeregner
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
             double result = 0;
             string operatorInput = " ";
             Calculator nyCal = new Calculator();

            do
            {
                start:
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("My fantastic Calculator");
                Console.WriteLine();
                Console.WriteLine("pick a number X, any number: ");
                double x = double.Parse(Console.ReadLine());

                Console.WriteLine("pick a number Y, any number: ");
                double y = double.Parse(Console.ReadLine());
                Console.WriteLine("you picked " + x + " and " + y);
                
                Console.ForegroundColor= ConsoleColor.White;
                Console.ForegroundColor= ConsoleColor.Yellow;   
                Console.WriteLine("pick an operator: ");
                Console.WriteLine("add: + ");
                Console.WriteLine("subtract: - ");
                Console.WriteLine("Divide: / ");
                Console.WriteLine("Multiply: * ");
                Console.ForegroundColor = ConsoleColor.White;

                string brugerOperatorInput = Console.ReadLine();

                switch(brugerOperatorInput)
                {
                    case "+":
                        result = nyCal.Add(x, y);
                        operatorInput = "+";
                            break;
                    case "-":
                        result = nyCal.Subtract(x, y);
                        operatorInput = "-";
                        break;
                    case "/":
                        result = nyCal.Divide(x, y);
                        operatorInput = "/";
                        break;
                    case "*":
                        result = nyCal.Multiply(x, y);
                        operatorInput = "*";
                        break;
                    default:
                        goto start;
                }

                Console.WriteLine("udregningen er: " + x + operatorInput + y) ;
                Console.WriteLine(result);
                Console.ReadLine();
                Console.Clear();
            }
            while (Console.ReadLine() != "0");


            //Console.Write("add: ");
            //Console.WriteLine(nyCal.Add(3, 2));

            //Console.Write("Sub: ");
            //Console.WriteLine(nyCal.Subtract(3, 2));

            //Console.Write("divide: ");
            //Console.WriteLine(nyCal.Divide(10, 3));

            //Console.Write("multiplication: ");
            //Console.WriteLine(nyCal.Multiply(5,5));

            //Console.ReadLine();
        }
    }
}