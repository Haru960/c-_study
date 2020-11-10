using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            B test = new B();
            test.Print();
            test.PrintB();
        }
    }

    interface IA
    {
        void Print();
    }
    interface IB
    {
        void PrintB();
    }
    class B : IA,IB
    {
        public void Print()
        {
            Console.WriteLine("AAAAAAAAAAA!");
        }

        public void PrintB()
        {
            Console.WriteLine("BBBBBBBBBBBBBBB!");
        }
    }
}
