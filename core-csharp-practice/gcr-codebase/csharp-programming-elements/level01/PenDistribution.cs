using System;
class PenDistribution
{
    public static void Main(String []args)
    {
        int Pens = 14;
        int EachStudentHave = Pens/3;
        int NotDistributedPen = Pens % 3;

        Console.WriteLine(" The Pen Per Student is "+EachStudentHave+" and the remaining pen not distributed is "+NotDistributedPen);

    }
}