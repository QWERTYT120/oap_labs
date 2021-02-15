using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oap_labs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number6: ");
            var number6 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number9: ");
            var number9 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input number12: ");
            var number12 = Convert.ToDouble(Console.ReadLine());
            if (number6 >= 0)
            {
                number6 = Math.Pow(number6, 9);
            }
            else
            {
                number6 = Math.Pow(number6, 9);
            }
            if (number9 >= 0)
            {
                number9 = Math.Pow(number9, 9);
            }
            else
            {
                number9 = Math.Pow(number9, 12);
            }
            number9 = (number12 >= 0) ? Math.Pow(number12, 9) : Math.Pow(number12, 15);
            if (number9 >= 0)
            {
                number9 = Math.Pow(number12, 9);
            }
            else
            {
                number9 = Math.Pow(number12, 15);
            }
            Console.WriteLine($"number6 = {number6}");
            Console.WriteLine($"number9 = {number9}");
            Console.WriteLine($"number12 = {number12}");
            {
                /*
                /*
            
            }
    }
}
