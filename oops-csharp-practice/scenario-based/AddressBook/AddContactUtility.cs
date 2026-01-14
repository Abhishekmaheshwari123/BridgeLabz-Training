using System;
class AddContactUtility : IContact
{
    public void AddPerson(Contact Person)
    {
        Console.WriteLine(Person.ToString());
    }

}