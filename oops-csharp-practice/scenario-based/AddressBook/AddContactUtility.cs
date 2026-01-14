using System;
using System.Collections.Generic;

class AddContactUtility : IContact
{

    Dictionary<string, Contact[]> AddressBooks = new Dictionary<string, Contact[]>();
    Dictionary<string, int> Indexes = new Dictionary<string, int>();

    // UC:2 Add Person
    public void AddPerson(Contact person)
    {
        Console.WriteLine("Enter the name of AddressBook:");
        string bookName = Console.ReadLine();

        if (!AddressBooks.ContainsKey(bookName))
        {
            Console.WriteLine("AddressBook not found.");
            return;
        }

        for(int i = 0; i < Indexes[bookName]; i++)
        {
            if (Existed(person,bookName))      // UC: 7  checking for duplicates person in particular AddressBook
            {
                Console.WriteLine("This Person already Existed");
                return ;
            }
        }

        AddressBooks[bookName][Indexes[bookName]] = person;
        Indexes[bookName]++;
    }

    // UC:3 Edit Person
    public void EditPersonUsingName()
    {
        string info = OldInfoPerson();
        if (info == null) return;

        string[] data = info.Split(' ');
        string book = data[0];
        int index = int.Parse(data[1]);

        AddressBooks[book][index] = InformationOfperson();
        Console.WriteLine("Person updated successfully");
    }

    // UC:4 Delete Person
    public void DeletePerson()
    {
        string info = OldInfoPerson();
        if (info == null) return;

        string[] data = info.Split(' ');
        string book = data[0];
        int index = int.Parse(data[1]);

        ShiftLeft(book, index);
        Indexes[book]--;

        Console.WriteLine("Person deleted successfully");
    }

    void ShiftLeft(string book, int deleteIndex)
    {
        Contact[] persons = AddressBooks[book];
        int count = Indexes[book];

        for (int i = deleteIndex; i < count - 1; i++)
        {
            persons[i] = persons[i + 1];
        }
        persons[count - 1] = null;
    }

    // UC:5 Add Multiple Users
    public void AddMultipleUsers()
    {
        Console.WriteLine("Enter AddressBook name:");
        string book = Console.ReadLine();

        if (!AddressBooks.ContainsKey(book))
        {
            Console.WriteLine("AddressBook not found. Creating one.");
            AddAddressBook();
            return;
        }

        Console.WriteLine("Enter number of users:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            if(Existed(InformationOfperson(),book))Console.WriteLine("This user already Exist");
            else {
                AddressBooks[book][Indexes[book]] = InformationOfperson();
                Indexes[book]++;
            }
        }
    }

    // UC:6 Add AddressBook
    public void AddAddressBook()
    {
        Console.WriteLine("Enter new AddressBook name:");
        string name = Console.ReadLine();

        if (AddressBooks.ContainsKey(name))
        {
            Console.WriteLine("AddressBook already exists");
            return;
        }

        AddressBooks[name] = new Contact[100];
        Indexes[name] = 0;
        Console.WriteLine("AddressBook created successfully");
    }

    // UC:8 search Person with city or state in all the addressBooks

    public void Search()
    {
        string CityOrState = Console.ReadLine();
        bool found = false;
        foreach (var books in AddressBooks)
        {
            string AddressBookName = books.Key;
            Contact[]Person = books.Value;
            for(int j = 0; j < Indexes[AddressBookName]; j++)
            {
                if(Person[j].UserCity.Equals(CityOrState) || Person[j].UserState.Equals(CityOrState))
                {
                    Console.WriteLine(Person[j].ToString());
                    Console.WriteLine("-----------");
                    found = true;
                }
            }
        }
        if (!found)
        {
            Console.WriteLine("No Contact Found");
        }
    }

    // Find person
    public string OldInfoPerson()
    {
        Console.WriteLine("Enter AddressBook name:");
        string book = Console.ReadLine();

        if (!AddressBooks.ContainsKey(book))
        {
            Console.WriteLine("AddressBook not found");
            return null;
        }

        Console.WriteLine("Enter Person First Name:");
        string name = Console.ReadLine();

        for (int i = 0; i < Indexes[book]; i++)
        {
            if (AddressBooks[book][i].UserFirstName.Equals(name))
                return book + " " + i;
        }

        Console.WriteLine("Person not found");
        return null;
    }


    Boolean Existed(Contact P, string NameofAddressBook)    // checking for duplicates object with in same AddressBook
    {
        for(int i = 0; i < Indexes[NameofAddressBook]; i++)
        {
            if (AddressBooks[NameofAddressBook][i] == P) return true;
        }
        return false;
    }

    // Create Contact
    public Contact InformationOfperson()
    {
        return new Contact(
            GetFirstName(),
            GetLastName(),
            GetAddress(),
            GetCity(),
            GetState(),
            GetZip(),
            GetPhone(),
            GetEmail()
        );
    }

    string GetFirstName()
    {
        while (true)
        {
            Console.Write("Enter First Name: ");
            string name = Console.ReadLine();
            if (IsOnlyLetters(name)) return name;
            Console.WriteLine("Invalid name");
        }
    }

    string GetLastName()
    {
        while (true)
        {
            Console.Write("Enter Last Name: ");
            string name = Console.ReadLine();
            if (IsOnlyLetters(name)) return name;
            Console.WriteLine("Invalid name");
        }
    }

    string GetCity()
    {
        while (true)
        {
            Console.Write("Enter City: ");
            string city = Console.ReadLine();
            if (IsOnlyLetters(city)) return city;
            Console.WriteLine("Invalid city");
        }
    }

    string GetState()
    {
        while (true)
        {
            Console.Write("Enter State: ");
            string state = Console.ReadLine();
            if (IsOnlyLetters(state)) return state;
            Console.WriteLine("Invalid state");
        }
    }

    string GetAddress()
    {
        Console.Write("Enter Address: ");
        return Console.ReadLine();
    }

    string GetZip()
    {
        while (true)
        {
            Console.Write("Enter ZIP: ");
            string zip = Console.ReadLine();
            if (zip.Length == 6 && IsOnlyDigits(zip)) return zip;
            Console.WriteLine("Invalid ZIP");
        }
    }

    string GetPhone()
    {
        while (true)
        {
            Console.Write("Enter Phone: ");
            string phone = Console.ReadLine();
            if (phone.Length == 10 && IsOnlyDigits(phone)) return phone;
            Console.WriteLine("Invalid phone");
        }
    }

    string GetEmail()
    {
        while (true)
        {
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            if (email.Contains("@") && email.Contains(".")) return email;
            Console.WriteLine("Invalid email");
        }
    }

    bool IsOnlyLetters(string s)
    {
        foreach (char c in s)
            if (!char.IsLetter(c)) return false;
        return true;
    }

    bool IsOnlyDigits(string s)
    {
        foreach (char c in s)
            if (!char.IsDigit(c)) return false;
        return true;
    }
}
