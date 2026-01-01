using System;

class Person
{
    public string Name;
    public int Age;

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public Person(Person p)
    {
        Name = p.Name;
        Age = p.Age;
    }

    static void Main(string[] args)
    {
        Person p1 = new Person("Abhi", 22);
        
        Person p2 = new Person(p1);   // copy
        
        Console.WriteLine(p1.Name + " - " + p1.Age);
        Console.WriteLine(p2.Name + " - " + p2.Age);
    }
}
