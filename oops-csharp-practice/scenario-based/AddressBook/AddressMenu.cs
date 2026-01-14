using System;

class AddressMenu
{
    AddContactUtility utility = new AddContactUtility();

    public void show()
    {
        int choice;

        do
        {
            Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
            Console.WriteLine("1. Add Person");
            Console.WriteLine("2. Edit Person using Name");
            Console.WriteLine("3. Delete Person using Name");
            Console.WriteLine("4. Add Multiple Users");
            Console.WriteLine("5. Add Address Book");
            Console.WriteLine("6. Exit");
            Console.Write("Enter your choice: ");

            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    utility.AddPerson(utility.InformationOfperson());
                    Console.WriteLine("Person added successfully");
                    break;

                case 2:
                    utility.EditPersonUsingName();
                    Console.WriteLine("Person edited successfully");
                    break;

                case 3:
                    utility.DeletePerson();
                    Console.WriteLine("Person deleted successfully");
                    break;

                case 4:
                    utility.AddMultipleUsers();
                    Console.WriteLine("Users added successfully");
                    break;

                case 5:
                    utility.AddAddressBook();
                    Console.WriteLine("Address book added successfully");
                    break;

                case 6:
                    Console.WriteLine("Exiting application...");
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }

        } while (choice != 6); // ✅ Exit only when user selects Exit
    }
}
