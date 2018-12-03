using System;
using System.Text.RegularExpressions;

public class RegEx
{
    public void Test()
    {
        Console.WriteLine(Regex.Matches("Kimi is king.", @"\bS\K*"));
    }
}