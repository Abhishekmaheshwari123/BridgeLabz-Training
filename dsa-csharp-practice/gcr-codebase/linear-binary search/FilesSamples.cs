using System.IO;
using System.Text;

class FileSamples
{
    public static void Create()
    {
        File.WriteAllLines("data.txt", new string[] { "hello world", "dot net world", "world is big" });
        File.WriteAllBytes("binary.bin", Encoding.ASCII.GetBytes("HelloBinary"));
    }
}
