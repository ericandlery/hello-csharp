using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloCSharpGit;

namespace HelloCSharpGit
{
    class EncapsulationTest
    {
        public String team;
        public int rpm;

        public void SetParams(String team,int rpm)
        {
            this.team = team;
            this.rpm = rpm;
        }

        public void DisplayParams()
        {
            Console.WriteLine("Team="+team);
            Console.WriteLine("RPM="+rpm);
        }

    }
}

namespace TestName
{
    class EncapsulationTest
    {
        private String name;
        private double fuel;
        sbyte b;

        public void SetParams(String name,double fuel)
        {
            this.name = name;
            this.fuel = fuel;
        }

        public void Display()
        {
            Console.WriteLine("Name="+name);
            Console.WriteLine("Fuel="+fuel);
            Console.WriteLine(GetString());
            ShowByteSize();
        }

        String GetString()
        {
            return "F1 2002";
        }

        public void SetByte(sbyte b)
        {
            this.b = b;
        }
        
        public sbyte GetByte()
        {
            return b;
        }

        private void ShowByteSize()
        {
            Console.WriteLine("Max Size="+byte.MaxValue+", min size={0}",byte.MinValue);
            Console.WriteLine("Max Size="+sbyte.MaxValue+", min size={0}", sbyte.MinValue);
            return;
        }

    }
}