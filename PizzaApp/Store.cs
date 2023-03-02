using System;
using System.Collections.Generic;
using System.Text;

namespace PizzaApp
{
    public class Store
    {
        public void Start()
        {
            Pizza p1 = new Pizza(40, "Pizza1");
            Pizza p2 = new Pizza(50, "Pizza2");
            Pizza p3 = new Pizza(90, "Pizza3");

            Customer c1 = new Customer();
            Customer c2 = new Customer();
            Customer c3 = new Customer();

            Order o1 = new Order(p1, c1);
            Order o2 = new Order(p2, c2);
            Order o3 = new Order(p3, c3);

            Console.WriteLine(p1);
        }
    }
}
