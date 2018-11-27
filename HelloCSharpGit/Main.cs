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
            //ArraysHello ah = new ArraysHello();
            //Console.WriteLine(ah.k[0]);
            //Console.WriteLine(ah.l[3]);
            //Console.WriteLine(ah.m[2]);
            //ah.l[3] = 123;
            //Console.WriteLine(ah.l[3]);
            //Console.WriteLine("LENGTH="+ah.l.Length);
            //Console.WriteLine("LENGTH="+ ah.s.Length);

            //for(int i = 0; i < ah.l.Length; i++)
            //{
            //    Console.Write(ah.l[i]);
            //    Console.Write(" + ");
            //}
            //Console.WriteLine();
            //foreach(int i in ah.l)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(ah.two);

            //foreach(int i in ah.two)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("2d length="+ah.two.Length);
            //Console.WriteLine("###");
            //Console.WriteLine(ah.d2[0].Length);
            //foreach(int[] i in ah.d2)
            //{
            //    Console.WriteLine(!i.IsFixedSize);
            //    Console.WriteLine(i.LongLength);
            //    Console.WriteLine(i.Rank);
            //    foreach (int ii in i)
            //    {
            //        Console.WriteLine(ii);
            //    }
            //}
            //Console.WriteLine(ah.d2.Rank);
            //Console.WriteLine("RO="+ah.d2.IsReadOnly);
            //Nullable nb = new Nullable();
            //Console.WriteLine(nb.x);
            //Console.WriteLine(nb.y);
            //nb.x = null;
            //nb.y = 22;
            //Console.WriteLine(nb.x+" "+nb.y);
            //nb.f1 = 55.44f;
            //Console.WriteLine(nb.f1);
            //nb.f1 = null;
            //Console.WriteLine(nb.f1);
            //nb.f2 = 77.88f;
            //Console.WriteLine(nb.f2);
            //nb.f2 = null;
            //Console.WriteLine(nb.f2);

            //int n4;
            //n4 = nb.n1 ?? 555;
            //Console.WriteLine("Coalescing="+n4);
            //n4 = nb.n2 ?? 987;
            //Console.WriteLine("Coalescing=" + n4);
            //n4 = nb.n3 ?? 12345;
            //Console.WriteLine("Coalescing=" + n4);
            //nb = new Nullable();
            //Console.WriteLine(nb.x+nb.z);
            //nb.z = nb.x;


            //nb.f3 = 1.34f;
            //Console.WriteLine(nb.f3);
            //nb.f3 = null;
            //Console.WriteLine(nb.f3);

            //int x=50;
            //int y;
            //MethodTest mt = new MethodTest();
            //mt.GetOutput(x,out y);
            //Console.WriteLine(y);

            //mt.SwapInt(50,77);

            //x = 31;
            //y = 98;
            //mt.SwapInt(x,y);
            //Console.WriteLine("x="+x+",y={0}",y);
            //mt.SwapIntRef(ref x,ref y);
            //Console.WriteLine("x=" + x + ",y={0}", y);

            //Test();

            //Console.WriteLine("Recursive Method="+mt.TestRecursive(3,15));

            //String s1 = "Milk";
            //String s2 = "Coffee";
            //string s3;
            //string s4;
            //s1 = "31";
            //s2 = "13";
            //Console.WriteLine("MultiOut="+mt.StringTogether(ref s1,ref s2,out s3,out s4));
            //Console.WriteLine(s3+" "+s4);

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
