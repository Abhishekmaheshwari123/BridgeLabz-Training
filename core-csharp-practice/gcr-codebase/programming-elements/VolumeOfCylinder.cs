using System;
class VolumeOfCylinder
{   
    public static void Main(string[] args){
        int radius = Convert.ToInt32(Console.ReadLine());
        int height = Convert.ToInt32(Console.ReadLine());

        float volume = 3.14f * radius * radius * height;

        Console.WriteLine(volume);
    }
}