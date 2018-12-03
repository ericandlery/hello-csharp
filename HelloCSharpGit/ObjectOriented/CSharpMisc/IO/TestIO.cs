using System;
using System.IO;

public class TestIO
{
    public void Test()
    {
        FileStream fs = new FileStream("iotest.dat",FileMode.OpenOrCreate,FileAccess.ReadWrite);

        for(int i = 0; i < 50; i++)
        {
            fs.WriteByte((byte)i);
        }

        fs.Position = 0;
        for(int i = 0; i < 50; i++)
        {
            Console.WriteLine(fs.ReadByte()+" ");
        }

        fs.Close();
    }
}