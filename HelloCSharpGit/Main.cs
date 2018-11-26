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
