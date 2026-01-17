using System;
class ProductSortingQuicksort
{
    // Product product = new Product();
    public static void Main(String[] args)
    {
        solve();
    }

    public static void solve()
    {
        Console.WriteLine("Enter the number of Discounted Products");
        int n = int.Parse(Console.ReadLine());
        Product[] DiscountedProduct = new Product[n];
        for(int i = 0; i < n; i++)
        {
            Console.WriteLine("Enter the name of product: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the DiscontedPrice of product: ");
            int price = int.Parse(Console.ReadLine());
            DiscountedProduct[i] = new Product(name , price);
        }

        quickSort(DiscountedProduct, 0, n-1);

        Console.WriteLine("After sorting The product list is : ");

        for(int i = 0; i < n; i++)
        {
            Console.WriteLine(DiscountedProduct[i].ToString()+" ");
        }
        Console.WriteLine();
    }

    public static  void quickSort(Product[] arr, int start, int end) {
        if(start > end) return ;
      
        int PIndex = partition(arr , start , end );
        quickSort(arr, start , PIndex - 1);
        quickSort(arr, PIndex + 1, end);
        
    }

    public static  int partition(Product[] DiscountedProduct, int start, int end) {
        
        int pivot = DiscountedProduct[start].DiscountedPrice;
        int i = start;
        int j = end;
        while(i <= j)
        {
            while(i <= j && DiscountedProduct[i].DiscountedPrice <= pivot)i++;
            while(i <= j && DiscountedProduct[j].DiscountedPrice > pivot)j--;
            if(i < j) swap(i , j, DiscountedProduct);
        }

        swap(start,j,DiscountedProduct);
        
        return j;
    }
    public static void swap(int i, int j, Product[] arr){
        Product temp = arr[i];
        arr[i] = arr[j];
        arr[j] = temp;
    }    
}