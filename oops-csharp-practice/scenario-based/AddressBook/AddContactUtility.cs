using System;
using System.Dynamic;
using System.Runtime.CompilerServices;
class AddContactUtility : IContact
{
    Contact[] Persons = new Contact[100];
    int Index = 0;
    public void AddPerson(Contact Person)
    {
        Persons[Index] = Person;
    }

    public void EditPersonUsingName()
    {
        Persons[OldInfoPerson()] = updatedInformation();
    }

    public void DeletePerson()
    {
        int index = OldInfoPerson();
        if(index < 0 || index >= Index)
        {
            Console.WriteLine("No Name found");
            Console.WriteLine("If you want to delete press 3");
            int ele = int.Parse(Console.ReadLine());
            if(ele == 3) DeletePerson();
            return ;
        }
        shift(index , Persons);
        Index--;
    }


    void shift(int index, Contact[] Persons)
    {
        int i = index;
        for(; i < Index-1 ; i++)
        {
            Persons[i] = Persons[i+1];
        }
        Persons[Index - 1] = null;
    }

    public Contact updatedInformation()
    {
        return InformationOfperson();
    }
    public int OldInfoPerson()
    {
        Console.WriteLine("Enter the name");
        string name = Console.ReadLine();
        for(int i = 0; i < Index; i++)
        {
            if (Persons[i].UserFirstName.Equals(name))
            {
                return i;
            }
        }
        Console.WriteLine("No name Found, Please Retry");
        return OldInfoPerson();
    }
    public Contact InformationOfperson()
    {
        string Firstname = getFName();
        string lastname = getLname();
        string address = getAddress();
        string city = getCity(); 
        string state = getState()   ;
        string zip = getZip();
        string phoneNumber = getPhone();
        string email = getEmail();

        Contact person = new Contact(Firstname , lastname, address , city , state , zip , phoneNumber,  email);
        return person;


    }
    string getEmail()
    {
        Console.Write("Enter the Email: ");
        string email = Console.ReadLine();
        Console.WriteLine();

        int atIndex = -1;
        int dotIndex = -1;

        for (int i = 0; i < email.Length; i++)
        {
            if (email[i] == '@') atIndex = i;
            if (email[i] == '.') dotIndex = i;
        }

        if (atIndex <= 0 || dotIndex <= atIndex + 1 || dotIndex == email.Length - 1)
        {
            Console.WriteLine("Invalid Email");
            return getEmail();
        }

        return email;
    }

    string getPhone()
    {
        Console.Write("Enter the Phone Number: ");
        string phone = Console.ReadLine();
        Console.WriteLine();

        if (phone.Length != 10 || (phone.Length > 1 && phone[0] == '0'))
        {
            Console.WriteLine("Invalid Phone Number");
            return getPhone();
        }


        for (int i = 0; i < phone.Length; i++)
        {
            if (phone[i] < '0' || phone[i] > '9')
            {
                Console.WriteLine("Invalid Phone Number");
                return getPhone();
            }
        }

        return phone;
    }

    string getZip()
    {
        Console.Write("Enter the ZIP Code: ");
        string zip = Console.ReadLine();
        Console.WriteLine();

        if (zip.Length != 6)
        {
            Console.WriteLine("Invalid ZIP Code");
            return getZip();
        }

        for (int i = 0; i < zip.Length; i++)
        {
            if (zip[i] < '0' || zip[i] > '9')
            {
                Console.WriteLine("Invalid ZIP Code");
                return getZip();
            }
        }

        return zip;
    }


    string getState()
    {
         Console.Write("Enter the state: ");
        string state = Console.ReadLine();
        Console.WriteLine();
        for(int i = 0; i < state.Length; i++)
        {
            if(state[i] > 'z' || state[i] < 'a') return getState();
        }

        return state;
    }

    string getCity()
    {
        Console.Write("Enter the city: ");
        string city = Console.ReadLine();
        Console.WriteLine();
        for(int i = 0; i < city.Length; i++)
        {
            if(city[i] > 'z' || city[i] < 'a') return getCity();
        }

        return city;
    }

    string getAddress()
    {
        Console.Write("Enter the address: ");
        string address = Console.ReadLine();
        Console.WriteLine();
        return address;
    }

    string getLname()
    {
        Console.Write("Enter the last Name: ");
        string lastname = Console.ReadLine();
        Console.WriteLine();
        for(int i = 0; i < lastname.Length; i++)
        {
            if(lastname[i] > 'z' || lastname[i] < 'a') {
                Console.WriteLine("Invalid Name");
                return getLname();
            }
        }
        return lastname;
    }
    string getFName()
    {
        Console.Write("Enter the first Name: ");
        string firstname = Console.ReadLine();
        Console.WriteLine();
        for(int i = 0; i < firstname.Length; i++)
        {
            if(firstname[i] > 'z' || firstname[i] < 'a') {
                Console.WriteLine("Invalid Name");
                return getFName();
            }
        }
        return firstname;
    }

}