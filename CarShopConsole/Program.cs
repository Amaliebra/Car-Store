using CarClassLibrary;

namespace CarShopConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Store s = new Store();

            Console.WriteLine("Welcome to the car store!");

            int action = chooseAction();

            while(action != 0)
            {
                Console.WriteLine();
                Console.WriteLine("You picked: " + action);
                Console.WriteLine();

                switch(action)
                {
                    case 1://Add a car to the store inventory
                        Console.WriteLine("Adding a car to the inventory");
                        string carBrand = "";
                        string carModel = "";
                        int carYear = 0;
                        string carColor = "";
                        decimal carPrice = 0.0m;

                        Console.WriteLine("What brand is the car?");
                        carBrand = Console.ReadLine();

                        Console.WriteLine("The car is what model?");
                        carModel = Console.ReadLine();

                        Console.WriteLine("What color is the car?");
                        carColor = Console.ReadLine();

                        Console.WriteLine("What year is the car from?");
                        carYear = int.TryParse(Console.ReadLine(), out int year) ? year : 0000;

                        Console.WriteLine("What is the value of the car?");
                        carPrice = decimal.TryParse(Console.ReadLine(), out decimal price) ? price : 0.0m;

                        Car newCar = new Car(carBrand, carModel, carPrice, carColor, carYear);
                        s.CarList.Add(newCar);

                        printInventory(s); 
                        break;
                    case 2: //Add a car to the shopping cart
                        Console.WriteLine("You choose adding car to shopping cart");
                        printInventory(s);
                        Console.WriteLine("Which car would you like to add to the shopping cart? (number)");
                        int carNumber = int.Parse(Console.ReadLine());
                        s.ShoppingList.Add(s.CarList[carNumber]);

                        printShoppingCart(s);
                        break;
                    case 3: //Checkout
                        printShoppingCart(s);
                        Console.WriteLine("Subtotal: " + s.Checkout());
                        break;
                    default:
                        break;
                }

                action = chooseAction();
            }

            
        }

        private static void printInventory(Store s)
        {
            Console.WriteLine();
            Console.WriteLine("*********CARS*********");
            Console.WriteLine();
            for (int i = 0; i < s.CarList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " + s.CarList[i]);
            }
        }

        private static void printShoppingCart(Store s)
        {
            Console.WriteLine("Cars in your shopping cart: ");
            Console.WriteLine();
            for(int i = 0; i < s.ShoppingList.Count; i++)
            {
                Console.WriteLine("Car # " + i + " " + s.ShoppingList[i]);
            }
        }

        static public int chooseAction()
        {
            Console.WriteLine();
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Add a car to the store inventory");
            Console.WriteLine("2. Add a car to the shopping list");
            Console.WriteLine("3. Checkout");
            Console.WriteLine("0. Exit");
            Console.WriteLine();

            string input = Console.ReadLine();
            if (int.TryParse(input, out int choice))
            {
                Console.WriteLine();
                Console.WriteLine("---------------------------");
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Please enter a number");
            }
            return choice;
        }
    }
}