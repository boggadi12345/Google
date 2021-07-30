using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class inheritance1
    {
    }
    class A
    {
        public void M1()
        {
            Console.WriteLine("A M1");
        }
        public void M2()
        {
            Console.WriteLine("A M2");
        }

    }
    class B : A
    {
        public void M3()
        {
            Console.WriteLine("B M3");
        }
        public void M2()
        {
            Console.WriteLine("B M2");
        }
    }
}
     