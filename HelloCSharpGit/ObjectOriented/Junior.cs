using System;

public class Junior:Veteran
{
    public int a;
    protected int b;
    internal int c;
    private int x;
    private int y;
    private int z;
    
    public int N { get; set; }

    public int X
    {
        get
        {
            return x;
        }
        set
        {
            this.x = value;
        }
    }

    public int Y { get => y; set => y = value; }

    public void Show()
    {
        Console.WriteLine("X="+X);
        Console.WriteLine("Y="+Y);
    }

    public int Add()
    {
        return x + y;
    }

    public int Minus()
    {
        return x - y;
    }

    public void Warning()
    {
        Console.WriteLine("This is a Interface Implementation.");
    }
}