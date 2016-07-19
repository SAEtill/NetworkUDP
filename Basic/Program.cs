using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic
{
    class Program
    {
        static int Main(string[] args)
        {
            Thread.Sleep(1000); 
            Console.WriteLine( "foo " + String.Join(" :: " ,  args ) );

            Thread.Sleep(3000);
            return 1; 
        }
    }
}
