using System;
using System.ComponentModel;
class LibraryManagmentSystem
{
    static String [,]books = new String[10,3];
    static void show()
    {

        books[0, 0] = "Clean Code";               books[0, 1] = "Robert C. Martin";   books[0, 2] =  "Available";
        books[1, 0] = "Effective Java";           books[1, 1] = "Joshua Bloch";       books[1, 2] =  "Issued"   ;
        books[2, 0] = "The Pragmatic Programmer"; books[2, 1] = "Andrew Hunt";        books[2, 2] =  "Available";
        books[3, 0] = "Design Patterns";          books[3, 1] = "Erich Gamma";        books[3, 2] =  "Available";
        books[4, 0] = "Refactoring";              books[4, 1] = "Martin Fowler";      books[4, 2] =  "Issued"   ;
        books[5, 0] = "Head First Java";          books[5, 1] = "Kathy Sierra";       books[5, 2] =  "Available";
        books[6, 0] = "C# in Depth";              books[6, 1] = "Jon Skeet";          books[6, 2] =  "Issued"   ;
        books[7, 0] = "Introduction to Algorithms";books[7, 1] = "CLRS";              books[7, 2] =  "Available";
        books[8, 0] = "You Don’t Know JS";        books[8, 1] = "Kyle Simpson";       books[8, 2] =  "Available";
        books[9, 0] = "The Mythical Man-Month";   books[9, 1] = "Fred Brooks";        books[9, 2] =   "Issued"  ;    

        Console.WriteLine("Books in the Library");
        for(int i = 0; i < books.GetLength(0); i++)
        {
            Console.WriteLine(books[i,0]);
        }
    }
    public static void Main(String[] args)
    {
        SolveForUser();
    }
    static void SolveForUser()
    {        
        show();
        Console.WriteLine();
        Console.WriteLine();
        while (true)
        {
            Console.WriteLine("Press 1 to Seach the book");
            int n = int.Parse(Console.ReadLine());
            if(n == 1)
            {
                Search(books);
            }                        
        }
    }
    static void checkAvailability(string[,] books)
    {
        Console.WriteLine("Enter the Title of the book");
        string name = Console.ReadLine();

        for(int i = 0; i < books.GetLength(0); i++)
        {
            if (name.Equals(books[i, 0]))
            {
                if(books[i,2].Equals("Available")){
                    Console.WriteLine("This book is Available and Now Issued to You");
                    books[i,2] = "Issued";
                    return ;
                }
                else Console.WriteLine("This book is issued");
            }
        }
        Console.WriteLine("Sorry This book is not in Library");
        Console.WriteLine("enter 5 to Stop the program");
        int stop = int.Parse(Console.ReadLine());
        if(stop == 5) return ;
        checkAvailability(books);

    }
    static void Search(String [,]books)
    {
        Console.WriteLine("Enter the title of book");
        String s = Console.ReadLine();
        Console.WriteLine("{0,-25} {1,-25} {2,-10}", "Title", "Author", "Status");
        Console.WriteLine(new string('-', 65));

        int c = 0;
        for(int i = 0; i < books.GetLength(0); i++)
        {            
            if(books[i,0].Length < s.Length) continue;
            if(books[i,0].ToLower().IndexOf(s.ToLower()) != -1)
            {
                Console.WriteLine(
                                    "{0,-25} {1,-25} {2,-10}",
                                    books[i,0],
                                    books[i,1],
                                    books[i,2]
                                );

                c++;
            }
        }  
        if(c == 0)
        {
            Console.WriteLine("This book is not in library");
            Search(books);
        }
        Console.WriteLine("if you want to avaible any of the book press 4")      ;
        int n = int.Parse(Console.ReadLine());

        if(n != 4) return ;
        checkAvailability(books);
    }
}
