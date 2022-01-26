//This is the revamped menu in C#
//This is the function space of the empanada menu
//These are the properties of the menu, with items
//The items have prices in terms of double

using MenuCollection;

namespace Empanada
{
    public class EmpanadaMenu
    {
        public static void MenuMain()
        {
            MenuData menu1 = new MenuData();

            double single = 1.50;
            double cafe = 4.25;
            double pack = 8.00; 
            double burro = 6.00;

            //This is the while loop that display the menu
            bool repeat = true;

            Console.WriteLine("Welcome back to the Empanada Emporium!");
            Console.WriteLine("Can you please tell us your name?\n");
            string name = Console.ReadLine();
            
            while (repeat)
            {
            

            Console.WriteLine($"Hello {name} what would you like to order today?\n");
            Console.WriteLine("[1] - Single Empanada");
            Console.WriteLine("[2] - Empanada and Coffee Combo");
            Console.WriteLine("[3] - Six Empanada To-go Pack");
            Console.WriteLine("[4] - Burrito and Nacho Combo");
            Console.WriteLine("[5] - See the Online Order list");
            Console.WriteLine("[6] - Add your name to the Online Order list");
            Console.WriteLine("[7] - Remove your name from the Online Order list");
            Console.WriteLine("[8] - Search for a name in the online Order list");
            Console.WriteLine("[9] - Print out the Online Order list");
            Console.WriteLine("[9] - Exit the menu");

            string userInput = Console.ReadLine();

            if (userInput == "1")
            {
                Console.WriteLine($"That will be ${single}!");
                Console.WriteLine("Please press enter key to continue");
                Console.ReadLine();
            }
            else if (userInput == "2")
            {
                Console.WriteLine($"That will be ${cafe}!");
                Console.WriteLine("Please press enter key to continue");
                Console.ReadLine();
            }
            else if (userInput == "3")
            {
                Console.WriteLine($"That will be ${pack}!");
                Console.WriteLine("Please press enter key to continue");
                Console.ReadLine();
            }
            else if (userInput == "4")
            {
                Console.WriteLine($"That will be ${burro}!");
                Console.WriteLine("Please press enter key to continue");
                Console.ReadLine();
            }
            else if (userInput == "5")
            {
                menu1.ShowStrings();
                Console.WriteLine("Press the enter key to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == "6")
            {
                Console.WriteLine("Enter your name:");
                string str = Console.ReadLine();
                menu1.AddStrings(str);
                Console.WriteLine("Press the enter key to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == "7")
            {
                Console.WriteLine("Enter the name you want removed:");
                string str = Console.ReadLine();
                menu1.RemoveStrings(str);
                Console.WriteLine("Your name has been removed from the Online Order list.");
                Console.WriteLine("Press the enter key to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == "8")
            {
                menu1.SearchStrings();
                Console.WriteLine("Press the enter key to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == "9")
            {
                menu1.PrintStrings();
                Console.WriteLine("Press the enter key to return to the main menu.");
                Console.ReadLine();
            }
            else if (userInput == "10")
            {
                Console.WriteLine("Have a good day!");
                repeat = false;
            }
            else
            {
                Console.WriteLine("You have made an invalid selection");
                Console.WriteLine("Please press enter key to continue");
                Console.ReadLine();

            }
            }
        }
    }
}
   


    
  
