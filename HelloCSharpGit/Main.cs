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
            //Debug.WriteLine("kimi");
            //Console.WriteLine("ralf");

            EncapsulationTest et = new EncapsulationTest();
            et.DisplayParams();

            Console.WriteLine();

            et.team = "McLaren";
            et.rpm = 18200;

            et.DisplayParams();
            Console.WriteLine();

            et.SetParams("Williams",19000);
            et.DisplayParams();

            EncapsulationTest et2 = new EncapsulationTest();
            et2.DisplayParams();

            Console.WriteLine();

            TestName.EncapsulationTest et3 = new TestName.EncapsulationTest();
            et3.Display();
            et3.SetParams("Kimi",140);
            et3.Display();

        }
    }
}
