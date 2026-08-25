using System;

namespace DLL_1_1._3
{
    public static class IceCream
    {
        // Flavour
        public static string Flavour(string flavour)
        {
            if (flavour == "1")
            {
                flavour = "Salted Caramel";
            }

            else if (flavour == "2")
            {
                flavour = "Cookies and Cream";
            }

            else if (flavour == "3")
            {
                flavour = "Mint";
            }

            return flavour;
        }

        // Sauce 
        public static string Sauce(string sauce)
        {
            if (sauce == "1")
            {
                sauce = "Strawberry";
            }

            else if (sauce == "2")
            {
                sauce = "Chocolate";
            }

            else if (sauce == "3")
            {
                sauce = "Caramel Sauce";
            }

            return sauce;
        }

        // Toppings 
        public static string Toppings(string topping)
        {
            if (topping == "1")
            {
                topping = "Nuts";
            }

            else if (topping == "2")
            {
                topping = "Cherry";
            }

            else if (topping == "3")
            {
                topping = "Whipped Cream";
            }

            return topping;
        }

        //Final Order 

        public static string FinalOrder(string flavour, string sauce, string topping)
        {
            return flavour + " ice-cream, with " + sauce + " sauce and " + topping + " toppings!";
        }
    }
}
