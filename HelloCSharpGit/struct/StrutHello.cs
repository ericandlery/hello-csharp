using System;

namespace StructApp
{

    public struct Names
    {
        public string name;
        public string nickName;
    }

    struct Teams{
        public string name;
        public int num;
        public long rpm;
        public bool champion;
    }

    class StructClass
    {

        public Teams mcLaren;

        public void StructTest()
        {
            Console.WriteLine("No NameSpace");
        }
    }

}