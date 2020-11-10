using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            A myTest = new A();
            for(int i = 0; i < 5; i++)
            {
                myTest[i] = i;
                Console.WriteLine(myTest[i]);
            }
        }
    }

    class A
    {
        private int[] number = new int[5];
        public int this[int index]
        {
            get { return number[index]; }
            set { number[index] = value; }
        }
    }
}
