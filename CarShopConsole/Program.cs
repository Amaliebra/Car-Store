using CarClassLibrary;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the car store!");

            int action = chooseAction();

            while(action != 0)
            {
                Console.WriteLine();
                Console.WriteLine("You picked: " + action);
                Console.WriteLine();

                switch(action)
                {
                    case 1:
                        Console.WriteLine("Adding a car to the store");
                        break;
                    case 2:
                        Console.WriteLine("Adding a car to the shopping list");
                        break;
                    case 3:
                        Console.WriteLine("Checking out");
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }

                action = chooseAction();
            }

            
        }

        static public int chooseAction()
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add a car to the store");
            Console.WriteLine("2. Add a car to the shopping list");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("0. Exit");

            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                Console.WriteLine("---------------------------");
            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
            return choice;
        }

        //Car c = new Car("Volvo", "V70", 35000.0m);
        //Car d = new Car("Toyota", "Corolla", 20000.0m);

        //Console.WriteLine("Car c is : " + c.Brand + " " + c.Model + " " + c.Price );
        //Console.WriteLine("Car d is : " + d.Brand + " " + d.Model + " " + d.Price );

        //    Store s = new Store();

        //s.ShoppingList.Add(c);
        //    s.ShoppingList.Add(d);
        //    decimal total = s.Checkout();

        //Console.WriteLine("Total price is : " + total);

        //Console.ReadLine();
    }
}