using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Order
    {
        private Pizza _pizza;
        private Customer _customer;

        public Order(Pizza pizza, Customer customer)
        {
            _pizza = pizza;
            _customer = customer;
        }


    }
}
