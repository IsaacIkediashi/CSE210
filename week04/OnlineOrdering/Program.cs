using System;
class Program
{
    static void Main(string[] args)
    {
        Order order = new Order();     
        order.SetProducts("Jeltons Lotion", "AASS34", 6.0, 3);
        order.SetProducts("White Cream", "EEER45", 7.8, 6);
        order.SetCustomerName("Jake Samuel");
        order.SetAddress("72, Hallway street","Water Lake","Albama","United States");

        Order order1 = new Order();
        order1.SetProducts("Mama's Bread", "ASSER3", 4.56, 2);
        order1.SetProducts("Cream Bun", "AAWER4", 6.78, 45);
        order1.SetCustomerName("Michael Tom");
        order1.SetAddress("36, Rudoff street","New Isles","Vatican","Indonesia");

        
        Console.WriteLine(); 
        for(int i = 0; i < order.GetProducts().Count; i++)
        {
          Console.WriteLine(order.PackingLabel(i));
        }

        Console.WriteLine(order.ShippingLabel());
        Console.WriteLine(order.CalculateTotalCost());

        
        Console.WriteLine(); 
        for(int i = 0; i < order1.GetProducts().Count; i++)
        {
          Console.WriteLine(order1.PackingLabel(i));
        }

        Console.WriteLine(order1.ShippingLabel());
        Console.WriteLine(order1.CalculateTotalCost());      
        
        Console.WriteLine(); 
    }
}