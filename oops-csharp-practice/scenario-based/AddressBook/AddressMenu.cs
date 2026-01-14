using System;
using System.Collections;
using System.ComponentModel.DataAnnotations;
using System.Dynamic;
class AddressMenu
{
    AddContactUtility utility = new AddContactUtility();
    public void show()
    {
        int n ;
        do
        {
            Console.WriteLine("Press 1 to Add Perons");
            Console.WriteLine("Press 2 to Edit a Person using Name");
            Console.WriteLine("Press 3 to Delete a Person using Name");
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1 : utility.AddPerson(utility.InformationOfperson());
                    Console.WriteLine("Person added Successfully");
                    break;
                case 2 : utility.EditPersonUsingName();
                    Console.WriteLine("Person Edited Successfully");
                    break;
                case 3 : utility.DeletePerson();
                    Console.WriteLine("Person Deleted");
                    break;
                case 4: utility.AddMultipleUsers();
                    Console.WriteLine("Persons Added Successfully");
                    break;


            }
        }
        while(n != 5);
    }
}