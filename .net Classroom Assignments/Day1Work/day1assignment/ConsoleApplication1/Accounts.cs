using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Accounts
    {
        int acc_no;
        string cust_nm;
        string acc_type;
        char tras_type;
        int amount, balance;
        public Accounts(int acc_no,string cust_nm,string acc_type,int balance)
        {
            this.acc_no = acc_no;
            this.cust_nm = cust_nm;
            this.acc_type = acc_type;
            this.balance = balance;
        }
        public void credit(int amount)
        {
            this.amount = amount;
            balance = balance + amount;
            Console.WriteLine("Successfully Credited");
        }
        public void debit(int amt)
        {
            amount = amt;
            balance = balance - amount;
            Console.WriteLine("Successfully debitted");
        }
        public void showdata()
        {
            Console.WriteLine("Account no:" + acc_no);
            Console.WriteLine("Customer Name:" + cust_nm);
            Console.WriteLine("account type:" + acc_type);
            Console.WriteLine("Current Balance:" + balance);
        }
    }
}
