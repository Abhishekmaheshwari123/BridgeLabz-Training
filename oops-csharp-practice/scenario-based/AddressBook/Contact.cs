using System;
class Contact
{
    string UserFirstName;
    string UserLastName;
    string UserAddress;
    string UserCity;
    string UserState;
    string UserZipCode;
    string UserPhoneNumber;
    string UserEmail;


    public Contact(string userFirstName, string userLastName, string userAddress, string userCity,
            string userState, string userZipCode, string userPhoneNumber, string userEmail)
    {        
        UserFirstName = userFirstName;
        UserLastName = userLastName;
        UserAddress = userAddress;
        UserCity = userCity;
        UserState = userState;
        UserZipCode = userZipCode;
        UserPhoneNumber = userPhoneNumber;
        UserEmail = userEmail;        
    }

    public override string ToString()
    {

        return UserFirstName+"  "+
              UserLastName+" "+
              UserAddress+" "+
              UserCity+" "+
              UserState+" "+
              UserZipCode+" "+
              UserPhoneNumber+" "+
              UserEmail;
    }

}