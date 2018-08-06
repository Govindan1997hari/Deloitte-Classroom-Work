using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PizzaOrder> po = new List<PizzaOrder>
            {
                 new PizzaOrder {OrderID=1000,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Toppings="tomato",Qty=2,price=500},
                 new PizzaOrder {OrderID=1001,OrderDate=DateTime.Now,PizzaType="NonVeg",PizzaSize='L',Toppings="chicken",Qty=1,price=300},
                 new PizzaOrder {OrderID=1002,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='M',Toppings="onion",Qty=2,price=250},
                 new PizzaOrder {OrderID=1003,OrderDate=DateTime.Now,PizzaType="Veg",PizzaSize='s',Toppings="capsicum",Qty=1,price=200}
            };
            var temp = from t in po
                       select t;
            foreach (var t in temp)
                Console.WriteLine(t.OrderID + "|" + t.OrderDate + "|" + t.PizzaType + "|" + t.PizzaSize + "|" + t.Toppings + "|" + t.Qty + "|" + t.price);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            var temp1 = from t in po
                       select new { t.PizzaType, t.PizzaSize };
            foreach (var t in temp)
                Console.WriteLine(t.PizzaType + "|" + t.PizzaSize);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            var temp2 = from t in po
                        group t by t.PizzaType into grp
                        select new { Pizzacount = grp.Count(), Amountcollect = grp.Sum(x => x.price) };
            foreach (var t in temp2)
                Console.WriteLine(t.Pizzacount + " " + t.Amountcollect);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            var temp3 = from t in po
                        group t by t.PizzaSize into grp
                        select new { Pizzacount = grp.Count(), Amountcollect = grp.Sum(x => x.price) };
            foreach (var t in temp3)
                Console.WriteLine(t.Pizzacount + " " + t.Amountcollect);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            var temp4 = from t in po
                        where t.PizzaSize == 'M'
                        select new { t.PizzaType, t.Toppings };
            foreach (var t in temp4)
                Console.WriteLine(t.PizzaType + " " + t.Toppings);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
            var temp5 = from t in po
                        where t.price == po.Max(x => x.price)
                        select t;
            foreach (var t in temp5)
                Console.WriteLine(t.OrderID + "|" + t.OrderDate + "|" + t.PizzaType + "|" + t.PizzaSize + "|" + t.Toppings + "|" + t.Qty + "|" + t.price);
            Console.WriteLine("=-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-==-+-=");
        }
    }
}
