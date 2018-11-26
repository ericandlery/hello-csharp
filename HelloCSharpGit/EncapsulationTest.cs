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

        public void SetParams(String name,double fuel)
        {
            this.name = name;
            this.fuel = fuel;
        }

        public void Display()
        {
            Console.WriteLine("Name="+name);
            Console.WriteLine("Fuel="+fuel);
        }

    }
}