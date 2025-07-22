using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7
{
    public class Pizza
    {

        private string size;
        private int cheeseToppings;
        private int pepperoniToppings;
        private int hamToppings;

        public Pizza(string size, int cheeseToppings, int pepperoniToppings, int hamToppings)
        {
            this.size = size;
            this.cheeseToppings = cheeseToppings;
            this.pepperoniToppings = pepperoniToppings;
            this.hamToppings = hamToppings;
        }

        public string Size
        {
            get { return size; }
            set { size = value; }
        }

        public int CheeseToppings
        {
            get { return cheeseToppings; }
            set { cheeseToppings = value; }
        }

        public int PepperoniToppings
        {
            get { return pepperoniToppings; }
            set { pepperoniToppings = value; }
        }

        public int HamToppings
        {
            get { return hamToppings; }
            set { hamToppings = value; }
        }

        public double CalcCost()
        {
            int totalToppings = cheeseToppings + pepperoniToppings + hamToppings;
            double basePrice = 0;

            switch (size.ToLower())
            {
                case "small":
                    basePrice = 10;
                    break;
                case "medium":
                    basePrice = 12;
                    break;
                case "large":
                    basePrice = 14;
                    break;
                default:
                    Console.WriteLine("Invalid pizza size.");
                    break;
            }

            return basePrice + (2 * totalToppings);
        }

        public string GetDescription()
        {
            return $"Size: {size}, Topping : Cheese: {cheeseToppings}, Pepperoni: {pepperoniToppings}, Ham: {hamToppings}, Total Cost: ${CalcCost()}";
        }
    }
}
