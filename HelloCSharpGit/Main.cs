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
        enum Days {sun,mon};

        public void NonStaticTest()
        {
            Console.WriteLine("non-static method");
        }

        static public void Test()
        {
            Console.WriteLine("static method");
        }

        private static void Main2(String[] args)
        {
            McLaren.Test mt = new McLaren.Test();
            Williams.Test wt = new Williams.Test();
            BritishAmericanRacing.Test bt = new BritishAmericanRacing.Test();
            BritishAmericanRacing.Jordan.Test jt = new BritishAmericanRacing.Jordan.Test();

            mt.RevUp();
            wt.RevUp();
            bt.RevUp();
            jt.RevUp();

            //Box b1 = new Box();
            //b1.X = 5;
            //b1.Y = 4;
            //Box b2 = new Box();
            //b2.X = 7;
            //b2.Y = 5;

            //Console.WriteLine(b1.getArea());
            //Console.WriteLine(b2.getArea());

            //Box b3 = b1 + b2;
            //Console.WriteLine(b3.X+"@@@"+b3.Y);
            //Console.WriteLine(b3.getArea());
            //Console.WriteLine(b1*b2);
            //Console.WriteLine(b1 - b2);

            //OperatorOverride oo = new OperatorOverride();
            //oo.Test("kimi");
            //Operator2 o2 = new Operator2();
            //o2.Test(555);
            //Op3 o3 = new Op3();
            //o3.Test();

            //TestConcrete tc = new TestConcrete();
            //tc.TestNonAbstract();
            //tc.TestAbstractMethod();
            //tc.TestAbstractMethod(557);
            //tc.TestVirtual();
            //TestAbstract ta = new TestAbstract();

            //Junior j = new Junior();
            //j.Warning();

            //Senior s = new Senior();
            //s.Warning();
            //s.getMsg("Pokemon Yellow");

            //Senior s = new Senior();
            //s.Show();
            //Console.WriteLine(s.Multiply());
            ////Console.WriteLine(s.Divide());
            //s.X = 43;
            //s.Y = 3;
            //s.Show();
            //Console.WriteLine(s.Multiply());
            //Console.WriteLine(s.Divide());
            //s.Y = 0;
            //Console.WriteLine(s.Divide());
            //Console.WriteLine(s.Add());

            //Senior ss = new Senior(31,13);
            //int x=ss.Add();
            //Console.WriteLine(x);

            //Junior j = new Junior();
            //j.X = 5;
            //Console.WriteLine(j.X);
            //Console.WriteLine(j.Y);
            //j.Y = 777;
            //Console.WriteLine(j.Y);
            //j.N = 555;
            //Console.WriteLine(j.N);
            //j.Show();
            //Console.WriteLine(j.Add());

            //Console.WriteLine(HelloCSharpGit.Class.StringUtil.ToUpper("i'm lower case words, make me big!"));
            //Console.WriteLine();

            //ConstructorHolla ch = new ConstructorHolla("Ralf","Williams",5);
            //ch.GetValues();
            //ch = new ConstructorHolla();
            //ch.GetValues();

            //EnumsApp ea = new EnumsApp();
            //Console.WriteLine((int)Days.sun);

            //enum Days {sun,mon};

            //PublicStruct ps = new PublicStruct();
            //ps.Test();

            //StructApp.StructClass ss = new StructApp.StructClass();
            //ss.StructTest();
            //Console.WriteLine(ss.mcLaren);
            //ss.mcLaren.name = "McLaren";
            //ss.mcLaren.num = 2;
            //ss.mcLaren.rpm = 18200;
            //ss.mcLaren.champion = false;
            //Console.WriteLine(ss.mcLaren);

            //StructApp.Names names = new StructApp.Names();
            //StructApp.Teams teams = new StructApp.Teams();

            //names.Show();
            //names.SetNames("Kimi","Iceman");
            //names.Show();

            //StringHey sh = new StringHey();
            //Console.WriteLine(sh.s3+" "+sh.s4);
            //Console.WriteLine(sh.c1);

            //string s1 = new string(sh.c1);
            //Console.WriteLine(s1);
            //Console.WriteLine(string.Join("##",sh.s5));
            //Console.WriteLine(String.Join("$",sh.s5));
            //sh.dt = new DateTime(2002,3,26);
            //Console.WriteLine(sh.dt.ToString());
            //Console.WriteLine(String.Format("今年是{0:d}",sh.dt));
            //Console.WriteLine((sh.dt.ToString()));
            ////Console.WriteLine("compare="+sh.s3.CompareTo(sh.s4));
            //Console.WriteLine("compare="+sh.s3==sh.s4);
            //Console.WriteLine("compare="+sh.s1.CompareTo(sh.ss1));
            //Console.WriteLine("compare="+sh.s1.CompareTo(sh.s2));
            //Console.WriteLine("compare="+sh.s1==sh.ss1);

            //Console.WriteLine(args.Length);
        }

        static void Main(String[] args)
        {

            Main2(args);

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
