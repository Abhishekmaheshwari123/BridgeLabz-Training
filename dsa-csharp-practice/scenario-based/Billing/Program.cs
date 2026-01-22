using System;

class Program
{
    static void Main()
    {
        BillingCounter counter = StoreSetup.InitializeStore();

        counter.ProcessCustomer();
        counter.ProcessCustomer();
        counter.ProcessCustomer(); // queue empty case
    }
}
