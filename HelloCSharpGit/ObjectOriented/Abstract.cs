using System;

public abstract class TestAbstract
{
    public abstract void TestAbstractMethod();

    public void TestNonAbstract()
    {
        Console.WriteLine("non-abstract");
    }

    public virtual void TestVirtual()
    {
        Console.WriteLine("This is a Prototype, write your own method.");
    }
}