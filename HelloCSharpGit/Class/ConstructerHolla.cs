using System;

public class ConstructorHolla
{
    private int count = 0;

    private string name;
    private string team;
    private int rpm;

    public ConstructorHolla()
    {
        count++;
    }

    public ConstructorHolla(string name,string team,int rpm)
    {
        count++;
        this.name = name;
        this.team = team;
        this.rpm = rpm;
    }

    ~ConstructorHolla()
    {
        Console.WriteLine("App Closed! "+count);
    }

    public void GetValues()
    {
        Console.WriteLine("Values => "+name);
        Console.WriteLine("Values => "+team);
        Console.WriteLine("Values => "+rpm);
    }
}