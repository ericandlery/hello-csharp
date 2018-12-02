using System;

public class TestConcrete : TestAbstract
{
    public override void TestAbstractMethod()
    {
        Console.WriteLine("Abstract Method");
    }

    public void TestAbstractMethod(int i)
    {
        Console.WriteLine("Override=>{0}",i);
    }

    public override void TestVirtual()
    {
        Console.WriteLine("Now that's what I'm talking about.");
    }
}