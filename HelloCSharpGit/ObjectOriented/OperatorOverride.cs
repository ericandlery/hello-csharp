using System;

public class Box
{
    //private int x;
    //public int X { get => x; set => x = value; }
    public int X { get; set;}
    public int Y { get; set;}

    public int getArea()
    {
        return X * Y;
    }

    public static Box operator+(Box a,Box b)
    {
        Box box = new Box
        {
            X = a.X + b.X,
            Y = a.Y + b.Y
        };
        //box.X = a.X + b.X;
        //box.Y = a.Y + b.Y;
        return box;
    }

    public static String operator*(Box a,Box b)
    {
        return "You cannot multiply these things, ok?";
    }

    public static Box operator-(Box a,Box b)
    {
        Console.WriteLine("I said you cannot do these silly things!");
        return null;
    }
}

public class OperatorOverride
{
    public string str;

    public void Test(string str)
    {
        this.str = str;
        Console.WriteLine(this.str);
    }
}

public class Operator2
{
    public string str;

    public void Test(int i)
    {
        this.str = i.ToString();
        Console.WriteLine("NumStr=" + this.str);
    }
}

class Op3
{
    public int iii=111;

    public void Test()
    {
        Console.WriteLine(this.iii);
    }
}