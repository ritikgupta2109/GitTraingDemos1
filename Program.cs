using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Test obj = new Test();

            Console.WriteLine("Enter the number 1");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the number 2");

            int num2 = Convert.ToInt32(Console.ReadLine());

            obj.divide(num1, num2);
        }

    }
}
    

