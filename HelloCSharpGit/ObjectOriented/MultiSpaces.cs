using System;

namespace McLaren
{
    public class Test
    {
        public void RevUp()
        {
            Console.WriteLine("I have 18200 rpm!");
        }
    }

}

namespace Williams
{
    public class Test
    {
        public void RevUp()
        {
            Console.WriteLine("With 19000 rpm, I'm the fastest car!");
        }
    }
}

namespace BritishAmericanRacing
{
    public class Test
    {
        public void RevUp()
        {
            Console.WriteLine("20000 rpm here, hold my beer!");
            Jordan.Test jt = new Jordan.Test();
            jt.RevUp();
        }
    }

    namespace Jordan
    {
        public class Test
        {
            public void RevUp()
            {
                Console.WriteLine("I'm poor......");
                RevDown();
            }

            private void RevDown()
            {
                Console.WriteLine("......not!");
            }
        }
    }
}