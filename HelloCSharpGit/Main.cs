using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace HelloCSharpGit
{
    class MainClass
    {

        public void NonStaticTest()
        {
            Console.WriteLine("non-static method");
        }

        static public void Test()
        {
            Console.WriteLine("static method");
        }

        static void Main(String[] args)
        {
            int x=50;
            int y;
            MethodTest mt = new MethodTest();
            mt.GetOutput(x,out y);
            Console.WriteLine(y);

            mt.SwapInt(50,77);

            x = 31;
            y = 98;
            mt.SwapInt(x,y);
            Console.WriteLine("x="+x+",y={0}",y);
            mt.SwapIntRef(ref x,ref y);
            Console.WriteLine("x=" + x + ",y={0}", y);

            Test();

            Console.WriteLine("Recursive Method="+mt.TestRecursive(3,15));

            String s1 = "Milk";
            String s2 = "Coffee";
            string s3;
            string s4;
            s1 = "31";
            s2 = "13";
            Console.WriteLine("MultiOut="+mt.StringTogether(ref s1,ref s2,out s3,out s4));
            Console.WriteLine(s3+" "+s4);

            ////Debug.WriteLine("kimi");
            ////Console.WriteLine("ralf");

            //EncapsulationTest et = new EncapsulationTest();
            //et.DisplayParams();

            //Console.WriteLine();

            //et.team = "McLaren";
            //et.rpm = 18200;

            //et.DisplayParams();
            //Console.WriteLine();

            //et.SetParams("Williams",19000);
            //et.DisplayParams();

            //EncapsulationTest et2 = new EncapsulationTest();
            //et2.DisplayParams();

            //Console.WriteLine();

            //TestName.EncapsulationTest et3 = new TestName.EncapsulationTest();
            //et3.Display();
            //et3.SetParams("Kimi",140);
            //et3.Display();

            //Console.WriteLine("BYTE="+et3.GetByte());
            //et3.SetByte(127);
            //Console.WriteLine("BYTE="+et3.GetByte());

        }
    }
}
