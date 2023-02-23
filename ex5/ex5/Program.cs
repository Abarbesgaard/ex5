using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

namespace ex5
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
          
            Bil renault = new Bil();

            Console.WriteLine(renault.Fart(100));
            Console.ReadLine();
        }
    }

    public class Bil
    {
        
        private int speed = 0;
        private int doors = 4;


        public int Fart(int a)
        {
            speed = a;
            return speed;
        }

    }

    


}