using System;
using System.IO;
using System.Text;

class ReadBinary
{
    static void Main()
    {
        using (StreamReader sr = new StreamReader("binary.bin", Encoding.ASCII))
            Console.WriteLine(sr.ReadToEnd());
    }
}
