using System;
public class Contact
{
    public string UserFirstName;
    public string UserLastName;
    public string UserAddress;
    public string UserCity;
    public string UserState;
    public string UserZipCode;
    public string UserPhoneNumber;
    public string UserEmail;


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
              UserLastName+" -"+
              UserAddress+" , "+
              UserCity+", "+
              UserState+", "+
              UserZipCode+", "+
              UserPhoneNumber+", "+
              UserEmail;
    }

}