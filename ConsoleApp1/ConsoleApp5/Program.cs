using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            B test2 = new B();
            test2.Print();
            test2.PrintNumber();
        }
    }

    abstract class A
    {
        int number = 3;
        public abstract void Print();
        public void PrintNumber()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("abstract class");
        }
    }
}
