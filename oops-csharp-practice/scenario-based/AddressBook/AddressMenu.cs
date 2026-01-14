using System;
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
            n = Convert.ToInt32(Console.ReadLine());

            switch (n)
            {
                case 1 : utility.AddPerson(addperson());
                    Console.WriteLine("Person added Successfully");
                    break;
            }
        }
        while(n != 5);
    }


    Contact addperson()
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