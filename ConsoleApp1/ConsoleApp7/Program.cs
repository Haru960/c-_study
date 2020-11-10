using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            a.method(new B());
            a.method(new C());
        }
    }
    class A
    {
        public void method(I i)
        {
            i.method();
        }
    }
    interface I
    {
        void method();
    }
    class B : I
    {
        public void method()
        {
            Console.WriteLine("B클래스의 메서드");
        }
    }
    class C : I
    {
        public void method()
        {
            Console.WriteLine("C클래스의 메서드");
        }
    }

}
