using System;

public class Senior : Junior,Legend
{
    public Senior(int x,int y)
    {
        X = x;
        Y = y;
    }

    public Senior()
    {
    }

    public new int Add()
    {
        Console.WriteLine(value: "Senior X+Y=" +(X+Y));
        //return X+Y;
        return base.Add();
    }

    public int Multiply()
    {
        return X * Y;
    }

    public double Divide()
    {
        return (double)X / (double)Y;
    }

    public new void Warning()
    {
        base.Warning();
        Console.WriteLine("This is a subImplementation.");
    }

    public void getMsg(string msg)
    {
        Console.WriteLine(msg);
    }
}