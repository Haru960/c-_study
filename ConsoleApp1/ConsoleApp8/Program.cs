using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            MyClass st = new MyClass();
            st.Name = "Microsoft C#";
            st.Number = 9;
            Console.WriteLine($"{st.Name} {st.Number}");
            st.Number = -7;
            Console.WriteLine($"{st.Name} {st.Number}");

        }
    }
    class MyClass
    {
        private string name;
        private int number;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public int Number
        {
            get { return number; }
            set { 
                if(value < 0 || 9 < value)
                {
                    number = 0;
                }
                else
                {
                    number = value;
                }
            }
        }
    }
}
