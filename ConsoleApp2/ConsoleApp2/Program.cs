using ConsoleApp2.Framework.Tests;
using System;

namespace ConsoleApp2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
           adddemo1 f3 = new adddemo1();
           //int res = f3.add1(10,20);

           // Console.WriteLine(res);

            A1 a = new A1(500);
            //a.add();

            LoopsDemo5 l9 = new LoopsDemo5();
            //l9.loops1();


            MouseHoverDemo33 m3 = new MouseHoverDemo33();
            //m3.MouseHover1();


            IrctcRegistration i1 = new IrctcRegistration();
            //i1.Irctc1();

            GmailRegistrationTest g5 = new GmailRegistrationTest();
            //g5.GmailReg();

            HandleAllertsDemo hs = new HandleAllertsDemo();
            //hs.HandleAllert();

            HandleTables h = new HandleTables();
            h.HandleTabl();
        }
    }
}
