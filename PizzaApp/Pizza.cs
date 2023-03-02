
using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Pizza
    {
        private double _price;
        private string _name;

        public Pizza(double price, string name)
        {
            _price = price;
            _name = name;
        }

        public double Price { get { return _price; } }
        public string Name { get { return _name; } }

        public override string ToString()
        {
            return $"En pizza: {Name}, Pris: {Price}";
        }
    }
}
