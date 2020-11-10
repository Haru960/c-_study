using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            A mT = new A();

            for(int i = 0; i < 4; i++)
            {
                char ch2 = (char)(65+i);

                mT[i] = ch2+"";
            }

            mT.Print();
            mT[1] = "Hello World!";
            mT.Print();
        }
    }
    class A
    {
        ArrayList list = new ArrayList();
        public string this[int index]
        {
            get
            {
                if (0 <= index && index < list.Count)
                {
                    return (string)list[index];
                }
                else
                {
                    return null;
                }
            }
            set
            {
                if (0 <= index && index < list.Count)
                {
                    list[index] = value;
                }
                else if (index == list.Count)
                {
                    list.Add(value);
                }
            }
        }
        public void Print()
        {
            foreach (string m in list)
            {
                Console.WriteLine(m);
            }
        }
    }
}
