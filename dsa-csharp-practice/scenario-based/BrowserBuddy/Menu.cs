using System;

class Menu
{
    BrowserUtility utility = new BrowserUtility();
    public void show()
    {
        int n;

        do
        {
            Console.WriteLine("Press 1 to Add a Tab");
            Console.WriteLine("Press 2 to Close a Tab");
            Console.WriteLine("Press 3 to move Forward a Tab");
            Console.WriteLine("Press 4 to move BackWard a Tab");
            Console.WriteLine("Press 5 to Restore a Tab");
            Console.WriteLine("Press 6 to Exit from Browser");
            n = int.Parse(Console.ReadLine());

            switch (n)
            {
                case 1 : utility.AddTab();
                         Console.WriteLine("Tab added Successfully");
                         break;
                case 2 : utility.CloseTab();
                         break;
                case 3 : utility.MoveForwardTab();                       
                         break;
                case 4 : utility.MoveBackwardTab();
                         break;
                case 5 : utility.RestoreTab();
                         break;
                case 6 : Console.WriteLine("Ivalid Choice");
                         break;
                                 
            }
            
        }
        while(n != 6);
    }
}