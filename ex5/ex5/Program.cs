using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ex5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            Console.WriteLine("");
        }
    }

    public class Calculator
    {       
        public int Add(int x, int y) 
        {
            return x + y;
        }
        public int Subtract(int x, int y) 
        {
            return x - y;
        }
        public double Divide(int x, int y) 
        { 
            return x / y; 
        }
        public int Multiply(int x, int y) 
        { 
            return x * y;
        }
    }

    


}