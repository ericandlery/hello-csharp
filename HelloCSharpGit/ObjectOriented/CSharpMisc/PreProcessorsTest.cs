#define PI
#define Lambda
using System;

public class PreProcessorsTest
{
    public void Test()
    {
#if(PI)
        Console.WriteLine("PI");
#else
        Console.WriteLine("No PI");
#endif

#if (PI && Lambda)
        Console.WriteLine("Equal");
#elif(PI != Lambda)
        Console.WriteLine("Non-equal");
#endif
    }
}