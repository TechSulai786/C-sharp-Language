using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int name = 1;
            while(name<=5)
            {
                Console.WriteLine(name++);
                
            }
            Console.ReadLine();
        }
    }
}
