using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            A test1 = new A();
            B test2 = new B();

            test1.EventHandler += new DelegateType(test2.PrintA);
            test1.EventHandler += new DelegateType(test2.PrintB);
            test1.Func("Good!!!");
            test1.EventHandler -= test2.PrintB;
            test1.Func("Hi~~!");
            test1.EventHandler -= test2.PrintA;

            test1.EventHandler += test2.PrintA;
            test1.EventHandler += test2.PrintB;

            test1.Func("Hello World!");
        }
    }

    delegate void DelegateType(string Message);
    class A
    {
        public event DelegateType EventHandler;

        public void Func(string Message)
        {
            EventHandler(Message);
        }
    }
    class B
    {
        public void PrintA(string Message)
        {
            Console.WriteLine(Message);
        }
        public void PrintB(string Message)
        {
            Console.WriteLine(Message);
        }
    }
}
