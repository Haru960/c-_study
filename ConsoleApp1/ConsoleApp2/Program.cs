using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            B test = new B(3);
            test.PrintA();
            test.PrintB();
        }
    }
    class A
    {
        int number;
        protected string name = "Hello";
        public A(int num)
        {
            number = num;
        }

        public void PrintA()
        {
            Console.WriteLine(number);
        }
    }

    class B : A
    {
        string name = "world";
        public B(int num) : base(num)
        {

        }
        public void PrintB()
        {
            Console.WriteLine("{0} {1}", base.name, name);
        }
    }

}
