using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3
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
            foreach (var o in po)
                Console.WriteLine(o.OrderID + "|" + o.OrderDate + "|" + o.PizzaType + "|" + o.PizzaSize + "|" + o.Toppings + "|" + o.Qty + "|" + o.price);
            Console.WriteLine("******************************");
            foreach (var o in po)
                Console.WriteLine(o.PizzaSize + "|" + o.PizzaType);
            Console.WriteLine("******************************");
            var e = po.GroupBy(x => x.PizzaType).Select(x => new { PizzaCount = x.Count(), AmountCollected = x.Sum(y => y.price) });
            foreach (var temp in e)
                Console.WriteLine(temp.PizzaCount + "|" + temp.AmountCollected);
            Console.WriteLine("******************************");
            var e2 = po.GroupBy(x => x.PizzaSize).Select(x => new { PizzaCount = x.Count(), AmountCollected = x.Sum(y => y.price) });
            foreach (var temp in e2)
                Console.WriteLine(temp.PizzaCount + "|" + temp.AmountCollected);
            Console.WriteLine("******************************");
            var e3 = po.Where(x => x.PizzaSize == 'M').Select(x => new { ordertype = x.PizzaType, ptop = x.Toppings });
            foreach (var temp in e3)
                Console.WriteLine(temp.ordertype+"|"+ temp.ptop);
            Console.WriteLine("******************************");
            var e4 = po.Where(x => x.price == po.Max(y => y.price));
            foreach (var temp in e4)
                Console.WriteLine(temp.OrderID + "|" + temp.OrderDate + "|" + temp.PizzaType + "|" + temp.PizzaSize + "|" + temp.Toppings + "|" + temp.Qty + "|" + temp.price);
            Console.WriteLine("******************************");
        }
    }
}
