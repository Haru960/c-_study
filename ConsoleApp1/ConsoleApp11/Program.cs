using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11
{
    delegate void DelegateType();
    class Program
    {
        static void Main(string[] args)
        {
            A delTest = new A();
            DelegateType DelMethod1 = new DelegateType(delTest.PrintA);
            DelMethod1 += delTest.PrintB;
            DelMethod1();
            Console.WriteLine();
            DelMethod1 -= delTest.PrintB;
            DelMethod1();
            Console.WriteLine();
        }
    }
    class A
    {
        public void Print(string str)
        {
            Console.WriteLine(str);
        }
        public void PrintA()
        {
            Console.Write(" PrintA ");
        }
        public void PrintB()
        {
            Console.Write(" PrintB ");
        }
    }
}
