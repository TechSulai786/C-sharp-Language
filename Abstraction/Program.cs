using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class animal
    {
        public abstract void animalsound();
        public void sleep()
        {
            Console.WriteLine("Zzz");
        }
    }

        class cat : animal
        {
        public override void animalsound()
        { 
                Console.WriteLine("This is a Tech Legend:");
            }
        }
      
    internal class Program
    {
        static void Main(string[] args)
        {
            cat obj = new cat();
            obj.animalsound();
            obj.sleep();
            Console.ReadLine();

        }
    }
}
