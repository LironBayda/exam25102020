using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rational a=new Rational (2,5);
            Rational b = new Rational(1, 5);

            Rational c = a + b;
            Console.WriteLine(c.ToString());

             c = a - b;
            Console.WriteLine(c.ToString());

             c = a * b;
            Console.WriteLine(c.ToString());

            Console.WriteLine(a.GreaterThen(b));

            Console.WriteLine(a.Equals(b));

            Console.ReadLine();


        }
    }
}
