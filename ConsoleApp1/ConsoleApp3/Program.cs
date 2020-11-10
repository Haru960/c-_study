using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            A test1 = new B();
            test1.Print();

            B test2 = new B();
            A test3 = (A)test2;
            test3.Print();

          
            A test5 = new A();
            B test6 = test5 as B;
            
            if(test6 == null)
            {
                Console.WriteLine("형변환 실패");
            }
            else
            {
                test6.Print();
            }
            
        }
    }
    class A
    {
        public virtual void Print()
        {
            Console.WriteLine("A Print");
        }
    }
    class B : A
    {
        public override void Print()
        {
            Console.WriteLine("B Print");
        }
        public void basePrintA()
        {
            base.Print();
        }
    }
}
