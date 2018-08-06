using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Pdetails e1 = new Pdetails { pizzaname = "margerita", pizzatype = "veg", toppings = "CHEESEE!!", pizzasize = 'S', price = 300 };
            Pdetails e2 = new Pdetails { pizzaname = "chicken pizza", pizzatype = "nonveg", toppings = "Meat", pizzasize = 'M', price = 200 };
            PizzaDBEntities db = new PizzaDBEntities();
            db.PizzaDetails.Add(e1);
            db.PizzaDetails.Add(e2);
            var res = db.SaveChanges();
            if (res > 0)
                Console.WriteLine("data inserted");
        }
    }
}
