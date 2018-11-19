using System;
using System.Diagnostics;

namespace HelloApp
{
    class HelloWorld
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Hi, this is my first C Sharp code.");
            HelloApp.Hello2 hi = new HelloApp.Hello2();
            hi.test();

            HelloApp2.Code2 hi2 = new HelloApp2.Code2();
            hi2.test();

            Hello2 h3 = new Hello2();
            Console.WriteLine(h3.test2());

            Code3 h4 = new Code3();
            Console.WriteLine(h4.test());

            Debug.WriteLine("Test Debug Function");

            Console.WriteLine("Debug Completed");
        }
    }

    class Hello2
    {
        public void test()
        {
            Console.WriteLine("Test Method");
        }

        public String test2()
        {
            return "Kimi";
        }
    }

}