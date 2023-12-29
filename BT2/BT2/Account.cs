using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT2
{
    class Account
    {
        private string id;
        private string name;
        private int balance;
        public Account(string id, string name, int balance)
        {
            this.id = id;
            this.name = name;
            this.balance = balance;
        }
        public string getid()
        {
            return id;
        }
        public string getname()
        {
            return name;
        }
        public int getbalance()
        {
            return balance;
        }
        public void credit(int amount)
        {
            if (amount > 0)
                balance += amount;
        }
        public void debit(int amount)
        {
            if (amount <= balance)
                balance -= amount;
            else
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong");
        }
        public void tranfeTo(Account acc, int amount)
        {
            if (amount <= balance)
            {
                balance -= amount;
                acc.balance += amount;
            }
            else
                Console.WriteLine("So tien vuot qua so du. Rut tien khong thanh cong");
        }
    }
}
