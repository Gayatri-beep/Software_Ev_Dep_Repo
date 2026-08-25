using System;
using DLL_1_1._3;
using DLL_2._1._3;

namespace ConsoleApp_1._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to an Ice-cream Factory, where we re-create you into an ice-cream order !");
            Console.WriteLine("Please respond to the following questions by selecting the statement that best describes you, by entering the corresponding number.");
            
            // Question 1
            PromptStatement();
            Console.WriteLine("1) Assertive/Competitive, 2) Compassionate/Hopeful, 3) Stoic/Methodical");
            string personality = Console.ReadLine();

            // Question 2
            PromptStatement();
            Console.WriteLine("1) Irritated/Anxious 2) Content/Cheerful 3) Observant/focus");
            string emotion = Console.ReadLine();

            // Question 3
            Console.WriteLine("Which is your favourite genre?");
            Console.WriteLine("1) Action ! 2) Comedy ! 3) Mystery !");
            string genre = Console.ReadLine();

            // Get Ice-cream Order + Price
            string flavour = IceCream.Flavour(personality);
            string sauce = IceCream.Sauce(emotion);
            string topping = IceCream.Toppings(genre);

            double finalPrice = Price.FinalPrice(personality, emotion, genre);
            string finalOrder = IceCream.FinalOrder(flavour, sauce, topping);


            // Order
            Console.WriteLine("Here is your order, a " + finalOrder + " for $" + finalPrice.ToString("0.00") + ". Do you see the resemblance?");
            Console.WriteLine("Thank you for visiting, please come again! Please perss any key to exit :)");
            Console.ReadKey(); 
        }

            // Prompt Statement 
            private static void PromptStatement()
        {
            Console.WriteLine("Which statement best describes you?");
        }

    }
}
