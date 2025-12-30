using System;
using System.Security.AccessControl;
class BookDetails
{
    public static void Main(String[]args)
    {
        Details d = new Details("Rich Dad Poor Dad" , "Abhi" , 590);
        d.display(d);
    }
}


public class Details
{
    string BookName;
    string AuthorName;
    double Price;

    public Details(string bookname,string authorname, double price)
    {
        BookName = bookname;
        AuthorName = authorname;
        Price = price;
    }

    public void display(Details d)
    {
        Console.WriteLine("Title  :"+d.BookName+
                    ",  Authorname : "+d.AuthorName+
                    ",   Price : "+Price);
    }

}