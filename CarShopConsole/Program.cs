using CarClassLibrary;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car("Volvo", "V70", 35000.0m);
            Car d = new Car("Toyota", "Corolla", 20000.0m);

            Console.WriteLine("Car c is : " + c.Brand + " " + c.Model + " " + c.Price );
            Console.WriteLine("Car d is : " + d.Brand + " " + d.Model + " " + d.Price );

            Store s = new Store();

            s.ShoppingList.Add(c);
            s.ShoppingList.Add(d);
            decimal total = s.Checkout();

            Console.WriteLine("Total price is : " + total);

            Console.ReadLine();
        }
    }
}