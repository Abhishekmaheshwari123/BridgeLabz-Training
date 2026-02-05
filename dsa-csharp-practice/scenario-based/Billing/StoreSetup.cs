using System.Collections.Generic;

class StoreSetup
{
    public static BillingCounter InitializeStore()
    {
        Inventory inventory = new Inventory();
        BillingCounter counter = new BillingCounter(inventory);

        counter.AddCustomer(
            new Customer("Amit", new List<string> { "Milk", "Bread" })
        );

        counter.AddCustomer(
            new Customer("Riya", new List<string> { "Eggs", "Rice", "Milk" })
        );

        return counter;
    }
}
