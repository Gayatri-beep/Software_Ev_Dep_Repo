using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DLL_2._1._3
{
    public static class Price
    {
        public static double FlavourPrice(string flavour)
        {
            if (flavour == "1")
            {
                return 10.00;
            }
            else if (flavour == "2")
            {
                return 3.00;
            }
            else if (flavour == "3")
            {
                return 6.80;
            }

            return 0.00;
        }

        public static double SaucePrice(string sauce)
        {
            if (sauce == "1")
            {
                return 3.50;
            }
            else if (sauce == "2")
            {
                return 0.10;
            }
            else if (sauce == "3")
            {
                return 2.00;
            }

            return 0.00;
        }

        public static double ToppingPrice(string topping)
        {
            if (topping == "1")
            {
                return 3.00;
            }
            else if (topping == "2")
            {
                return 0.50;
            }
            else if (topping == "3")
            {
                return 1.00;
            }

            return 0.00;
        }

        public static double FinalPrice(string flavour, string sauce, string topping)
        {
            return FlavourPrice(flavour) + SaucePrice(sauce) + ToppingPrice(topping);
        }
    }
}
