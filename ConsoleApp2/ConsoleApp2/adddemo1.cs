using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public class adddemo1
    {
        public int add1(int a, int b)
        {

            int c = a + b;
            Console.WriteLine(c);

            return c;
        }


    }

    class A1
    {
        const int i=100 ;
        readonly int j = 200;
        int studentNo;

        A1()
        {
            //i = 200;
            j = 400;
        }
        public void setStudentNo(int sno)
        {
           
            studentNo = sno;
        }
        public int getStudentNo()
        {
            return studentNo;
        }

        public A1()
        {
            setStudentNo(100);

            Console.WriteLine("Default constructor");
        }


        public A1(int i)
        {
            this.i = i;
            Console.WriteLine("Parmeter constructor");
        }
        public void add()
        {
            Console.WriteLine(i);
            int sno = getStudentNo();
        }
    }

    class P1
    {
        public void H1()
        {
            Console.WriteLine("Welcome");
        }
    }
    class P2 : P1
    {
        public void H2()
        {
            Console.WriteLine("Hi");

            int a = 10;
            int b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch(Exception e)
            { 
            }
           
        }

    }


}