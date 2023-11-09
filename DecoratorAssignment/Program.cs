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
                Beverage beverageChoice = null;
                











            }














































        }
    }
}