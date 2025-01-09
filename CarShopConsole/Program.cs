using CarClassLibrary;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            Car d = new Car("Toyota", "Corolla", 20000.0m);

            Console.WriteLine("Car c is : " + c.Brand + " " + c.Model + " " + c.Price );
            Console.WriteLine("Car d is : " + d.Brand + " " + d.Model + " " + d.Price );

            Console.ReadLine();
        }
    }
}