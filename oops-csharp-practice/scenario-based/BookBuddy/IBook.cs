using System;
interface IBook
{
    // void update();
     void addBook(String Title, String Author);
     void searchByAuthor(String Author);

     void sortBookByAlphabetically();

     void Display();
}