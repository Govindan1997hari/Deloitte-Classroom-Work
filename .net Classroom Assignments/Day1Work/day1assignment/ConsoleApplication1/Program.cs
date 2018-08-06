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
            int ac_no;
            string customer_nm;
            string account_type;
            char t_type;
            int amount, balance;
            Console.WriteLine("Enter Account No:");
            ac_no = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Customer Name:");
            customer_nm =Console.ReadLine();
            Console.WriteLine("Enter Account type:");
            account_type = Console.ReadLine();
            Console.WriteLine("Enter Balance:");
            balance = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Transaction Type(D/W) :");
            t_type = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Amount:");
            amount = int.Parse(Console.ReadLine());
            Accounts a = new Accounts(ac_no,customer_nm,account_type,balance);
            if (t_type == 'D')
            {
                a.debit(amount);
            }
            else if (t_type == 'W')
            {
                a.credit(amount);
            }
            else
            {
                Console.WriteLine("Wrong Transaction Type");
                return;
            }
            a.showdata();

        }
    }
}
