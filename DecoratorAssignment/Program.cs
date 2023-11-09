using System.Text;

namespace DecoratorAssignment
{
    // Instructions
    // You can implement your whole solution here
    // Optionally you can use folder structure if you deem it necessary
    // For this Assignment we will use Decorator pattern example introduced in the book Head First Design Patterns by O'Reilly
    // Chapeter 3 the DecoratorPattern: Decorating Objects (starts at page 79)
    // Link to pdf: https://github.com/ajitpal/BookBank/blob/master/%5BO%60Reilly.%20Head%20First%5D%20-%20Head%20First%20Design%20Patterns%20-%20%5BFreeman%5D.pdf
    // NOTE: Remember that the code examples in this book are written in java so you can't just copy the code examples given there
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable to store total cost of the order
            double totalCost = 0;
            // Variable to store full order description, stringbuilder type object for easier appending
            StringBuilder orderDescription = new StringBuilder();

            while (true)
            {
                Console.WriteLine("Welcome to the Starbuzz Coffee!");
                Console.WriteLine("Please choose your coffee:");
                Console.WriteLine("1. House Blend ($0.89)");
                Console.WriteLine("2. Dark Roast ($0.99)");
                Console.WriteLine("3. Decaf ($1.05)");
                Console.WriteLine("4. Espresso ($1.99)");
                Console.WriteLine("Please select a coffee (1-4) or 5 to proceed to checkout:");

                string userChoice = Console.ReadLine();

                //Object to hold value for chosen beverage
                Beverage? beverageChoice = null;
                //switch structure for main menu options, creates new objects of Beverage type and assigns them to beverageChoice
                switch (userChoice)
                {
                    case "1":
                        beverageChoice = new HouseBlend();
                        break;
                    case "2":
                        beverageChoice = new DarkRoast();
                        break;
                    case "3":
                        beverageChoice = new Decaf();
                        break;
                    case "4":
                        beverageChoice = new Espresso();
                        break;
                    case "5":
                        goto Checkout;
                    default:
                        Console.WriteLine("Please select a valid option from 1 to 5.");
                        continue;
                }

                //Loop for condiments
                while (true)
                {
                    //yes proceeds to condiments selection menu, no interrupts a loop and goes to next step
                    Console.WriteLine("Would you like to add a condiment? (yes/no)");
                    string condimentChoice = Console.ReadLine();
                    //can be hull, converted to lower case to require less precise input, loop continues untill a "no"
                    if (condimentChoice?.ToLower() == "yes")
                    {
                        Console.WriteLine("Select a condiment to add to your coffee:");
                        Console.WriteLine("1. Steamed Milk ($0.20)");
                        Console.WriteLine("2. Mocha ($0.20)");
                        Console.WriteLine("3. Soy ($0.15)");
                        Console.WriteLine("4. Whipped Cream ($0.10)");
                        string condimentType = Console.ReadLine();

                        //replaces beverageChoice object by appending description and price of condiment
                        switch (condimentType)
                        {
                            case "1":
                                beverageChoice = new SteamedMilk(beverageChoice);
                                break;
                            case "2":
                                beverageChoice = new Mocha(beverageChoice);
                                break;
                            case "3":
                                beverageChoice = new Soy(beverageChoice);
                                break;
                            case "4":
                                beverageChoice = new WhippedCream(beverageChoice);
                                break;
                            default:
                                Console.WriteLine("Please select a valid option from 1 to 4.");
                                continue;
                        }
                    }
                    else if (condimentChoice?.ToLower() == "no")
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Please answer 'yes' or 'no'.");
                    }

















                }









                }














































        }
    }
}