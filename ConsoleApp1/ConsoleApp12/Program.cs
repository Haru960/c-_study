using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    delegate void ThereisFire(string location);
    class Program
    {
        static void Main(string[] args)
        {
            Firestation fs = new Firestation();
            ThereisFire fire = new ThereisFire(fs.Call119); 
            fire += fs.ShotOut;
            fire += fs.Escape;
            fire("집");
        }
    }
    class Firestation
    {
        public void Call119(string location)
        {
            Console.WriteLine("소방서죠? 불났어요! 주소는 {0}", location);
        }
        public void ShotOut(string location)
        {
            Console.WriteLine("피하세요! {0}에 불이 났어요!", location);
        }
        public void Escape(string location)
        {
            Console.WriteLine("{0}에서 나갑시다!", location);
        }
    }
}
